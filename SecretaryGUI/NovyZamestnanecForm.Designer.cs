
namespace SecretaryGUI
{
    partial class headerLabel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(headerLabel));
            this.label1 = new System.Windows.Forms.Label();
            this.JmenoLabel = new System.Windows.Forms.Label();
            this.PrijmeniLabel = new System.Windows.Forms.Label();
            this.JmenoTextBox = new System.Windows.Forms.TextBox();
            this.PrijmeniTextBox = new System.Windows.Forms.TextBox();
            this.EmailPracovniLabel = new System.Windows.Forms.Label();
            this.EmailPracovniTextBox = new System.Windows.Forms.TextBox();
            this.EmailSoukromyLabel = new System.Windows.Forms.Label();
            this.EmailSoukromyTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TelefonPracovniTextBox = new System.Windows.Forms.TextBox();
            this.TelefonPracovniLabel = new System.Windows.Forms.Label();
            this.TelefonSoukromyLabel = new System.Windows.Forms.Label();
            this.UvazekLabel = new System.Windows.Forms.Label();
            this.UvazekNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DoktorandLabel = new System.Windows.Forms.Label();
            this.DoktorandCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.UvazekNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vloz Novy Zamestnanec";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // JmenoLabel
            // 
            this.JmenoLabel.AutoSize = true;
            this.JmenoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JmenoLabel.ForeColor = System.Drawing.Color.Black;
            this.JmenoLabel.Location = new System.Drawing.Point(10, 91);
            this.JmenoLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.JmenoLabel.Name = "JmenoLabel";
            this.JmenoLabel.Size = new System.Drawing.Size(61, 20);
            this.JmenoLabel.TabIndex = 1;
            this.JmenoLabel.Text = "Jmeno:";
            // 
            // PrijmeniLabel
            // 
            this.PrijmeniLabel.AutoSize = true;
            this.PrijmeniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrijmeniLabel.ForeColor = System.Drawing.Color.Black;
            this.PrijmeniLabel.Location = new System.Drawing.Point(180, 91);
            this.PrijmeniLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PrijmeniLabel.Name = "PrijmeniLabel";
            this.PrijmeniLabel.Size = new System.Drawing.Size(72, 20);
            this.PrijmeniLabel.TabIndex = 3;
            this.PrijmeniLabel.Text = "Prijmeni: ";
            // 
            // JmenoTextBox
            // 
            this.JmenoTextBox.Location = new System.Drawing.Point(73, 85);
            this.JmenoTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.JmenoTextBox.Name = "JmenoTextBox";
            this.JmenoTextBox.Size = new System.Drawing.Size(105, 26);
            this.JmenoTextBox.TabIndex = 4;
            this.JmenoTextBox.Text = "<text>";
            this.JmenoTextBox.TextChanged += new System.EventHandler(this.JmenoTextBox_TextChanged);
            // 
            // PrijmeniTextBox
            // 
            this.PrijmeniTextBox.Location = new System.Drawing.Point(245, 85);
            this.PrijmeniTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PrijmeniTextBox.Name = "PrijmeniTextBox";
            this.PrijmeniTextBox.Size = new System.Drawing.Size(136, 26);
            this.PrijmeniTextBox.TabIndex = 5;
            this.PrijmeniTextBox.Text = "<text>";
            // 
            // EmailPracovniLabel
            // 
            this.EmailPracovniLabel.AutoSize = true;
            this.EmailPracovniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailPracovniLabel.ForeColor = System.Drawing.Color.Black;
            this.EmailPracovniLabel.Location = new System.Drawing.Point(10, 123);
            this.EmailPracovniLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.EmailPracovniLabel.Name = "EmailPracovniLabel";
            this.EmailPracovniLabel.Size = new System.Drawing.Size(116, 20);
            this.EmailPracovniLabel.TabIndex = 6;
            this.EmailPracovniLabel.Text = "Email Pracovni:";
            // 
            // EmailPracovniTextBox
            // 
            this.EmailPracovniTextBox.Location = new System.Drawing.Point(188, 117);
            this.EmailPracovniTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.EmailPracovniTextBox.Name = "EmailPracovniTextBox";
            this.EmailPracovniTextBox.Size = new System.Drawing.Size(193, 26);
            this.EmailPracovniTextBox.TabIndex = 7;
            this.EmailPracovniTextBox.Text = "<text>";
            // 
            // EmailSoukromyLabel
            // 
            this.EmailSoukromyLabel.AutoSize = true;
            this.EmailSoukromyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailSoukromyLabel.ForeColor = System.Drawing.Color.Black;
            this.EmailSoukromyLabel.Location = new System.Drawing.Point(10, 153);
            this.EmailSoukromyLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.EmailSoukromyLabel.Name = "EmailSoukromyLabel";
            this.EmailSoukromyLabel.Size = new System.Drawing.Size(127, 20);
            this.EmailSoukromyLabel.TabIndex = 8;
            this.EmailSoukromyLabel.Text = "Email Soukromy:";
            // 
            // EmailSoukromyTextBox
            // 
            this.EmailSoukromyTextBox.Location = new System.Drawing.Point(188, 147);
            this.EmailSoukromyTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.EmailSoukromyTextBox.Name = "EmailSoukromyTextBox";
            this.EmailSoukromyTextBox.Size = new System.Drawing.Size(193, 26);
            this.EmailSoukromyTextBox.TabIndex = 9;
            this.EmailSoukromyTextBox.Text = "<text>";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 205);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 26);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "<text>";
            // 
            // TelefonPracovniTextBox
            // 
            this.TelefonPracovniTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TelefonPracovniTextBox.Location = new System.Drawing.Point(188, 176);
            this.TelefonPracovniTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TelefonPracovniTextBox.Name = "TelefonPracovniTextBox";
            this.TelefonPracovniTextBox.Size = new System.Drawing.Size(118, 26);
            this.TelefonPracovniTextBox.TabIndex = 11;
            this.TelefonPracovniTextBox.Text = "<text>";
            // 
            // TelefonPracovniLabel
            // 
            this.TelefonPracovniLabel.AutoSize = true;
            this.TelefonPracovniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TelefonPracovniLabel.ForeColor = System.Drawing.Color.Black;
            this.TelefonPracovniLabel.Location = new System.Drawing.Point(10, 182);
            this.TelefonPracovniLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TelefonPracovniLabel.Name = "TelefonPracovniLabel";
            this.TelefonPracovniLabel.Size = new System.Drawing.Size(130, 20);
            this.TelefonPracovniLabel.TabIndex = 10;
            this.TelefonPracovniLabel.Text = "Telefon Pracovni:";
            // 
            // TelefonSoukromyLabel
            // 
            this.TelefonSoukromyLabel.AutoSize = true;
            this.TelefonSoukromyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TelefonSoukromyLabel.ForeColor = System.Drawing.Color.Black;
            this.TelefonSoukromyLabel.Location = new System.Drawing.Point(10, 211);
            this.TelefonSoukromyLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TelefonSoukromyLabel.Name = "TelefonSoukromyLabel";
            this.TelefonSoukromyLabel.Size = new System.Drawing.Size(141, 20);
            this.TelefonSoukromyLabel.TabIndex = 14;
            this.TelefonSoukromyLabel.Text = "Telefon Soukromy:";
            // 
            // UvazekLabel
            // 
            this.UvazekLabel.AutoSize = true;
            this.UvazekLabel.ForeColor = System.Drawing.Color.Black;
            this.UvazekLabel.Location = new System.Drawing.Point(10, 241);
            this.UvazekLabel.Name = "UvazekLabel";
            this.UvazekLabel.Size = new System.Drawing.Size(66, 20);
            this.UvazekLabel.TabIndex = 15;
            this.UvazekLabel.Text = "Uvazek:";
            // 
            // UvazekNumericUpDown
            // 
            this.UvazekNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.UvazekNumericUpDown.Location = new System.Drawing.Point(188, 235);
            this.UvazekNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UvazekNumericUpDown.Name = "UvazekNumericUpDown";
            this.UvazekNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.UvazekNumericUpDown.TabIndex = 17;
            this.UvazekNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DoktorandLabel
            // 
            this.DoktorandLabel.AutoSize = true;
            this.DoktorandLabel.ForeColor = System.Drawing.Color.Black;
            this.DoktorandLabel.Location = new System.Drawing.Point(12, 269);
            this.DoktorandLabel.Name = "DoktorandLabel";
            this.DoktorandLabel.Size = new System.Drawing.Size(84, 20);
            this.DoktorandLabel.TabIndex = 18;
            this.DoktorandLabel.Text = "Doktorand";
            // 
            // DoktorandCheckBox
            // 
            this.DoktorandCheckBox.AutoSize = true;
            this.DoktorandCheckBox.ForeColor = System.Drawing.Color.Black;
            this.DoktorandCheckBox.Location = new System.Drawing.Point(188, 273);
            this.DoktorandCheckBox.Name = "DoktorandCheckBox";
            this.DoktorandCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DoktorandCheckBox.TabIndex = 19;
            this.DoktorandCheckBox.UseVisualStyleBackColor = true;
            // 
            // headerLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 711);
            this.Controls.Add(this.DoktorandCheckBox);
            this.Controls.Add(this.DoktorandLabel);
            this.Controls.Add(this.UvazekNumericUpDown);
            this.Controls.Add(this.UvazekLabel);
            this.Controls.Add(this.TelefonSoukromyLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TelefonPracovniTextBox);
            this.Controls.Add(this.TelefonPracovniLabel);
            this.Controls.Add(this.EmailSoukromyTextBox);
            this.Controls.Add(this.EmailSoukromyLabel);
            this.Controls.Add(this.EmailPracovniTextBox);
            this.Controls.Add(this.EmailPracovniLabel);
            this.Controls.Add(this.PrijmeniTextBox);
            this.Controls.Add(this.JmenoTextBox);
            this.Controls.Add(this.PrijmeniLabel);
            this.Controls.Add(this.JmenoLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "headerLabel";
            this.Text = "NovyZamestnanec";
            ((System.ComponentModel.ISupportInitialize)(this.UvazekNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label JmenoLabel;
        private System.Windows.Forms.Label PrijmeniLabel;
        private System.Windows.Forms.TextBox JmenoTextBox;
        private System.Windows.Forms.TextBox PrijmeniTextBox;
        private System.Windows.Forms.Label EmailPracovniLabel;
        private System.Windows.Forms.TextBox EmailPracovniTextBox;
        private System.Windows.Forms.Label EmailSoukromyLabel;
        private System.Windows.Forms.TextBox EmailSoukromyTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TelefonPracovniTextBox;
        private System.Windows.Forms.Label TelefonPracovniLabel;
        private System.Windows.Forms.Label TelefonSoukromyLabel;
        private System.Windows.Forms.Label UvazekLabel;
        private System.Windows.Forms.NumericUpDown UvazekNumericUpDown;
        private System.Windows.Forms.Label DoktorandLabel;
        private System.Windows.Forms.CheckBox DoktorandCheckBox;
    }
}

