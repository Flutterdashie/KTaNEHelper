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
            this.components = new System.ComponentModel.Container();
            this.btnLaunchWires = new System.Windows.Forms.Button();
            this.grpEdgework = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnParseEdgework = new System.Windows.Forms.Button();
            this.lblPorts = new System.Windows.Forms.Label();
            this.txtPorts = new System.Windows.Forms.TextBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.nudHolders = new System.Windows.Forms.NumericUpDown();
            this.lblHolders = new System.Windows.Forms.Label();
            this.nudBatteries = new System.Windows.Forms.NumericUpDown();
            this.lblBatteries = new System.Windows.Forms.Label();
            this.lblLit = new System.Windows.Forms.Label();
            this.lblUnlit = new System.Windows.Forms.Label();
            this.txtLitIndicators = new System.Windows.Forms.TextBox();
            this.txtUnlitIndicators = new System.Windows.Forms.TextBox();
            this.erpEdgeworkValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCurrentEdges = new System.Windows.Forms.Label();
            this.btnComplexWires = new System.Windows.Forms.Button();
            this.grpEdgework.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatteries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEdgeworkValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLaunchWires
            // 
            this.btnLaunchWires.Location = new System.Drawing.Point(12, 304);
            this.btnLaunchWires.Name = "btnLaunchWires";
            this.btnLaunchWires.Size = new System.Drawing.Size(139, 54);
            this.btnLaunchWires.TabIndex = 1;
            this.btnLaunchWires.Text = "Simple Wires";
            this.btnLaunchWires.UseVisualStyleBackColor = true;
            this.btnLaunchWires.Click += new System.EventHandler(this.btnLaunchWires_Click);
            // 
            // grpEdgework
            // 
            this.grpEdgework.Controls.Add(this.btnReset);
            this.grpEdgework.Controls.Add(this.btnParseEdgework);
            this.grpEdgework.Controls.Add(this.lblPorts);
            this.grpEdgework.Controls.Add(this.txtPorts);
            this.grpEdgework.Controls.Add(this.lblSerial);
            this.grpEdgework.Controls.Add(this.txtSerial);
            this.grpEdgework.Controls.Add(this.nudHolders);
            this.grpEdgework.Controls.Add(this.lblHolders);
            this.grpEdgework.Controls.Add(this.nudBatteries);
            this.grpEdgework.Controls.Add(this.lblBatteries);
            this.grpEdgework.Controls.Add(this.lblLit);
            this.grpEdgework.Controls.Add(this.lblUnlit);
            this.grpEdgework.Controls.Add(this.txtLitIndicators);
            this.grpEdgework.Controls.Add(this.txtUnlitIndicators);
            this.grpEdgework.Location = new System.Drawing.Point(13, 13);
            this.grpEdgework.Name = "grpEdgework";
            this.grpEdgework.Size = new System.Drawing.Size(248, 285);
            this.grpEdgework.TabIndex = 0;
            this.grpEdgework.TabStop = false;
            this.grpEdgework.Text = "Edgework";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(9, 253);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(222, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset Fields";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnParseEdgework
            // 
            this.btnParseEdgework.Location = new System.Drawing.Point(9, 224);
            this.btnParseEdgework.Name = "btnParseEdgework";
            this.btnParseEdgework.Size = new System.Drawing.Size(222, 23);
            this.btnParseEdgework.TabIndex = 12;
            this.btnParseEdgework.Text = "Validate and Apply";
            this.btnParseEdgework.UseVisualStyleBackColor = true;
            this.btnParseEdgework.Click += new System.EventHandler(this.applyEdgework);
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.Location = new System.Drawing.Point(6, 121);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(31, 13);
            this.lblPorts.TabIndex = 8;
            this.lblPorts.Text = "Ports";
            // 
            // txtPorts
            // 
            this.txtPorts.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPorts.Location = new System.Drawing.Point(89, 118);
            this.txtPorts.Multiline = true;
            this.txtPorts.Name = "txtPorts";
            this.txtPorts.Size = new System.Drawing.Size(142, 73);
            this.txtPorts.TabIndex = 9;
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(6, 200);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(73, 13);
            this.lblSerial.TabIndex = 10;
            this.lblSerial.Text = "Serial Number";
            // 
            // txtSerial
            // 
            this.txtSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerial.Location = new System.Drawing.Point(89, 197);
            this.txtSerial.MaxLength = 6;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(142, 20);
            this.txtSerial.TabIndex = 11;
            // 
            // nudHolders
            // 
            this.nudHolders.Location = new System.Drawing.Point(89, 40);
            this.nudHolders.Name = "nudHolders";
            this.nudHolders.Size = new System.Drawing.Size(142, 20);
            this.nudHolders.TabIndex = 3;
            // 
            // lblHolders
            // 
            this.lblHolders.AutoSize = true;
            this.lblHolders.Location = new System.Drawing.Point(6, 42);
            this.lblHolders.Name = "lblHolders";
            this.lblHolders.Size = new System.Drawing.Size(79, 13);
            this.lblHolders.TabIndex = 2;
            this.lblHolders.Text = "Battery Holders";
            // 
            // nudBatteries
            // 
            this.nudBatteries.Location = new System.Drawing.Point(89, 14);
            this.nudBatteries.Name = "nudBatteries";
            this.nudBatteries.Size = new System.Drawing.Size(142, 20);
            this.nudBatteries.TabIndex = 1;
            // 
            // lblBatteries
            // 
            this.lblBatteries.AutoSize = true;
            this.lblBatteries.Location = new System.Drawing.Point(6, 16);
            this.lblBatteries.Name = "lblBatteries";
            this.lblBatteries.Size = new System.Drawing.Size(48, 13);
            this.lblBatteries.TabIndex = 0;
            this.lblBatteries.Text = "Batteries";
            // 
            // lblLit
            // 
            this.lblLit.AutoSize = true;
            this.lblLit.Location = new System.Drawing.Point(6, 95);
            this.lblLit.Name = "lblLit";
            this.lblLit.Size = new System.Drawing.Size(67, 13);
            this.lblLit.TabIndex = 6;
            this.lblLit.Text = "Lit Indicators";
            // 
            // lblUnlit
            // 
            this.lblUnlit.AutoSize = true;
            this.lblUnlit.Location = new System.Drawing.Point(6, 69);
            this.lblUnlit.Name = "lblUnlit";
            this.lblUnlit.Size = new System.Drawing.Size(77, 13);
            this.lblUnlit.TabIndex = 4;
            this.lblUnlit.Text = "Unlit Indicators";
            // 
            // txtLitIndicators
            // 
            this.txtLitIndicators.Location = new System.Drawing.Point(89, 92);
            this.txtLitIndicators.Name = "txtLitIndicators";
            this.txtLitIndicators.Size = new System.Drawing.Size(142, 20);
            this.txtLitIndicators.TabIndex = 7;
            // 
            // txtUnlitIndicators
            // 
            this.txtUnlitIndicators.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnlitIndicators.Location = new System.Drawing.Point(89, 66);
            this.txtUnlitIndicators.Name = "txtUnlitIndicators";
            this.txtUnlitIndicators.Size = new System.Drawing.Size(142, 20);
            this.txtUnlitIndicators.TabIndex = 5;
            // 
            // erpEdgeworkValidator
            // 
            this.erpEdgeworkValidator.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpEdgeworkValidator.ContainerControl = this;
            // 
            // lblCurrentEdges
            // 
            this.lblCurrentEdges.AutoSize = true;
            this.lblCurrentEdges.Location = new System.Drawing.Point(268, 13);
            this.lblCurrentEdges.Name = "lblCurrentEdges";
            this.lblCurrentEdges.Size = new System.Drawing.Size(169, 13);
            this.lblCurrentEdges.TabIndex = 2;
            this.lblCurrentEdges.Text = "Current Edgework: Not yet applied";
            // 
            // btnComplexWires
            // 
            this.btnComplexWires.Location = new System.Drawing.Point(157, 304);
            this.btnComplexWires.Name = "btnComplexWires";
            this.btnComplexWires.Size = new System.Drawing.Size(139, 54);
            this.btnComplexWires.TabIndex = 3;
            this.btnComplexWires.Text = "Complex Wires";
            this.btnComplexWires.UseVisualStyleBackColor = true;
            this.btnComplexWires.Click += new System.EventHandler(this.btnComplexWires_Click);
            // 
            // KTANESolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComplexWires);
            this.Controls.Add(this.lblCurrentEdges);
            this.Controls.Add(this.grpEdgework);
            this.Controls.Add(this.btnLaunchWires);
            this.Name = "KTANESolver";
            this.Text = "KTANE Solver";
            this.grpEdgework.ResumeLayout(false);
            this.grpEdgework.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatteries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEdgeworkValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunchWires;
        private System.Windows.Forms.GroupBox grpEdgework;
        private System.Windows.Forms.TextBox txtUnlitIndicators;
        private System.Windows.Forms.TextBox txtLitIndicators;
        private System.Windows.Forms.Label lblUnlit;
        private System.Windows.Forms.Label lblLit;
        private System.Windows.Forms.Label lblBatteries;
        private System.Windows.Forms.NumericUpDown nudBatteries;
        private System.Windows.Forms.NumericUpDown nudHolders;
        private System.Windows.Forms.Label lblHolders;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label lblPorts;
        private System.Windows.Forms.TextBox txtPorts;
        private System.Windows.Forms.Button btnParseEdgework;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider erpEdgeworkValidator;
        private System.Windows.Forms.Label lblCurrentEdges;
        private System.Windows.Forms.Button btnComplexWires;
    }
}

