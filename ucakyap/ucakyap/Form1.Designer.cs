namespace ucakyap
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
            this.scanapanel = new System.Windows.Forms.SplitContainer();
            this.butonolustur = new System.Windows.Forms.Button();
            this.numysira = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numxsira = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlsecenekelr = new System.Windows.Forms.Panel();
            this.rdhicbiri = new System.Windows.Forms.RadioButton();
            this.rderkek = new System.Windows.Forms.RadioButton();
            this.rdkiz = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.scanapanel)).BeginInit();
            this.scanapanel.Panel1.SuspendLayout();
            this.scanapanel.Panel2.SuspendLayout();
            this.scanapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numysira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numxsira)).BeginInit();
            this.pnlsecenekelr.SuspendLayout();
            this.SuspendLayout();
            // 
            // scanapanel
            // 
            this.scanapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scanapanel.Location = new System.Drawing.Point(0, 0);
            this.scanapanel.Name = "scanapanel";
            this.scanapanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scanapanel.Panel1
            // 
            this.scanapanel.Panel1.Controls.Add(this.butonolustur);
            this.scanapanel.Panel1.Controls.Add(this.numysira);
            this.scanapanel.Panel1.Controls.Add(this.label2);
            this.scanapanel.Panel1.Controls.Add(this.numxsira);
            this.scanapanel.Panel1.Controls.Add(this.label1);
            // 
            // scanapanel.Panel2
            // 
            this.scanapanel.Panel2.Controls.Add(this.pnlsecenekelr);
            this.scanapanel.Size = new System.Drawing.Size(775, 612);
            this.scanapanel.SplitterDistance = 88;
            this.scanapanel.TabIndex = 0;
            // 
            // butonolustur
            // 
            this.butonolustur.Location = new System.Drawing.Point(284, 27);
            this.butonolustur.Name = "butonolustur";
            this.butonolustur.Size = new System.Drawing.Size(75, 41);
            this.butonolustur.TabIndex = 13;
            this.butonolustur.Text = "button1";
            this.butonolustur.UseVisualStyleBackColor = true;
            this.butonolustur.Click += new System.EventHandler(this.butonolustur_Click);
            // 
            // numysira
            // 
            this.numysira.Location = new System.Drawing.Point(112, 66);
            this.numysira.Name = "numysira";
            this.numysira.Size = new System.Drawing.Size(120, 20);
            this.numysira.TabIndex = 12;
            this.numysira.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "arka arkaya";
            // 
            // numxsira
            // 
            this.numxsira.Location = new System.Drawing.Point(112, 40);
            this.numxsira.Name = "numxsira";
            this.numxsira.Size = new System.Drawing.Size(120, 20);
            this.numxsira.TabIndex = 10;
            this.numxsira.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "yanyana";
            // 
            // pnlsecenekelr
            // 
            this.pnlsecenekelr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlsecenekelr.Controls.Add(this.listBox1);
            this.pnlsecenekelr.Controls.Add(this.comboBox1);
            this.pnlsecenekelr.Controls.Add(this.rdhicbiri);
            this.pnlsecenekelr.Controls.Add(this.rderkek);
            this.pnlsecenekelr.Controls.Add(this.rdkiz);
            this.pnlsecenekelr.Location = new System.Drawing.Point(535, 34);
            this.pnlsecenekelr.Name = "pnlsecenekelr";
            this.pnlsecenekelr.Size = new System.Drawing.Size(200, 337);
            this.pnlsecenekelr.TabIndex = 0;
            // 
            // rdhicbiri
            // 
            this.rdhicbiri.AutoSize = true;
            this.rdhicbiri.Checked = true;
            this.rdhicbiri.Location = new System.Drawing.Point(29, 81);
            this.rdhicbiri.Name = "rdhicbiri";
            this.rdhicbiri.Size = new System.Drawing.Size(52, 17);
            this.rdhicbiri.TabIndex = 3;
            this.rdhicbiri.TabStop = true;
            this.rdhicbiri.Text = "hicbiri";
            this.rdhicbiri.UseVisualStyleBackColor = true;
            // 
            // rderkek
            // 
            this.rderkek.AutoSize = true;
            this.rderkek.Location = new System.Drawing.Point(29, 35);
            this.rderkek.Name = "rderkek";
            this.rderkek.Size = new System.Drawing.Size(52, 17);
            this.rderkek.TabIndex = 2;
            this.rderkek.Text = "erkek";
            this.rderkek.UseVisualStyleBackColor = true;
            // 
            // rdkiz
            // 
            this.rdkiz.AutoSize = true;
            this.rdkiz.Location = new System.Drawing.Point(29, 58);
            this.rdkiz.Name = "rdkiz";
            this.rdkiz.Size = new System.Drawing.Size(38, 17);
            this.rdkiz.TabIndex = 1;
            this.rdkiz.Text = "kız";
            this.rdkiz.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "pencere",
            "koridor"});
            this.comboBox1.Location = new System.Drawing.Point(29, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "kadın",
            "erkek",
            "hicbiri"});
            this.listBox1.Location = new System.Drawing.Point(14, 157);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 147);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 612);
            this.Controls.Add(this.scanapanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.scanapanel.Panel1.ResumeLayout(false);
            this.scanapanel.Panel1.PerformLayout();
            this.scanapanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scanapanel)).EndInit();
            this.scanapanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numysira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numxsira)).EndInit();
            this.pnlsecenekelr.ResumeLayout(false);
            this.pnlsecenekelr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scanapanel;
        private System.Windows.Forms.NumericUpDown numysira;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numxsira;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butonolustur;
        private System.Windows.Forms.Panel pnlsecenekelr;
        private System.Windows.Forms.RadioButton rdhicbiri;
        private System.Windows.Forms.RadioButton rderkek;
        private System.Windows.Forms.RadioButton rdkiz;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;

    }
}

