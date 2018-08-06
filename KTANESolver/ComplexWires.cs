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
    }
}
