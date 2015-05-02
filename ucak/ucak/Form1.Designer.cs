namespace ucak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbucak = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbucak
            // 
            this.gbucak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbucak.BackgroundImage")));
            this.gbucak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbucak.Location = new System.Drawing.Point(50, 12);
            this.gbucak.Name = "gbucak";
            this.gbucak.Size = new System.Drawing.Size(735, 354);
            this.gbucak.TabIndex = 0;
            this.gbucak.TabStop = false;
            this.gbucak.Text = "ucak";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 403);
            this.Controls.Add(this.gbucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbucak;
    }
}

