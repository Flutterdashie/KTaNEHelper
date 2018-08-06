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
        private bool lockState;
        public frmComplexWires()
        {
            InitializeComponent();
            lockState = false;
        }
        public frmComplexWires(Edgework edges)
        {
            InitializeComponent();
            currentBomb = edges;
            lockState = true;

        }

        private void calculateWire(object sender, EventArgs e)
        {

        }

        private void toggleEdgeworkLock(object sender, EventArgs e)
        {

        }
    }
}
