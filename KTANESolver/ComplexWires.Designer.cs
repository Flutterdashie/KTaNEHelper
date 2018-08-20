namespace KTANESolver
{
    partial class frmComplexWires
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
            this.grpWireData = new System.Windows.Forms.GroupBox();
            this.chkStar = new System.Windows.Forms.CheckBox();
            this.chkLED = new System.Windows.Forms.CheckBox();
            this.chkBlue = new System.Windows.Forms.CheckBox();
            this.chkRed = new System.Windows.Forms.CheckBox();
            this.btnClearWireInput = new System.Windows.Forms.Button();
            this.btnSubmitWire = new System.Windows.Forms.Button();
            this.grpEdgeworkInfo = new System.Windows.Forms.GroupBox();
            this.btnResetEdgework = new System.Windows.Forms.Button();
            this.btnLockToggle = new System.Windows.Forms.Button();
            this.clbEdgeworkData = new System.Windows.Forms.CheckedListBox();
            this.lblCutOutput = new System.Windows.Forms.Label();
            this.dgvWires = new System.Windows.Forms.DataGridView();
            this.lblTableInfo = new System.Windows.Forms.Label();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.grpWireData.SuspendLayout();
            this.grpEdgeworkInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWires)).BeginInit();
            this.SuspendLayout();
            // 
            // grpWireData
            // 
            this.grpWireData.Controls.Add(this.chkStar);
            this.grpWireData.Controls.Add(this.chkLED);
            this.grpWireData.Controls.Add(this.chkBlue);
            this.grpWireData.Controls.Add(this.chkRed);
            this.grpWireData.Controls.Add(this.btnClearWireInput);
            this.grpWireData.Controls.Add(this.btnSubmitWire);
            this.grpWireData.Location = new System.Drawing.Point(12, 12);
            this.grpWireData.Name = "grpWireData";
            this.grpWireData.Size = new System.Drawing.Size(120, 132);
            this.grpWireData.TabIndex = 1;
            this.grpWireData.TabStop = false;
            this.grpWireData.Text = "Wire Information";
            // 
            // chkStar
            // 
            this.chkStar.AutoSize = true;
            this.chkStar.Location = new System.Drawing.Point(6, 64);
            this.chkStar.Name = "chkStar";
            this.chkStar.Size = new System.Drawing.Size(45, 17);
            this.chkStar.TabIndex = 6;
            this.chkStar.Text = "Star";
            this.chkStar.UseVisualStyleBackColor = true;
            this.chkStar.CheckedChanged += new System.EventHandler(this.calculateWire);
            // 
            // chkLED
            // 
            this.chkLED.AutoSize = true;
            this.chkLED.Location = new System.Drawing.Point(6, 47);
            this.chkLED.Name = "chkLED";
            this.chkLED.Size = new System.Drawing.Size(47, 17);
            this.chkLED.TabIndex = 5;
            this.chkLED.Text = "LED";
            this.chkLED.UseVisualStyleBackColor = true;
            this.chkLED.CheckedChanged += new System.EventHandler(this.calculateWire);
            // 
            // chkBlue
            // 
            this.chkBlue.AutoSize = true;
            this.chkBlue.Location = new System.Drawing.Point(6, 30);
            this.chkBlue.Name = "chkBlue";
            this.chkBlue.Size = new System.Drawing.Size(47, 17);
            this.chkBlue.TabIndex = 4;
            this.chkBlue.Text = "Blue";
            this.chkBlue.UseVisualStyleBackColor = true;
            this.chkBlue.CheckedChanged += new System.EventHandler(this.calculateWire);
            // 
            // chkRed
            // 
            this.chkRed.AutoSize = true;
            this.chkRed.Location = new System.Drawing.Point(6, 13);
            this.chkRed.Name = "chkRed";
            this.chkRed.Size = new System.Drawing.Size(46, 17);
            this.chkRed.TabIndex = 3;
            this.chkRed.Text = "Red";
            this.chkRed.UseVisualStyleBackColor = true;
            this.chkRed.CheckedChanged += new System.EventHandler(this.calculateWire);
            // 
            // btnClearWireInput
            // 
            this.btnClearWireInput.Location = new System.Drawing.Point(63, 19);
            this.btnClearWireInput.Name = "btnClearWireInput";
            this.btnClearWireInput.Size = new System.Drawing.Size(51, 64);
            this.btnClearWireInput.TabIndex = 2;
            this.btnClearWireInput.Text = "&Clear";
            this.btnClearWireInput.UseVisualStyleBackColor = true;
            this.btnClearWireInput.Click += new System.EventHandler(this.btnClearWireInput_Click);
            // 
            // btnSubmitWire
            // 
            this.btnSubmitWire.Location = new System.Drawing.Point(6, 89);
            this.btnSubmitWire.Name = "btnSubmitWire";
            this.btnSubmitWire.Size = new System.Drawing.Size(108, 37);
            this.btnSubmitWire.TabIndex = 1;
            this.btnSubmitWire.Text = "Log to Table";
            this.btnSubmitWire.UseVisualStyleBackColor = true;
            this.btnSubmitWire.Click += new System.EventHandler(this.logToTable);
            // 
            // grpEdgeworkInfo
            // 
            this.grpEdgeworkInfo.Controls.Add(this.btnResetEdgework);
            this.grpEdgeworkInfo.Controls.Add(this.btnLockToggle);
            this.grpEdgeworkInfo.Controls.Add(this.clbEdgeworkData);
            this.grpEdgeworkInfo.Location = new System.Drawing.Point(139, 13);
            this.grpEdgeworkInfo.Name = "grpEdgeworkInfo";
            this.grpEdgeworkInfo.Size = new System.Drawing.Size(138, 131);
            this.grpEdgeworkInfo.TabIndex = 2;
            this.grpEdgeworkInfo.TabStop = false;
            this.grpEdgeworkInfo.Text = "Bomb Information";
            // 
            // btnResetEdgework
            // 
            this.btnResetEdgework.Location = new System.Drawing.Point(73, 74);
            this.btnResetEdgework.Name = "btnResetEdgework";
            this.btnResetEdgework.Size = new System.Drawing.Size(59, 51);
            this.btnResetEdgework.TabIndex = 2;
            this.btnResetEdgework.Text = "Clear";
            this.btnResetEdgework.UseVisualStyleBackColor = true;
            this.btnResetEdgework.Click += new System.EventHandler(this.btnResetEdgework_Click);
            // 
            // btnLockToggle
            // 
            this.btnLockToggle.Location = new System.Drawing.Point(7, 74);
            this.btnLockToggle.Name = "btnLockToggle";
            this.btnLockToggle.Size = new System.Drawing.Size(59, 51);
            this.btnLockToggle.TabIndex = 1;
            this.btnLockToggle.Text = "Toggle\r\nLock";
            this.btnLockToggle.UseVisualStyleBackColor = true;
            this.btnLockToggle.Click += new System.EventHandler(this.toggleEdgeworkLock);
            // 
            // clbEdgeworkData
            // 
            this.clbEdgeworkData.CheckOnClick = true;
            this.clbEdgeworkData.FormattingEnabled = true;
            this.clbEdgeworkData.Items.AddRange(new object[] {
            "Even Serial No.",
            "Batteries >=2",
            "Parallel Port"});
            this.clbEdgeworkData.Location = new System.Drawing.Point(7, 18);
            this.clbEdgeworkData.Name = "clbEdgeworkData";
            this.clbEdgeworkData.Size = new System.Drawing.Size(125, 49);
            this.clbEdgeworkData.TabIndex = 0;
            this.clbEdgeworkData.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.fireUpdateAFTERCheck);
            // 
            // lblCutOutput
            // 
            this.lblCutOutput.AutoSize = true;
            this.lblCutOutput.Location = new System.Drawing.Point(12, 151);
            this.lblCutOutput.MaximumSize = new System.Drawing.Size(260, 0);
            this.lblCutOutput.Name = "lblCutOutput";
            this.lblCutOutput.Size = new System.Drawing.Size(96, 13);
            this.lblCutOutput.TabIndex = 3;
            this.lblCutOutput.Text = "Not yet calculated.";
            // 
            // dgvWires
            // 
            this.dgvWires.AllowUserToAddRows = false;
            this.dgvWires.AllowUserToOrderColumns = true;
            this.dgvWires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvWires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWires.Location = new System.Drawing.Point(12, 209);
            this.dgvWires.Name = "dgvWires";
            this.dgvWires.ReadOnly = true;
            this.dgvWires.Size = new System.Drawing.Size(265, 161);
            this.dgvWires.TabIndex = 4;
            // 
            // lblTableInfo
            // 
            this.lblTableInfo.AutoSize = true;
            this.lblTableInfo.Location = new System.Drawing.Point(12, 190);
            this.lblTableInfo.Name = "lblTableInfo";
            this.lblTableInfo.Size = new System.Drawing.Size(174, 13);
            this.lblTableInfo.TabIndex = 5;
            this.lblTableInfo.Text = "Note: Rows are manually deletable.";
            // 
            // btnClearTable
            // 
            this.btnClearTable.Location = new System.Drawing.Point(202, 185);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(75, 23);
            this.btnClearTable.TabIndex = 6;
            this.btnClearTable.Text = "Clear Table";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // frmComplexWires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(311, 371);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.lblTableInfo);
            this.Controls.Add(this.dgvWires);
            this.Controls.Add(this.lblCutOutput);
            this.Controls.Add(this.grpEdgeworkInfo);
            this.Controls.Add(this.grpWireData);
            this.MaximizeBox = false;
            this.Name = "frmComplexWires";
            this.Text = "Complex Wires";
            this.grpWireData.ResumeLayout(false);
            this.grpWireData.PerformLayout();
            this.grpEdgeworkInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWires)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpWireData;
        private System.Windows.Forms.Button btnClearWireInput;
        private System.Windows.Forms.Button btnSubmitWire;
        private System.Windows.Forms.GroupBox grpEdgeworkInfo;
        private System.Windows.Forms.CheckedListBox clbEdgeworkData;
        private System.Windows.Forms.Button btnLockToggle;
        private System.Windows.Forms.Button btnResetEdgework;
        private System.Windows.Forms.Label lblCutOutput;
        private System.Windows.Forms.CheckBox chkRed;
        private System.Windows.Forms.CheckBox chkStar;
        private System.Windows.Forms.CheckBox chkLED;
        private System.Windows.Forms.CheckBox chkBlue;
        private System.Windows.Forms.DataGridView dgvWires;
        private System.Windows.Forms.Label lblTableInfo;
        private System.Windows.Forms.Button btnClearTable;
    }
}