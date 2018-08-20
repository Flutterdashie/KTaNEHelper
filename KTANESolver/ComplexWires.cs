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
        private DataTable recentWires;
        public frmComplexWires()
        {
            InitializeComponent();
            clbEdgeworkData.Enabled = true;
            btnResetEdgework.Enabled = true;
            startTable();
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
            startTable();
        }


        private void startTable()
        {
            recentWires = new DataTable();
            recentWires.Columns.Add("Wire");
            recentWires.Columns.Add("Calculation");
            recentWires.Columns.Add("Action");
            dgvWires.DataSource = recentWires;
        }

        private String wireToString()
        {
            String wireShort = "";
            if (chkRed.Checked)
                wireShort += "R";
            if (chkBlue.Checked)
                wireShort += "B";
            if (chkLED.Checked)
                wireShort += "L";
            if (chkStar.Checked)
                wireShort += "S";
            if (wireShort.Length == 0)
                wireShort = "none";
            return wireShort;
        }

        private void calculateWire(object sender, EventArgs e)
        {
            char currentStatus = getCutStatus(chkRed.Checked, chkBlue.Checked, chkLED.Checked, chkStar.Checked);
            lblCutOutput.Text = useCutStatus(currentStatus);
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
            chkRed.Checked = false;
            chkBlue.Checked = false;
            chkLED.Checked = false;
            chkStar.Checked = false;
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

        private void readInShort(String input)
        {
            chkRed.Checked = input.Contains("R");
            chkBlue.Checked = input.Contains("B");
            chkLED.Checked = input.Contains("L");
            chkStar.Checked = input.Contains("S");

        }

        private bool shortCutStatus(char cutStatus)
        {
            switch (cutStatus)
            {
                case 'C':
                    return true;
                case 'D':
                    return false;
                case 'S':
                    return clbEdgeworkData.GetItemChecked(0);
                case 'B':
                    return clbEdgeworkData.GetItemChecked(1);
                case 'P':
                    return clbEdgeworkData.GetItemChecked(2);
                default:
                    return false;
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

        private void fireUpdateAFTERCheck(object sender, ItemCheckEventArgs e)
        {
            /*Thank you so much to softburger and Larry on StackOverflow
            * Otherwise I would've had to redo this clb as a bunch of check boxes
            * This fix is almost entirely their code, and makes it so that the
            * calculate wire method will calculate using the NEW value from
            * the checkbox that started this event, rather than using the
            * old one, as there's not an event that fires after a check is 
            * changed inside a CLB.
            * https://stackoverflow.com/questions/3666682/which-checkedlistbox-event-triggers-after-a-item-is-checked
            */
            CheckedListBox clb = (CheckedListBox)sender;
            // Switch off event handler
            clb.ItemCheck -= fireUpdateAFTERCheck;
            clb.SetItemCheckState(e.Index, e.NewValue);
            // Switch on event handler
            clb.ItemCheck += fireUpdateAFTERCheck;

            // Now you can go further
            calculateWire(sender, e);
        }

        private void logToTable(object sender, EventArgs e)
        {
            if (recentWires == null)
            {
                startTable();
            }
            DataRow row = recentWires.NewRow();
            char currentStatus = getCutStatus(chkRed.Checked, chkBlue.Checked, chkLED.Checked, chkStar.Checked);
            row["Wire"] = wireToString();
            row["Calculation"] = currentStatus;
            row["Action"] = shortCutStatus(currentStatus) ? "Cut" : "Leave";
            recentWires.Rows.Add(row);
        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            if (recentWires != null)
                recentWires.Clear();
        }

        private void lnkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblShortHelp.Visible = !lblShortHelp.Visible;
        }

        private void txtShorthand_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    readInShort(txtShorthand.Text);
                    logToTable(sender, e);
                    txtShorthand.ResetText();
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Space:
                    txtShorthand.ResetText();
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Escape:
                    btnClearTable_Click(sender, e);
                    txtShorthand.ResetText();
                    e.SuppressKeyPress = true;
                    break;
            }
        }
    }
}
