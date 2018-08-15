namespace KTANESolver
{
    partial class frmTheButton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "1,0");
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.cboButtonColor = new System.Windows.Forms.ComboBox();
            this.cboButtonText = new System.Windows.Forms.ComboBox();
            this.linkOptimizedButton = new System.Windows.Forms.LinkLabel();
            this.linkManual = new System.Windows.Forms.LinkLabel();
            this.chartButtonVisual = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nudBatteries = new System.Windows.Forms.NumericUpDown();
            this.chkLitCAR = new System.Windows.Forms.CheckBox();
            this.chkLitFRK = new System.Windows.Forms.CheckBox();
            this.lblBatteries = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartButtonVisual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatteries)).BeginInit();
            this.SuspendLayout();
            // 
            // cboButtonColor
            // 
            this.cboButtonColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboButtonColor.FormattingEnabled = true;
            this.cboButtonColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Yellow",
            "White"});
            this.cboButtonColor.Location = new System.Drawing.Point(12, 56);
            this.cboButtonColor.Name = "cboButtonColor";
            this.cboButtonColor.Size = new System.Drawing.Size(121, 21);
            this.cboButtonColor.TabIndex = 0;
            this.cboButtonColor.SelectedValueChanged += new System.EventHandler(this.anythingChanged);
            // 
            // cboButtonText
            // 
            this.cboButtonText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboButtonText.FormattingEnabled = true;
            this.cboButtonText.Items.AddRange(new object[] {
            "PRESS",
            "HOLD",
            "ABORT",
            "DETONATE"});
            this.cboButtonText.Location = new System.Drawing.Point(12, 83);
            this.cboButtonText.Name = "cboButtonText";
            this.cboButtonText.Size = new System.Drawing.Size(121, 21);
            this.cboButtonText.TabIndex = 1;
            this.cboButtonText.SelectedValueChanged += new System.EventHandler(this.anythingChanged);
            // 
            // linkOptimizedButton
            // 
            this.linkOptimizedButton.AutoSize = true;
            this.linkOptimizedButton.Location = new System.Drawing.Point(12, 120);
            this.linkOptimizedButton.Name = "linkOptimizedButton";
            this.linkOptimizedButton.Size = new System.Drawing.Size(91, 13);
            this.linkOptimizedButton.TabIndex = 2;
            this.linkOptimizedButton.TabStop = true;
            this.linkOptimizedButton.Text = "Optimized Manual";
            this.linkOptimizedButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOptimizedButton_LinkClicked);
            // 
            // linkManual
            // 
            this.linkManual.AutoSize = true;
            this.linkManual.Location = new System.Drawing.Point(12, 107);
            this.linkManual.Name = "linkManual";
            this.linkManual.Size = new System.Drawing.Size(77, 13);
            this.linkManual.TabIndex = 3;
            this.linkManual.TabStop = true;
            this.linkManual.Text = "Official Manual";
            this.linkManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkManual_LinkClicked);
            // 
            // chartButtonVisual
            // 
            this.chartButtonVisual.BackColor = System.Drawing.SystemColors.Control;
            this.chartButtonVisual.BorderlineColor = System.Drawing.Color.Empty;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartButtonVisual.ChartAreas.Add(chartArea1);
            this.chartButtonVisual.Location = new System.Drawing.Point(147, 7);
            this.chartButtonVisual.Name = "chartButtonVisual";
            this.chartButtonVisual.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No;
            series1.YValuesPerPoint = 2;
            this.chartButtonVisual.Series.Add(series1);
            this.chartButtonVisual.Size = new System.Drawing.Size(191, 191);
            this.chartButtonVisual.TabIndex = 4;
            title1.DockedToChartArea = "ChartArea1";
            title1.DockingOffset = 40;
            title1.Name = "Title1";
            title1.Text = "Not yet set";
            this.chartButtonVisual.Titles.Add(title1);
            // 
            // nudBatteries
            // 
            this.nudBatteries.Location = new System.Drawing.Point(80, 9);
            this.nudBatteries.Name = "nudBatteries";
            this.nudBatteries.Size = new System.Drawing.Size(40, 20);
            this.nudBatteries.TabIndex = 4;
            // 
            // chkLitCAR
            // 
            this.chkLitCAR.AutoSize = true;
            this.chkLitCAR.Location = new System.Drawing.Point(12, 35);
            this.chkLitCAR.Name = "chkLitCAR";
            this.chkLitCAR.Size = new System.Drawing.Size(62, 17);
            this.chkLitCAR.TabIndex = 5;
            this.chkLitCAR.Text = "Lit CAR";
            this.chkLitCAR.UseVisualStyleBackColor = true;
            // 
            // chkLitFRK
            // 
            this.chkLitFRK.AutoSize = true;
            this.chkLitFRK.Location = new System.Drawing.Point(80, 35);
            this.chkLitFRK.Name = "chkLitFRK";
            this.chkLitFRK.Size = new System.Drawing.Size(61, 17);
            this.chkLitFRK.TabIndex = 6;
            this.chkLitFRK.Text = "Lit FRK";
            this.chkLitFRK.UseVisualStyleBackColor = true;
            // 
            // lblBatteries
            // 
            this.lblBatteries.AutoSize = true;
            this.lblBatteries.Location = new System.Drawing.Point(12, 11);
            this.lblBatteries.Name = "lblBatteries";
            this.lblBatteries.Size = new System.Drawing.Size(51, 13);
            this.lblBatteries.TabIndex = 7;
            this.lblBatteries.Text = "Batteries:";
            this.lblBatteries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTheButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(369, 229);
            this.Controls.Add(this.chartButtonVisual);
            this.Controls.Add(this.cboButtonText);
            this.Controls.Add(this.chkLitFRK);
            this.Controls.Add(this.linkOptimizedButton);
            this.Controls.Add(this.chkLitCAR);
            this.Controls.Add(this.nudBatteries);
            this.Controls.Add(this.lblBatteries);
            this.Controls.Add(this.cboButtonColor);
            this.Controls.Add(this.linkManual);
            this.Name = "frmTheButton";
            this.Text = "The Button";
            ((System.ComponentModel.ISupportInitialize)(this.chartButtonVisual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatteries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboButtonColor;
        private System.Windows.Forms.ComboBox cboButtonText;
        private System.Windows.Forms.LinkLabel linkOptimizedButton;
        private System.Windows.Forms.LinkLabel linkManual;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartButtonVisual;
        private System.Windows.Forms.NumericUpDown nudBatteries;
        private System.Windows.Forms.CheckBox chkLitCAR;
        private System.Windows.Forms.CheckBox chkLitFRK;
        private System.Windows.Forms.Label lblBatteries;
    }
}