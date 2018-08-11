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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, "1,1");
            this.cboButtonColor = new System.Windows.Forms.ComboBox();
            this.cboButtonText = new System.Windows.Forms.ComboBox();
            this.linkOptimizedButton = new System.Windows.Forms.LinkLabel();
            this.linkManual = new System.Windows.Forms.LinkLabel();
            this.chartButtonVisual = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartButtonVisual)).BeginInit();
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
            this.cboButtonColor.Location = new System.Drawing.Point(44, 12);
            this.cboButtonColor.Name = "cboButtonColor";
            this.cboButtonColor.Size = new System.Drawing.Size(121, 21);
            this.cboButtonColor.TabIndex = 0;
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
            this.cboButtonText.Location = new System.Drawing.Point(44, 39);
            this.cboButtonText.Name = "cboButtonText";
            this.cboButtonText.Size = new System.Drawing.Size(121, 21);
            this.cboButtonText.TabIndex = 1;
            // 
            // linkOptimizedButton
            // 
            this.linkOptimizedButton.AutoSize = true;
            this.linkOptimizedButton.Location = new System.Drawing.Point(180, 129);
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
            this.linkManual.Location = new System.Drawing.Point(12, 129);
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
            this.chartButtonVisual.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartButtonVisual.ChartAreas.Add(chartArea1);
            this.chartButtonVisual.Location = new System.Drawing.Point(171, 12);
            this.chartButtonVisual.Name = "chartButtonVisual";
            this.chartButtonVisual.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.YValuesPerPoint = 2;
            this.chartButtonVisual.Series.Add(series1);
            this.chartButtonVisual.Size = new System.Drawing.Size(100, 100);
            this.chartButtonVisual.TabIndex = 4;
            // 
            // frmTheButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartButtonVisual);
            this.Controls.Add(this.linkManual);
            this.Controls.Add(this.linkOptimizedButton);
            this.Controls.Add(this.cboButtonText);
            this.Controls.Add(this.cboButtonColor);
            this.Name = "frmTheButton";
            this.Text = "The Button";
            ((System.ComponentModel.ISupportInitialize)(this.chartButtonVisual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboButtonColor;
        private System.Windows.Forms.ComboBox cboButtonText;
        private System.Windows.Forms.LinkLabel linkOptimizedButton;
        private System.Windows.Forms.LinkLabel linkManual;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartButtonVisual;
    }
}