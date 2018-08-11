using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANESolver
{
    /* This defines and processes what is known as the bomb's "edgework"
     * The edgework is what is on the edges of the bomb, including things like
     * Ports (parallel, RCA, DVI, etc)
     * Batteries & Holders: AA and D varieties (2 and 1 per holder, respectively)
     * Indicators containing a 3 letter code and an LED that has both a lit and unlit state.
     * A ton of this stuff will probably not be used for a while, but I'm coding this with support for every Twitch Plays mod in mind
     * This includes some things that might not be used for a while, but I'm not going to include complex things 
     * such as port plates as of yet.
     * I was originally planning to use the common shorthand found on Twitch Plays to allow for quicker setup, but it seems
     * like it'd be FAR more trouble than it's worth. Maybe some other time.
     */
    public class Edgework
    {
        private int batteryAA, batteryD, batteryHolders, batteryTotal;
        private List<String> litIndicators, unlitIndicators, ports;
        private String serialNum;
        public Edgework()
        {
            batteryAA = 0;
            batteryD = 0;
            batteryHolders = 0;
            batteryTotal = 0;
            serialNum = "unknown";
        }

        public Edgework(int batteries, int holders, String litList, String unlitList, String portList, String serial)
        {
            batteryTotal = batteries;
            batteryHolders = holders;
            batteryAA = (batteries - holders) * 2;
            batteryD = batteries - batteryAA;
            litIndicators = splitCommaList(litList);
            unlitIndicators = splitCommaList(unlitList);
            ports = splitCommaList(portList);
            serialNum = serial.Trim();

        }

        public List<String> splitCommaList(String commaList)
        {
            List<String> tempList = new List<String>();
            if(commaList.Length != 0)
            {
                //At this time, I'm having quite the adventure trying to get the parser to ignore newlines.
                //Temporary fix: I disabled pressing the enter key while inside the port textbox.
                String[] matrixOutput = commaList.Split(',',' ','\r','\n');
                Console.WriteLine(matrixOutput.Length);
                for (int i = 0; i < matrixOutput.Length; i++)
                {
                    string x = matrixOutput[i];
                    x = x.Trim('\r', ' ', '\n');
                    if (!x.Equals(String.Empty))
                    {
                        tempList.Add(x);
                    }
                }
            }
            return tempList;
        }
        
        public override string ToString()
        {
            string shorthand = batteryTotal + "B " + batteryHolders + "H //";
            foreach (String x in litIndicators)
            {
                shorthand += " *" + x;
            }
            foreach (String y in unlitIndicators)
            {
                shorthand += " " + y;
            }
            shorthand += " //";
            foreach(String z in ports)
            {
                shorthand += " " + z;
            }
            shorthand += " // " + serialNum;
            return shorthand;
        }

        public bool isSerialOdd()
        {
            return ((int.Parse(serialNum.LastOrDefault().ToString()) % 2) == 1);
        }

        public int portCount(String targetPort)
        {
            int numFound = 0;
            foreach (String x in ports)
            {
                if (x.Equals(targetPort))
                {
                    numFound++;
                }
            }

            return numFound;
        }
        
        public int getBatteries()
        {
            return batteryTotal;
        }

        public int getHolders()
        {
            return batteryHolders;
        }

        public bool findIndicator(String target, bool isLit)
        {
            List<String> tempList = isLit ? litIndicators : unlitIndicators;
            foreach (String x in tempList)
            {
                if (x.Equals(target))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
