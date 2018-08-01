namespace KTANESolver
{
    partial class KTANESolver
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
            this.btnLaunchWires = new System.Windows.Forms.Button();
            this.grpEdgework = new System.Windows.Forms.GroupBox();
            this.txtUnlitIndicators = new System.Windows.Forms.TextBox();
            this.grpEdgework.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLaunchWires
            // 
            this.btnLaunchWires.Location = new System.Drawing.Point(495, 229);
            this.btnLaunchWires.Name = "btnLaunchWires";
            this.btnLaunchWires.Size = new System.Drawing.Size(139, 54);
            this.btnLaunchWires.TabIndex = 0;
            this.btnLaunchWires.Text = "Simple Wires";
            this.btnLaunchWires.UseVisualStyleBackColor = true;
            this.btnLaunchWires.Click += new System.EventHandler(this.btnLaunchWires_Click);
            // 
            // grpEdgework
            // 
            this.grpEdgework.Controls.Add(this.txtUnlitIndicators);
            this.grpEdgework.Location = new System.Drawing.Point(13, 13);
            this.grpEdgework.Name = "grpEdgework";
            this.grpEdgework.Size = new System.Drawing.Size(342, 135);
            this.grpEdgework.TabIndex = 1;
            this.grpEdgework.TabStop = false;
            this.grpEdgework.Text = "Edgework";
            // 
            // txtUnlitIndicators
            // 
            this.txtUnlitIndicators.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnlitIndicators.Location = new System.Drawing.Point(53, 19);
            this.txtUnlitIndicators.Name = "txtUnlitIndicators";
            this.txtUnlitIndicators.Size = new System.Drawing.Size(100, 20);
            this.txtUnlitIndicators.TabIndex = 0;
            // 
            // KTANESolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpEdgework);
            this.Controls.Add(this.btnLaunchWires);
            this.Name = "KTANESolver";
            this.Text = "KTANE Solver";
            this.grpEdgework.ResumeLayout(false);
            this.grpEdgework.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaunchWires;
        private System.Windows.Forms.GroupBox grpEdgework;
        private System.Windows.Forms.TextBox txtUnlitIndicators;
    }
}

