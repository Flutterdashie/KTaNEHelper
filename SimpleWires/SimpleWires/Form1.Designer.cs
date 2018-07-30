namespace SimpleWires
{
    partial class Form1
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
            this.tlpWireControls.SuspendLayout();
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
            // 
            // btnAddBlue
            // 
            this.btnAddBlue.Location = new System.Drawing.Point(102, 3);
            this.btnAddBlue.Name = "btnAddBlue";
            this.btnAddBlue.Size = new System.Drawing.Size(92, 37);
            this.btnAddBlue.TabIndex = 1;
            this.btnAddBlue.Text = "Add Blue";
            this.btnAddBlue.UseVisualStyleBackColor = true;
            // 
            // btnAddBlack
            // 
            this.btnAddBlack.Location = new System.Drawing.Point(3, 46);
            this.btnAddBlack.Name = "btnAddBlack";
            this.btnAddBlack.Size = new System.Drawing.Size(92, 37);
            this.btnAddBlack.TabIndex = 2;
            this.btnAddBlack.Text = "Add Black";
            this.btnAddBlack.UseVisualStyleBackColor = true;
            // 
            // btnAddYellow
            // 
            this.btnAddYellow.Location = new System.Drawing.Point(102, 46);
            this.btnAddYellow.Name = "btnAddYellow";
            this.btnAddYellow.Size = new System.Drawing.Size(92, 37);
            this.btnAddYellow.TabIndex = 3;
            this.btnAddYellow.Text = "Add Yellow";
            this.btnAddYellow.UseVisualStyleBackColor = true;
            // 
            // btnAddWhite
            // 
            this.btnAddWhite.Location = new System.Drawing.Point(3, 89);
            this.btnAddWhite.Name = "btnAddWhite";
            this.btnAddWhite.Size = new System.Drawing.Size(92, 38);
            this.btnAddWhite.TabIndex = 4;
            this.btnAddWhite.Text = "Add White";
            this.btnAddWhite.UseVisualStyleBackColor = true;
            // 
            // btnDeleteWire
            // 
            this.btnDeleteWire.Location = new System.Drawing.Point(102, 89);
            this.btnDeleteWire.Name = "btnDeleteWire";
            this.btnDeleteWire.Size = new System.Drawing.Size(92, 38);
            this.btnDeleteWire.TabIndex = 5;
            this.btnDeleteWire.Text = "Remove Wire";
            this.btnDeleteWire.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpWireControls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tlpWireControls.ResumeLayout(false);
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
    }
}

