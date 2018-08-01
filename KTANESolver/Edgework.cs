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
     * The typical shorthand for edgework is rather difficult to parse due to the fact
     * that entire sections are simply removed if absent rather than being set to zero or left blank
     */
    class Edgework
    {
        private String shorthandEdgework;
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
        public Edgework(String shortEdges)
        {
            shorthandEdgework = shortEdges;
        }
        public void updateToShorthand()
        {

        }
        public void updateFromShorthand()
        {

        }
    }
}
