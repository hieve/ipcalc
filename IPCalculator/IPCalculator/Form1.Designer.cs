namespace IPCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IPBox1 = new System.Windows.Forms.TextBox();
            this.IPBox2 = new System.Windows.Forms.TextBox();
            this.IPBox3 = new System.Windows.Forms.TextBox();
            this.IPBox4 = new System.Windows.Forms.TextBox();
            this.SNBox = new System.Windows.Forms.TextBox();
            this.generatebutton = new System.Windows.Forms.Button();
            this.OUTBox = new System.Windows.Forms.TextBox();
            this.ERRBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IPBox1
            // 
            this.IPBox1.Location = new System.Drawing.Point(4, 2);
            this.IPBox1.MaxLength = 3;
            this.IPBox1.Name = "IPBox1";
            this.IPBox1.Size = new System.Drawing.Size(100, 20);
            this.IPBox1.TabIndex = 0;
            this.IPBox1.Text = "127";
            // 
            // IPBox2
            // 
            this.IPBox2.Location = new System.Drawing.Point(110, 3);
            this.IPBox2.MaxLength = 3;
            this.IPBox2.Name = "IPBox2";
            this.IPBox2.Size = new System.Drawing.Size(100, 20);
            this.IPBox2.TabIndex = 1;
            this.IPBox2.Text = "0";
            // 
            // IPBox3
            // 
            this.IPBox3.Location = new System.Drawing.Point(216, 4);
            this.IPBox3.MaxLength = 3;
            this.IPBox3.Name = "IPBox3";
            this.IPBox3.Size = new System.Drawing.Size(100, 20);
            this.IPBox3.TabIndex = 2;
            this.IPBox3.Text = "0";
            // 
            // IPBox4
            // 
            this.IPBox4.Location = new System.Drawing.Point(322, 4);
            this.IPBox4.MaxLength = 3;
            this.IPBox4.Name = "IPBox4";
            this.IPBox4.Size = new System.Drawing.Size(100, 20);
            this.IPBox4.TabIndex = 3;
            this.IPBox4.Text = "1";
            // 
            // SNBox
            // 
            this.SNBox.Location = new System.Drawing.Point(428, 4);
            this.SNBox.MaxLength = 2;
            this.SNBox.Name = "SNBox";
            this.SNBox.Size = new System.Drawing.Size(100, 20);
            this.SNBox.TabIndex = 4;
            this.SNBox.Text = "32";
            this.SNBox.TextChanged += new System.EventHandler(this.SNBox_TextChanged);
            // 
            // generatebutton
            // 
            this.generatebutton.Location = new System.Drawing.Point(534, 2);
            this.generatebutton.Name = "generatebutton";
            this.generatebutton.Size = new System.Drawing.Size(75, 23);
            this.generatebutton.TabIndex = 5;
            this.generatebutton.Text = "generate";
            this.generatebutton.UseVisualStyleBackColor = true;
            this.generatebutton.Click += new System.EventHandler(this.generatebutton_Click);
            // 
            // OUTBox
            // 
            this.OUTBox.Location = new System.Drawing.Point(4, 28);
            this.OUTBox.Multiline = true;
            this.OUTBox.Name = "OUTBox";
            this.OUTBox.ReadOnly = true;
            this.OUTBox.Size = new System.Drawing.Size(323, 176);
            this.OUTBox.TabIndex = 6;
            this.OUTBox.Text = resources.GetString("OUTBox.Text");
            // 
            // ERRBox
            // 
            this.ERRBox.Location = new System.Drawing.Point(333, 28);
            this.ERRBox.Multiline = true;
            this.ERRBox.Name = "ERRBox";
            this.ERRBox.ReadOnly = true;
            this.ERRBox.Size = new System.Drawing.Size(276, 176);
            this.ERRBox.TabIndex = 7;
            this.ERRBox.Text = "Some Errors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 206);
            this.Controls.Add(this.ERRBox);
            this.Controls.Add(this.OUTBox);
            this.Controls.Add(this.generatebutton);
            this.Controls.Add(this.SNBox);
            this.Controls.Add(this.IPBox4);
            this.Controls.Add(this.IPBox3);
            this.Controls.Add(this.IPBox2);
            this.Controls.Add(this.IPBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IPCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPBox1;
        private System.Windows.Forms.TextBox IPBox2;
        private System.Windows.Forms.TextBox IPBox3;
        private System.Windows.Forms.TextBox IPBox4;
        private System.Windows.Forms.TextBox SNBox;
        private System.Windows.Forms.Button generatebutton;
        private System.Windows.Forms.TextBox OUTBox;
        private System.Windows.Forms.TextBox ERRBox;
    }
}

