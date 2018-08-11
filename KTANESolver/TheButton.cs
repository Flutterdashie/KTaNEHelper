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

namespace KTANESolver
{
    public partial class frmTheButton : Form
    {
        public frmTheButton()
        {
            InitializeComponent();
            cboButtonText.SelectedIndex = 0;
            cboButtonColor.SelectedIndex = 0;
        }

        private void updateChart()
        {
            Color buttonColor;
            switch (cboButtonColor.SelectedIndex)
            {
                case 0:
                    buttonColor = Color.Red;
                    break;
                case 1:
                    buttonColor = Color.DeepSkyBlue;
                    break;
                case 2:
                    buttonColor = Color.Yellow;
                    break;
                case 3:
                    buttonColor = Color.White;
                    break;
                default:
                    buttonColor = Color.HotPink;
                    break;
            }
            chartButtonVisual.Series[0].Points[0].Color = buttonColor;
            chartButtonVisual.Titles[0].Text = cboButtonText.Text;
        }

        private void anythingChanged(object sender, EventArgs e)
        {
            updateChart();
        }
        
        private void spawnWebPage(String url)
        {
            //thanks again, stackoverflow! https://stackoverflow.com/questions/58024/open-a-url-from-windows-forms
            ProcessStartInfo sendToSite = new ProcessStartInfo(url);
            Process.Start(sendToSite);

        }

        //So the auto-generator made the => for me, at this point I'm still trying to wrap my head around it.
        private void linkManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => spawnWebPage("http://www.bombmanual.com/manual/1/html/index.html");

        private void linkOptimizedButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => spawnWebPage("https://ktane.timwi.de/HTML/The%20Button%20lookup%20table%20(Timwi).html");
    }
}
