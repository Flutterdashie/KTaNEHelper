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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nudBatteries = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chartButtonVisual)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatteries)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.cboButtonColor.Location = new System.Drawing.Point(179, 3);
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
            this.cboButtonText.Location = new System.Drawing.Point(179, 67);
            this.cboButtonText.Name = "cboButtonText";
            this.cboButtonText.Size = new System.Drawing.Size(121, 21);
            this.cboButtonText.TabIndex = 1;
            this.cboButtonText.SelectedValueChanged += new System.EventHandler(this.anythingChanged);
            // 
            // linkOptimizedButton
            // 
            this.linkOptimizedButton.AutoSize = true;
            this.linkOptimizedButton.Location = new System.Drawing.Point(3, 29);
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
            this.linkManual.Location = new System.Drawing.Point(3, 0);
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
            this.chartButtonVisual.Location = new System.Drawing.Point(370, 12);
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
            this.chartButtonVisual.Size = new System.Drawing.Size(191, 193);
            this.chartButtonVisual.TabIndex = 4;
            title1.DockedToChartArea = "ChartArea1";
            title1.DockingOffset = 40;
            title1.Name = "Title1";
            title1.Text = "Not yet set";
            this.chartButtonVisual.Titles.Add(title1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboButtonColor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboButtonText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 193);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // nudBatteries
            // 
            this.nudBatteries.Location = new System.Drawing.Point(88, 3);
            this.nudBatteries.Name = "nudBatteries";
            this.nudBatteries.Size = new System.Drawing.Size(40, 20);
            this.nudBatteries.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.nudBatteries, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(170, 58);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.linkManual, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.linkOptimizedButton, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(179, 131);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(170, 59);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // frmTheButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartButtonVisual);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmTheButton";
            this.Text = "The Button";
            ((System.ComponentModel.ISupportInitialize)(this.chartButtonVisual)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBatteries)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboButtonColor;
        private System.Windows.Forms.ComboBox cboButtonText;
        private System.Windows.Forms.LinkLabel linkOptimizedButton;
        private System.Windows.Forms.LinkLabel linkManual;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartButtonVisual;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown nudBatteries;
    }
}