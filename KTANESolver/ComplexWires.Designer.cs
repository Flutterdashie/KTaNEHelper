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
            this.clbWireProperties = new System.Windows.Forms.CheckedListBox();
            this.grpWireData = new System.Windows.Forms.GroupBox();
            this.btnSubmitWire = new System.Windows.Forms.Button();
            this.btnClearWireInput = new System.Windows.Forms.Button();
            this.grpEdgeworkInfo = new System.Windows.Forms.GroupBox();
            this.clbEdgeworkData = new System.Windows.Forms.CheckedListBox();
            this.btnLockToggle = new System.Windows.Forms.Button();
            this.btnResetEdgework = new System.Windows.Forms.Button();
            this.grpWireData.SuspendLayout();
            this.grpEdgeworkInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbWireProperties
            // 
            this.clbWireProperties.FormattingEnabled = true;
            this.clbWireProperties.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "LED",
            "Star"});
            this.clbWireProperties.Location = new System.Drawing.Point(6, 19);
            this.clbWireProperties.Name = "clbWireProperties";
            this.clbWireProperties.Size = new System.Drawing.Size(50, 64);
            this.clbWireProperties.TabIndex = 0;
            // 
            // grpWireData
            // 
            this.grpWireData.Controls.Add(this.btnClearWireInput);
            this.grpWireData.Controls.Add(this.btnSubmitWire);
            this.grpWireData.Controls.Add(this.clbWireProperties);
            this.grpWireData.Location = new System.Drawing.Point(12, 12);
            this.grpWireData.Name = "grpWireData";
            this.grpWireData.Size = new System.Drawing.Size(120, 132);
            this.grpWireData.TabIndex = 1;
            this.grpWireData.TabStop = false;
            this.grpWireData.Text = "Wire Information";
            // 
            // btnSubmitWire
            // 
            this.btnSubmitWire.Location = new System.Drawing.Point(6, 89);
            this.btnSubmitWire.Name = "btnSubmitWire";
            this.btnSubmitWire.Size = new System.Drawing.Size(108, 37);
            this.btnSubmitWire.TabIndex = 1;
            this.btnSubmitWire.Text = "Submit";
            this.btnSubmitWire.UseVisualStyleBackColor = true;
            this.btnSubmitWire.Click += new System.EventHandler(this.calculateWire);
            // 
            // btnClearWireInput
            // 
            this.btnClearWireInput.Location = new System.Drawing.Point(63, 19);
            this.btnClearWireInput.Name = "btnClearWireInput";
            this.btnClearWireInput.Size = new System.Drawing.Size(51, 64);
            this.btnClearWireInput.TabIndex = 2;
            this.btnClearWireInput.Text = "Clear";
            this.btnClearWireInput.UseVisualStyleBackColor = true;
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
            // clbEdgeworkData
            // 
            this.clbEdgeworkData.FormattingEnabled = true;
            this.clbEdgeworkData.Items.AddRange(new object[] {
            "Even Serial No.",
            "Batteries >=2",
            "Parallel Port"});
            this.clbEdgeworkData.Location = new System.Drawing.Point(7, 18);
            this.clbEdgeworkData.Name = "clbEdgeworkData";
            this.clbEdgeworkData.Size = new System.Drawing.Size(125, 49);
            this.clbEdgeworkData.TabIndex = 0;
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
            // btnResetEdgework
            // 
            this.btnResetEdgework.Location = new System.Drawing.Point(73, 74);
            this.btnResetEdgework.Name = "btnResetEdgework";
            this.btnResetEdgework.Size = new System.Drawing.Size(59, 51);
            this.btnResetEdgework.TabIndex = 2;
            this.btnResetEdgework.Text = "Clear";
            this.btnResetEdgework.UseVisualStyleBackColor = true;
            // 
            // frmComplexWires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpEdgeworkInfo);
            this.Controls.Add(this.grpWireData);
            this.Name = "frmComplexWires";
            this.Text = "Complex Wires";
            this.grpWireData.ResumeLayout(false);
            this.grpEdgeworkInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbWireProperties;
        private System.Windows.Forms.GroupBox grpWireData;
        private System.Windows.Forms.Button btnClearWireInput;
        private System.Windows.Forms.Button btnSubmitWire;
        private System.Windows.Forms.GroupBox grpEdgeworkInfo;
        private System.Windows.Forms.CheckedListBox clbEdgeworkData;
        private System.Windows.Forms.Button btnLockToggle;
        private System.Windows.Forms.Button btnResetEdgework;
    }
}