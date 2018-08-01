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
    class Edgework
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
                commaList.Trim();
                String[] matrixOutput = commaList.Split(',');
                foreach(String x in matrixOutput)
                {
                    x.Trim();
                    tempList.Add(x);
                }
            }
            return tempList;
        }

    }
}
