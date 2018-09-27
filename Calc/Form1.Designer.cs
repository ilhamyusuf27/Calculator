namespace Calc
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
            this.nilaia = new System.Windows.Forms.TextBox();
            this.nilaib = new System.Windows.Forms.TextBox();
            this.operasi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hasil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nilaia
            // 
            this.nilaia.Location = new System.Drawing.Point(29, 29);
            this.nilaia.Name = "nilaia";
            this.nilaia.Size = new System.Drawing.Size(100, 20);
            this.nilaia.TabIndex = 0;
            // 
            // nilaib
            // 
            this.nilaib.Location = new System.Drawing.Point(29, 84);
            this.nilaib.Name = "nilaib";
            this.nilaib.Size = new System.Drawing.Size(100, 20);
            this.nilaib.TabIndex = 1;
            // 
            // operasi
            // 
            this.operasi.FormattingEnabled = true;
            this.operasi.Items.AddRange(new object[] {
            "Pertambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.operasi.Location = new System.Drawing.Point(151, 29);
            this.operasi.Name = "operasi";
            this.operasi.Size = new System.Drawing.Size(121, 21);
            this.operasi.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tekan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hasil
            // 
            this.hasil.Location = new System.Drawing.Point(90, 180);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(100, 20);
            this.hasil.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nilai A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nilai B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "HASIL!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operasi);
            this.Controls.Add(this.nilaib);
            this.Controls.Add(this.nilaia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nilaia;
        private System.Windows.Forms.TextBox nilaib;
        private System.Windows.Forms.ComboBox operasi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox hasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

