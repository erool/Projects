namespace try2
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
            this.button1 = new System.Windows.Forms.Button();
            this.zar1 = new System.Windows.Forms.Label();
            this.zar2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "zar at";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zar1
            // 
            this.zar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.zar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.zar1.Location = new System.Drawing.Point(65, 56);
            this.zar1.Name = "zar1";
            this.zar1.Size = new System.Drawing.Size(45, 47);
            this.zar1.TabIndex = 1;
            this.zar1.Text = "0";
            // 
            // zar2
            // 
            this.zar2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.zar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.zar2.Location = new System.Drawing.Point(131, 56);
            this.zar2.Name = "zar2";
            this.zar2.Size = new System.Drawing.Size(45, 47);
            this.zar2.TabIndex = 2;
            this.zar2.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 193);
            this.Controls.Add(this.zar2);
            this.Controls.Add(this.zar1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label zar1;
        private System.Windows.Forms.Label zar2;
        private System.Windows.Forms.Timer timer1;
    }
}

