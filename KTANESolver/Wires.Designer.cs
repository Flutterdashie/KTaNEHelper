namespace SimpleWires
{
    partial class frmSimpleWires
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
            this.btnAddRed = new System.Windows.Forms.Button();
            this.btnAddBlue = new System.Windows.Forms.Button();
            this.btnAddBlack = new System.Windows.Forms.Button();
            this.btnAddYellow = new System.Windows.Forms.Button();
            this.btnAddWhite = new System.Windows.Forms.Button();
            this.btnDeleteWire = new System.Windows.Forms.Button();
            this.tlpWireControls = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCurrentWires = new System.Windows.Forms.TableLayoutPanel();
            this.lblWire1 = new System.Windows.Forms.Label();
            this.lblWire2 = new System.Windows.Forms.Label();
            this.lblWire3 = new System.Windows.Forms.Label();
            this.lblWire4 = new System.Windows.Forms.Label();
            this.lblWire5 = new System.Windows.Forms.Label();
            this.lblWire6 = new System.Windows.Forms.Label();
            this.tlpControlsOutput = new System.Windows.Forms.TableLayoutPanel();
            this.linkOptimizedManual = new System.Windows.Forms.LinkLabel();
            this.lblCutNumber = new System.Windows.Forms.Label();
            this.linkNormalManual = new System.Windows.Forms.LinkLabel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkSerialOdd = new System.Windows.Forms.CheckBox();
            this.tlpWireControls.SuspendLayout();
            this.tlpCurrentWires.SuspendLayout();
            this.tlpControlsOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddRed
            // 
            this.btnAddRed.Location = new System.Drawing.Point(3, 3);
            this.btnAddRed.Name = "btnAddRed";
            this.btnAddRed.Size = new System.Drawing.Size(92, 37);
            this.btnAddRed.TabIndex = 0;
            this.btnAddRed.Text = "Add Red";
            this.btnAddRed.UseVisualStyleBackColor = true;
            this.btnAddRed.Click += new System.EventHandler(this.btnAddRed_Click);
            // 
            // btnAddBlue
            // 
            this.btnAddBlue.Location = new System.Drawing.Point(102, 3);
            this.btnAddBlue.Name = "btnAddBlue";
            this.btnAddBlue.Size = new System.Drawing.Size(92, 37);
            this.btnAddBlue.TabIndex = 1;
            this.btnAddBlue.Text = "Add Blue";
            this.btnAddBlue.UseVisualStyleBackColor = true;
            this.btnAddBlue.Click += new System.EventHandler(this.btnAddBlue_Click);
            // 
            // btnAddBlack
            // 
            this.btnAddBlack.Location = new System.Drawing.Point(3, 46);
            this.btnAddBlack.Name = "btnAddBlack";
            this.btnAddBlack.Size = new System.Drawing.Size(92, 37);
            this.btnAddBlack.TabIndex = 2;
            this.btnAddBlack.Text = "Add Black";
            this.btnAddBlack.UseVisualStyleBackColor = true;
            this.btnAddBlack.Click += new System.EventHandler(this.btnAddBlack_Click);
            // 
            // btnAddYellow
            // 
            this.btnAddYellow.Location = new System.Drawing.Point(102, 46);
            this.btnAddYellow.Name = "btnAddYellow";
            this.btnAddYellow.Size = new System.Drawing.Size(92, 37);
            this.btnAddYellow.TabIndex = 3;
            this.btnAddYellow.Text = "Add Yellow";
            this.btnAddYellow.UseVisualStyleBackColor = true;
            this.btnAddYellow.Click += new System.EventHandler(this.btnAddYellow_Click);
            // 
            // btnAddWhite
            // 
            this.btnAddWhite.Location = new System.Drawing.Point(3, 89);
            this.btnAddWhite.Name = "btnAddWhite";
            this.btnAddWhite.Size = new System.Drawing.Size(92, 38);
            this.btnAddWhite.TabIndex = 4;
            this.btnAddWhite.Text = "Add White";
            this.btnAddWhite.UseVisualStyleBackColor = true;
            this.btnAddWhite.Click += new System.EventHandler(this.btnAddWhite_Click);
            // 
            // btnDeleteWire
            // 
            this.btnDeleteWire.Location = new System.Drawing.Point(102, 89);
            this.btnDeleteWire.Name = "btnDeleteWire";
            this.btnDeleteWire.Size = new System.Drawing.Size(92, 38);
            this.btnDeleteWire.TabIndex = 5;
            this.btnDeleteWire.Text = "Remove Wire";
            this.btnDeleteWire.UseVisualStyleBackColor = true;
            this.btnDeleteWire.Click += new System.EventHandler(this.removeWire);
            // 
            // tlpWireControls
            // 
            this.tlpWireControls.ColumnCount = 2;
            this.tlpWireControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWireControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWireControls.Controls.Add(this.btnAddRed, 0, 0);
            this.tlpWireControls.Controls.Add(this.btnDeleteWire, 1, 2);
            this.tlpWireControls.Controls.Add(this.btnAddBlue, 1, 0);
            this.tlpWireControls.Controls.Add(this.btnAddWhite, 0, 2);
            this.tlpWireControls.Controls.Add(this.btnAddBlack, 0, 1);
            this.tlpWireControls.Controls.Add(this.btnAddYellow, 1, 1);
            this.tlpWireControls.Location = new System.Drawing.Point(13, 13);
            this.tlpWireControls.Name = "tlpWireControls";
            this.tlpWireControls.RowCount = 3;
            this.tlpWireControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpWireControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpWireControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpWireControls.Size = new System.Drawing.Size(199, 131);
            this.tlpWireControls.TabIndex = 6;
            // 
            // tlpCurrentWires
            // 
            this.tlpCurrentWires.ColumnCount = 1;
            this.tlpCurrentWires.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCurrentWires.Controls.Add(this.lblWire1, 0, 0);
            this.tlpCurrentWires.Controls.Add(this.lblWire2, 0, 1);
            this.tlpCurrentWires.Controls.Add(this.lblWire3, 0, 2);
            this.tlpCurrentWires.Controls.Add(this.lblWire4, 0, 3);
            this.tlpCurrentWires.Controls.Add(this.lblWire5, 0, 4);
            this.tlpCurrentWires.Controls.Add(this.lblWire6, 0, 5);
            this.tlpCurrentWires.Location = new System.Drawing.Point(219, 13);
            this.tlpCurrentWires.Name = "tlpCurrentWires";
            this.tlpCurrentWires.RowCount = 6;
            this.tlpCurrentWires.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCurrentWires.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCurrentWires.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCurrentWires.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCurrentWires.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCurrentWires.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCurrentWires.Size = new System.Drawing.Size(200, 131);
            this.tlpCurrentWires.TabIndex = 7;
            // 
            // lblWire1
            // 
            this.lblWire1.AutoSize = true;
            this.lblWire1.Location = new System.Drawing.Point(3, 0);
            this.lblWire1.Name = "lblWire1";
            this.lblWire1.Size = new System.Drawing.Size(193, 23);
            this.lblWire1.TabIndex = 0;
            this.lblWire1.Text = "----------------------------------------------------------------";
            this.lblWire1.Visible = false;
            // 
            // lblWire2
            // 
            this.lblWire2.AutoSize = true;
            this.lblWire2.Location = new System.Drawing.Point(3, 23);
            this.lblWire2.Name = "lblWire2";
            this.lblWire2.Size = new System.Drawing.Size(193, 23);
            this.lblWire2.TabIndex = 1;
            this.lblWire2.Text = "----------------------------------------------------------------";
            this.lblWire2.Visible = false;
            // 
            // lblWire3
            // 
            this.lblWire3.AutoSize = true;
            this.lblWire3.Location = new System.Drawing.Point(3, 46);
            this.lblWire3.Name = "lblWire3";
            this.lblWire3.Size = new System.Drawing.Size(193, 20);
            this.lblWire3.TabIndex = 2;
            this.lblWire3.Text = "----------------------------------------------------------------";
            this.lblWire3.Visible = false;
            // 
            // lblWire4
            // 
            this.lblWire4.AutoSize = true;
            this.lblWire4.Location = new System.Drawing.Point(3, 66);
            this.lblWire4.Name = "lblWire4";
            this.lblWire4.Size = new System.Drawing.Size(193, 20);
            this.lblWire4.TabIndex = 3;
            this.lblWire4.Text = "----------------------------------------------------------------";
            this.lblWire4.Visible = false;
            // 
            // lblWire5
            // 
            this.lblWire5.AutoSize = true;
            this.lblWire5.Location = new System.Drawing.Point(3, 86);
            this.lblWire5.Name = "lblWire5";
            this.lblWire5.Size = new System.Drawing.Size(193, 20);
            this.lblWire5.TabIndex = 4;
            this.lblWire5.Text = "----------------------------------------------------------------";
            this.lblWire5.Visible = false;
            // 
            // lblWire6
            // 
            this.lblWire6.AutoSize = true;
            this.lblWire6.Location = new System.Drawing.Point(3, 106);
            this.lblWire6.Name = "lblWire6";
            this.lblWire6.Size = new System.Drawing.Size(193, 25);
            this.lblWire6.TabIndex = 5;
            this.lblWire6.Text = "----------------------------------------------------------------";
            this.lblWire6.Visible = false;
            // 
            // tlpControlsOutput
            // 
            this.tlpControlsOutput.ColumnCount = 2;
            this.tlpControlsOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControlsOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControlsOutput.Controls.Add(this.linkOptimizedManual, 1, 2);
            this.tlpControlsOutput.Controls.Add(this.lblCutNumber, 0, 0);
            this.tlpControlsOutput.Controls.Add(this.linkNormalManual, 0, 2);
            this.tlpControlsOutput.Controls.Add(this.btnSubmit, 0, 1);
            this.tlpControlsOutput.Controls.Add(this.btnReset, 1, 1);
            this.tlpControlsOutput.Controls.Add(this.chkSerialOdd, 1, 0);
            this.tlpControlsOutput.Location = new System.Drawing.Point(13, 151);
            this.tlpControlsOutput.Name = "tlpControlsOutput";
            this.tlpControlsOutput.RowCount = 3;
            this.tlpControlsOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpControlsOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tlpControlsOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpControlsOutput.Size = new System.Drawing.Size(406, 117);
            this.tlpControlsOutput.TabIndex = 8;
            // 
            // linkOptimizedManual
            // 
            this.linkOptimizedManual.AutoSize = true;
            this.linkOptimizedManual.Location = new System.Drawing.Point(206, 95);
            this.linkOptimizedManual.Name = "linkOptimizedManual";
            this.linkOptimizedManual.Size = new System.Drawing.Size(91, 13);
            this.linkOptimizedManual.TabIndex = 10;
            this.linkOptimizedManual.TabStop = true;
            this.linkOptimizedManual.Text = "Optimized Manual";
            this.linkOptimizedManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.optimizedManualClicked);
            // 
            // lblCutNumber
            // 
            this.lblCutNumber.AutoSize = true;
            this.lblCutNumber.Location = new System.Drawing.Point(3, 0);
            this.lblCutNumber.Name = "lblCutNumber";
            this.lblCutNumber.Size = new System.Drawing.Size(174, 13);
            this.lblCutNumber.TabIndex = 0;
            this.lblCutNumber.Text = "Don\'t cut yet, I\'m not done thinking!";
            // 
            // linkNormalManual
            // 
            this.linkNormalManual.AutoSize = true;
            this.linkNormalManual.Location = new System.Drawing.Point(3, 95);
            this.linkNormalManual.Name = "linkNormalManual";
            this.linkNormalManual.Size = new System.Drawing.Size(78, 13);
            this.linkNormalManual.TabIndex = 9;
            this.linkNormalManual.TabStop = true;
            this.linkNormalManual.Text = "Normal Manual";
            this.linkNormalManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.normalManualClicked);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(3, 41);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(196, 48);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Calculate";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.runCalculations);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(206, 41);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(197, 48);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.resetForm);
            // 
            // chkSerialOdd
            // 
            this.chkSerialOdd.AutoSize = true;
            this.chkSerialOdd.Location = new System.Drawing.Point(206, 3);
            this.chkSerialOdd.Name = "chkSerialOdd";
            this.chkSerialOdd.Size = new System.Drawing.Size(143, 30);
            this.chkSerialOdd.TabIndex = 4;
            this.chkSerialOdd.Text = "The last digit of the serial\r\nnumber is odd";
            this.chkSerialOdd.UseVisualStyleBackColor = true;
            this.chkSerialOdd.CheckedChanged += new System.EventHandler(this.refreshChecked);
            this.chkSerialOdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clickedOnCheckbox);
            // 
            // frmSimpleWires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(433, 276);
            this.Controls.Add(this.tlpControlsOutput);
            this.Controls.Add(this.tlpCurrentWires);
            this.Controls.Add(this.tlpWireControls);
            this.MaximizeBox = false;
            this.Name = "frmSimpleWires";
            this.Text = "Simple Wires Solver";
            this.tlpWireControls.ResumeLayout(false);
            this.tlpCurrentWires.ResumeLayout(false);
            this.tlpCurrentWires.PerformLayout();
            this.tlpControlsOutput.ResumeLayout(false);
            this.tlpControlsOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRed;
        private System.Windows.Forms.Button btnAddBlue;
        private System.Windows.Forms.Button btnAddBlack;
        private System.Windows.Forms.Button btnAddYellow;
        private System.Windows.Forms.Button btnAddWhite;
        private System.Windows.Forms.Button btnDeleteWire;
        private System.Windows.Forms.TableLayoutPanel tlpWireControls;
        private System.Windows.Forms.TableLayoutPanel tlpCurrentWires;
        private System.Windows.Forms.TableLayoutPanel tlpControlsOutput;
        private System.Windows.Forms.Label lblCutNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblWire4;
        private System.Windows.Forms.Label lblWire3;
        private System.Windows.Forms.Label lblWire2;
        private System.Windows.Forms.Label lblWire1;
        private System.Windows.Forms.Label lblWire6;
        private System.Windows.Forms.Label lblWire5;
        private System.Windows.Forms.CheckBox chkSerialOdd;
        private System.Windows.Forms.LinkLabel linkNormalManual;
        private System.Windows.Forms.LinkLabel linkOptimizedManual;
    }
}

