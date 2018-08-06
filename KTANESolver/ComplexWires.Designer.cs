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
            this.grpWireData.SuspendLayout();
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
            // frmComplexWires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpWireData);
            this.Name = "frmComplexWires";
            this.Text = "Complex Wires";
            this.grpWireData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbWireProperties;
        private System.Windows.Forms.GroupBox grpWireData;
        private System.Windows.Forms.Button btnClearWireInput;
        private System.Windows.Forms.Button btnSubmitWire;
    }
}