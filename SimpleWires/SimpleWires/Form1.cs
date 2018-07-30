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
            updateWireView();
            updateButtonStatus();
        }

        private void updateWireView()
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
        
        private void updateButtonStatus()
        {
            bool addButtonsOn = (wireList.getLength() <= 5);
            bool delButtonOn = (wireList.getLength() >= 1);
            btnAddBlack.Enabled = addButtonsOn;
            btnAddBlue.Enabled = addButtonsOn;
            btnAddRed.Enabled = addButtonsOn;
            btnAddYellow.Enabled = addButtonsOn;
            btnAddWhite.Enabled = addButtonsOn;

            btnDeleteWire.Enabled = delButtonOn;
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
    }
}
