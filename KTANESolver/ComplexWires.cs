using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTANESolver
{
    public partial class frmComplexWires : Form
    {
        private Edgework currentBomb;
        public frmComplexWires()
        {
            InitializeComponent();
            clbEdgeworkData.Enabled = true;
            btnResetEdgework.Enabled = true;
        }
        public frmComplexWires(Edgework edges)
        {
            InitializeComponent();
            currentBomb = edges;
            clbEdgeworkData.Enabled = false;
            btnResetEdgework.Enabled = false;
            clbEdgeworkData.SetItemChecked(0, !(edges.isSerialOdd()));
            clbEdgeworkData.SetItemChecked(1, (edges.getBatteries() >= 2));
            clbEdgeworkData.SetItemChecked(2, (edges.portCount("PARALLEL") >= 1));
        }

        private void calculateWire(object sender, EventArgs e)
        {
            bool[] checkBoxes = new bool[4];
            for (int i = 0; i < 4; i++)
            {
                checkBoxes[i] = clbWireProperties.GetItemChecked(i);
            }
            lblCutOutput.Text = useCutStatus(getCutStatus(checkBoxes));
        }

        private void toggleEdgeworkLock(object sender, EventArgs e)
        {
            bool isUnlocked = clbEdgeworkData.Enabled;
            clbEdgeworkData.Enabled = !isUnlocked;
            btnResetEdgework.Enabled = !isUnlocked;
        }

        private void btnResetEdgework_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbEdgeworkData.Items.Count; i++)
            {
                clbEdgeworkData.SetItemChecked(i, false);
            }
        }

        private void btnClearWireInput_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbWireProperties.Items.Count; i++)
            {
                clbWireProperties.SetItemChecked(i, false);
            }
        }

        private char getCutStatus(bool isRed, bool isBlue, bool isLit, bool isStarred)
        {
            //I'll check back on this from time to time to try and condense the logic down, but for now,
            //it's gonna be a little bit messy. Also, C is cut, D is don't, S is cut if Serial is even,
            //P is cut if parallel port on bomb, B is cut if battery count is 2+.

            //Current method is relatively unoptimized, checks LED/Star status first, then checks color.
            //Each output will have at least one 4 digit binary number (eg 1101) next to it to represent Red Blue LED Star in that order.
            if (!isLit && !isStarred)
            {
                //??00
                if(!isRed && !isBlue)
                {
                    //0000
                    return 'C';
                }
                else
                {
                    //0100, 1000, 1100
                    return 'S';
                }
            }
            else if(isLit && !isStarred)
            {
                //??10
                if(!isRed)
                {
                    //0?10
                    if(!isBlue)
                    {
                        //0010
                        return 'D';
                    }
                    else
                    {
                        //0110
                        return 'P';
                    }
                }
                else
                {
                    //1?10
                    if(isBlue)
                    {
                        //1110
                        return 'S';
                    }
                    else
                    {
                        //1010
                        return 'B';
                    }
                }
            }
            else if (!isLit && isStarred)
            {
                //??01
                if(!isBlue)
                {
                    //0001, 1001
                    return 'C';
                }
                else
                {
                    //?101
                    if(isRed)
                    {
                        //1101
                        return 'P';
                    }
                    else
                    {
                        //0101
                        return 'D';
                    }
                }
            }
            else
            {
                //??11
                if(!isBlue)
                {
                    //0011, 1011
                    return 'B';
                }
                else
                {
                    //?111
                    if (isRed)
                    {
                        //1111
                        return 'D';
                    }
                    else
                    {
                        //0111
                        return 'P';
                    }
                }
            }

        }

        private char getCutStatus(bool[] checkData)
        {
            if (checkData.Length == 4)
            {
                return getCutStatus(checkData[0], checkData[1], checkData[2], checkData[3]);
            }
            else
            {
                return '?';
            }
        }

        private String useCutStatus(char cutStatus)
        {
            
            String outputString = "";
            bool shouldCut;
            switch(cutStatus)
            {
                case 'C':
                    shouldCut = true;
                    outputString = ", and the edgework was not relevant to this decision.";
                    break;
                case 'D':
                    shouldCut = false;
                    outputString = ", and the edgework was not relevant to this decision.";
                    break;
                case 'S':
                    shouldCut = clbEdgeworkData.GetItemChecked(0);
                    outputString = " because the serial number is ";
                    outputString += shouldCut ? "even." : "odd.";
                    break;
                case 'B':
                    shouldCut = clbEdgeworkData.GetItemChecked(1);
                    outputString = " because the number of batteries on the bomb is ";
                    outputString += shouldCut ? "" : "not ";
                    outputString += "2+.";
                    break;
                case 'P':
                    shouldCut = clbEdgeworkData.GetItemChecked(2);
                    outputString = " because the bomb ";
                    outputString += shouldCut ? "has " : "does not have ";
                    outputString += "a parallel port.";
                    break;
                default:
                    shouldCut = false;
                    outputString = " because the wire logic ran into an error.";
                    break;
            }
            String shouldCutText = "The wire should ";
            shouldCutText += shouldCut ? "" : "NOT ";
            shouldCutText += "be cut" + outputString;
            return shouldCutText;
        }
    }
}
