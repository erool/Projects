namespace yeni
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.at1 = new System.Windows.Forms.Button();
            this.at2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rdnkirmizi = new System.Windows.Forms.RadioButton();
            this.rdnsiyah = new System.Windows.Forms.RadioButton();
            this.rndberaber = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(639, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 361);
            this.label1.TabIndex = 0;
            this.label1.Text = "finish";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // at1
            // 
            this.at1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("at1.BackgroundImage")));
            this.at1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.at1.Location = new System.Drawing.Point(1, 116);
            this.at1.Name = "at1";
            this.at1.Size = new System.Drawing.Size(75, 60);
            this.at1.TabIndex = 1;
            this.at1.UseVisualStyleBackColor = true;
            // 
            // at2
            // 
            this.at2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("at2.BackgroundImage")));
            this.at2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.at2.Location = new System.Drawing.Point(1, 231);
            this.at2.Name = "at2";
            this.at2.Size = new System.Drawing.Size(75, 60);
            this.at2.TabIndex = 2;
            this.at2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "basla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "kırmız at 1.70";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormatString = "N0";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(470, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "siyah at 3.20";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(318, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // rdnkirmizi
            // 
            this.rdnkirmizi.AutoSize = true;
            this.rdnkirmizi.Location = new System.Drawing.Point(134, 30);
            this.rdnkirmizi.Name = "rdnkirmizi";
            this.rdnkirmizi.Size = new System.Drawing.Size(65, 17);
            this.rdnkirmizi.TabIndex = 11;
            this.rdnkirmizi.TabStop = true;
            this.rdnkirmizi.Text = "kırmızı at";
            this.rdnkirmizi.UseVisualStyleBackColor = true;
            // 
            // rdnsiyah
            // 
            this.rdnsiyah.AutoSize = true;
            this.rdnsiyah.Location = new System.Drawing.Point(134, 53);
            this.rdnsiyah.Name = "rdnsiyah";
            this.rdnsiyah.Size = new System.Drawing.Size(61, 17);
            this.rdnsiyah.TabIndex = 12;
            this.rdnsiyah.TabStop = true;
            this.rdnsiyah.Text = "siyah at";
            this.rdnsiyah.UseVisualStyleBackColor = true;
            // 
            // rndberaber
            // 
            this.rndberaber.AutoSize = true;
            this.rndberaber.Location = new System.Drawing.Point(134, 76);
            this.rndberaber.Name = "rndberaber";
            this.rndberaber.Size = new System.Drawing.Size(61, 17);
            this.rndberaber.TabIndex = 13;
            this.rndberaber.TabStop = true;
            this.rndberaber.Text = "beraber";
            this.rndberaber.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 400);
            this.Controls.Add(this.rndberaber);
            this.Controls.Add(this.rdnsiyah);
            this.Controls.Add(this.rdnkirmizi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.at2);
            this.Controls.Add(this.at1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button at1;
        private System.Windows.Forms.Button at2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rdnkirmizi;
        private System.Windows.Forms.RadioButton rdnsiyah;
        private System.Windows.Forms.RadioButton rndberaber;
    }
}

