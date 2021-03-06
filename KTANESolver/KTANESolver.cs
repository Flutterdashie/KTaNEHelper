﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KTANESolver
{
    public partial class KTANESolver : Form
    {
        private static Regex VALID_SERIAL_REGEX = new Regex("^[A-Z0-9][A-Z0-9][0-9][A-Z][A-Z][0-9]$");
        private Edgework edgework;
        private bool edgeworkReady;
        public KTANESolver()
        {
            InitializeComponent();
            edgeworkReady = false;
        }

        private void btnLaunchWires_Click(object sender, EventArgs e)
        {
            if (edgeworkReady)
            {
                Form simpleWires = new SimpleWires.frmSimpleWires(edgework);
                simpleWires.Show();
            }
            else
            {
                Form simpleWires = new SimpleWires.frmSimpleWires();
                simpleWires.Show();
            }
            
        }

        private void applyEdgework(object sender, EventArgs e)
        {
            //Time for a whole lot of checking!
            //Here's some temporary variables to make it easier to read everything and have fewer calls to controls mid-statement.
            //Shoutouts to @Blananas2#6835 in the KTaNE discord for making a post long ago explaining the format of the serial number.
            //I then turned his post into a regex! Could probably use a little optimization, but it'll do for now
            //I tried to use the [[:alpha:]] shorthand in it but apparently it doesn't like that
            bool readyToApply = true;
            erpEdgeworkValidator.Clear();
            int numBatteries = decimal.ToInt32(nudBatteries.Value);
            int numHolders = decimal.ToInt32(nudHolders.Value);
            String litList = txtLitIndicators.Text;
            String unlitList = txtUnlitIndicators.Text;
            String portList = txtPorts.Text;
            String serialNum = txtSerial.Text;
            //First, the batteries. There must be the correct ratio of batteries to holders:
            //Each holder must have exactly 1 or 2 batteries in it. (D or AA)
            if (((numBatteries == 0) ^ (numHolders == 0)) || (numBatteries < numHolders))
            {
                readyToApply = false;
                erpEdgeworkValidator.SetError(nudBatteries, "All batteries must have holders, and all holders must have batteries");
            }
            else if (numBatteries > (numHolders * 2))
            {
                readyToApply = false;
                erpEdgeworkValidator.SetError(nudBatteries, "There must not be more than 2 batteries per holder.");
            }
            if (!VALID_SERIAL_REGEX.IsMatch(serialNum))
            {
                readyToApply = false;
                erpEdgeworkValidator.SetError(txtSerial, "Invalid serial number. Must be in the form XXNLLN, where X is alphanumeric, N is a number, and L is a letter.");
            }
            if(readyToApply)
            {
                edgework = new Edgework(numBatteries, numHolders, litList, unlitList, portList, serialNum);
                lblCurrentEdges.Text = "Current Edgework: " + edgework.ToString();
                edgeworkReady = true;
            }
            else
            {
                edgeworkReady = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLitIndicators.ResetText();
            txtUnlitIndicators.ResetText();
            txtSerial.ResetText();
            txtPorts.ResetText();
            nudBatteries.Value = 0;
            nudHolders.Value = 0;
            lblCurrentEdges.Text = "Current Edgework: Not yet applied";
            edgeworkReady = false;
        }

        private void btnComplexWires_Click(object sender, EventArgs e)
        {
            if (edgeworkReady)
            {
                Form complexWires = new frmComplexWires(edgework);
                complexWires.Show();
            }
            else
            {
                Form complexWires = new frmComplexWires();
                complexWires.Show();
            }
        }

        private void btnRunTheButton_Click(object sender, EventArgs e)
        {
            if (edgeworkReady)
            {
                Form theButton = new frmTheButton(edgework);
                theButton.Show();
            }
            else
            {
                Form theButton = new frmTheButton();
                theButton.Show();
            }
        }
    }
}
