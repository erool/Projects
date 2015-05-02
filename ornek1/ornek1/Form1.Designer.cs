namespace ornek1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(95, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "topla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(95, 36);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(209, 20);
            this.txtsayi1.TabIndex = 1;
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(95, 62);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(209, 20);
            this.txtsayi2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 452);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.txtsayi1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.TextBox txtsayi2;
    }
}

