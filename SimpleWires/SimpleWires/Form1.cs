using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWires
{
    public partial class Form1 : Form
    {
        private WireList wireList;
        public Form1()
        {
            InitializeComponent();
            wireList = new WireList();
        }
        public void updateWireView()
        {
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

    }

    
    }
}
