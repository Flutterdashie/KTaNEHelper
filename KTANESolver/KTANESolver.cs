using System;
using System.Windows.Forms;

namespace KTANESolver
{
    public partial class KTANESolver : Form
    {
        private Edgework edgework;
        public KTANESolver()
        {
            InitializeComponent();
        }

        private void btnLaunchWires_Click(object sender, EventArgs e)
        {
            Form simpleWires = new SimpleWires.frmSimpleWires();
            simpleWires.Show();
        }

        private void applyEdgework(object sender, EventArgs e)
        {
            //Time for a whole lot of checking!
            //Here's some temporary variables to make it easier to read everything and have fewer calls to controls mid-statement.
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

            if(readyToApply)
            {
                this.edgework = new Edgework(numBatteries, numHolders, litList, unlitList, portList, serialNum);
            }

        }
    }
}
