using KTANESolver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWires
{
    public partial class frmSimpleWires : Form
    {
        private WireList wireList;
        private static List<String> THREE_WIRE_TEST = new List<String>{ "blue", "blue", "red"};
        private bool edgeworkInherited, serialIsOdd;
        public frmSimpleWires()
        {
            InitializeComponent();
            wireList = new WireList();
            updateWireView();
            updateButtonStatus();
            edgeworkInherited = false;
        }
        public frmSimpleWires(Edgework edges)
        {
            InitializeComponent();
            wireList = new WireList();
            updateWireView();
            updateButtonStatus();
            edgeworkInherited = true;
            serialIsOdd = edges.isSerialOdd();
            chkSerialOdd.Checked = serialIsOdd;
            chkSerialOdd.Enabled = false;
            chkSerialOdd.Text = "Serial number inherited from current\n bomb.";
        }

        private void updateWireView()
        {
            //Stack overflow here to save the day again! I really did not want to 
            //manually iterate over each item, it takes up a bunch of lines and looks bad.
            //I had to in the button status method :\
            lblCutNumber.Text = "Don\'t cut yet, I\'m not done thinking!";
            List<String> currWires = wireList.getWires();
            TableLayoutControlCollection controls = tlpCurrentWires.Controls;
            int visibleWires = wireList.getLength();
            foreach (Control ctrl in tlpCurrentWires.Controls)
            {
                if (ctrl is Label)
                {
                    ctrl.Visible = false;
                }
            }
            for (int i = 0; i < visibleWires; ++i) {
                if (controls[i] is Label)
                {
                    controls[i].ForeColor = Color.FromName(currWires[i]);
                    controls[i].Visible = true;
                }
            }
        }
        
        private void updateButtonStatus()
        {
            int curLength = wireList.getLength();
            bool addButtonsOn = (curLength <= 5);
            btnAddBlack.Enabled = addButtonsOn;
            btnAddBlue.Enabled = addButtonsOn;
            btnAddRed.Enabled = addButtonsOn;
            btnAddYellow.Enabled = addButtonsOn;
            btnAddWhite.Enabled = addButtonsOn;
            btnDeleteWire.Enabled = (curLength >= 1);
            btnSubmit.Enabled = ((curLength >= 3) && (curLength <= 6));
        }

        private void addNewWire(String wireColor)
        {
            wireList.addToList(wireColor);
            updateButtonStatus();
            updateWireView();
        }


        private void removeWire(object sender, EventArgs e)
        {
            wireList.delLastWire();
            updateButtonStatus();
            updateWireView();
        }

        private void btnAddWhite_Click(object sender, EventArgs e)
        {
            addNewWire("white");
        }

        private void btnAddYellow_Click(object sender, EventArgs e)
        {
            addNewWire("yellow");
        }

        private void btnAddBlack_Click(object sender, EventArgs e)
        {
            addNewWire("black");
        }

        private void btnAddBlue_Click(object sender, EventArgs e)
        {
            addNewWire("blue");
        }

        private void btnAddRed_Click(object sender, EventArgs e)
        {
            addNewWire("red");
        }

        private void runCalculations(object sender, EventArgs e)
        {
            switch(wireList.getLength())
            {
                case 3:
                    lblCutNumber.Text = threeWireCalc();
                    break;
                case 4:
                    lblCutNumber.Text = fourWireCalc();
                    break;
                case 5:
                    lblCutNumber.Text = fiveWireCalc();
                    break;
                case 6:
                    lblCutNumber.Text = sixWireCalc();
                    break;
                default:
                    lblCutNumber.Text = "Oops! Something has gone wrong in the wire counting switch.";
                    break;
            }
        }

        private void resetForm(object sender, EventArgs e)
        {
            if (!edgeworkInherited)
            {
                chkSerialOdd.Checked = false;
            }
            wireList.resetList();
            updateWireView();
            updateButtonStatus();
        }
        private String threeWireCalc()
        {
            //Bit of a roundabout method, but this checks to see if the three wires are
            //blue, blue, red, in that order.
            bool wireTested = true;
            for (int i = 0; i < 3; i++)
            {
                if(!(wireList.getWires().ElementAt(i) == THREE_WIRE_TEST.ElementAt(i)))
                {
                    wireTested = false;
                }
            }
            if(wireTested || (wireList.howMany("red") == 0))
            {
                return "Cut the second wire";
            }
            return "Cut the last wire";
        }

        private String fourWireCalc()
        {
            if ((wireList.howMany("red") >= 2) && chkSerialOdd.Checked)
            {
                return "Cut the last red wire";
            }
            else if((wireList.isLastWire("yellow")) && (wireList.howMany("red") == 0))
            {
                return "Cut the first wire";
            }
            else if(wireList.howMany("blue") == 1)
            {
                return "Cut the first wire";
            }
            else if(wireList.howMany("yellow") >= 2)
            {
                return "Cut the last wire";
            }
            else
            {
                return "Cut the second wire";
            }
        }

        private String fiveWireCalc()
        {
            if (wireList.isLastWire("black") && chkSerialOdd.Checked)
            {
                return "Cut the fourth wire";
            }
            else if ((wireList.howMany("red") == 1) &&(wireList.howMany("yellow") >= 2))
            {
                return "Cut the first wire";
            }
            else if (wireList.howMany("black") == 0)
            {
                return "Cut the second wire";
            }
            else
            {
                return "Cut the first wire";
            }
        }

        private String sixWireCalc()
        {
            if((wireList.howMany("yellow") == 0) && chkSerialOdd.Checked)
            {
                return "Cut the third wire";
            }
            else if ((wireList.howMany("yellow") == 1) && (wireList.howMany("white") >= 2))
            {
                return "Cut the 4th wire";
            }
            else if(wireList.howMany("red") == 0)
            {
                return "Cut the last wire";
            }
            else
            {
                return "Cut the 4th wire";
            }
        }


        private void refreshChecked(object sender, EventArgs e)
        {
            //Makes sure that it removes any stored solution if the check is changed, as that'd
            //change the solution.
            updateWireView();
        }

        private void spawnWebPage(String url)
        {
            //thanks again, stackoverflow! https://stackoverflow.com/questions/58024/open-a-url-from-windows-forms
            ProcessStartInfo sendToSite = new ProcessStartInfo(url);
            Process.Start(sendToSite);

        }

        private void normalManualClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            spawnWebPage("http://www.bombmanual.com/manual/1/html/index.html");
        }

        private void clickedOnCheckbox(object sender, MouseEventArgs e)
        {

        }

        private void optimizedManualClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            spawnWebPage("https://ktane.timwi.de/HTML/Wires%20optimized%20(Timwi).html");
        }
    }
}
