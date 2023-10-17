namespace tugasKalkulator
{
    partial class kalkulator
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnbagi = new System.Windows.Forms.Button();
            this.btnkali = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnkurang = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnHasil = new System.Windows.Forms.Button();
            this.btntitik = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnkl = new System.Windows.Forms.Button();
            this.txtDisplay2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(9, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(355, 42);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnclear.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Snow;
            this.btnclear.Location = new System.Drawing.Point(16, 75);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(82, 48);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.TombolClear_Click);
            // 
            // btnce
            // 
            this.btnce.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnce.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnce.ForeColor = System.Drawing.Color.Snow;
            this.btnce.Location = new System.Drawing.Point(104, 75);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(82, 48);
            this.btnce.TabIndex = 2;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = false;
            this.btnce.Click += new System.EventHandler(this.TombolClear_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnhapus.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.ForeColor = System.Drawing.Color.Snow;
            this.btnhapus.Location = new System.Drawing.Point(193, 75);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(82, 48);
            this.btnhapus.TabIndex = 3;
            this.btnhapus.Text = "<--";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnbagi
            // 
            this.btnbagi.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnbagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbagi.Location = new System.Drawing.Point(282, 75);
            this.btnbagi.Name = "btnbagi";
            this.btnbagi.Size = new System.Drawing.Size(82, 48);
            this.btnbagi.TabIndex = 4;
            this.btnbagi.Text = "/";
            this.btnbagi.UseVisualStyleBackColor = false;
            this.btnbagi.Click += new System.EventHandler(this.btnbagi_Click);
            // 
            // btnkali
            // 
            this.btnkali.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnkali.Location = new System.Drawing.Point(282, 129);
            this.btnkali.Name = "btnkali";
            this.btnkali.Size = new System.Drawing.Size(82, 48);
            this.btnkali.TabIndex = 8;
            this.btnkali.Text = "X";
            this.btnkali.UseVisualStyleBackColor = false;
            this.btnkali.Click += new System.EventHandler(this.btnkali_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.ForestGreen;
            this.btn9.Location = new System.Drawing.Point(194, 129);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(82, 48);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.ForestGreen;
            this.btn8.Location = new System.Drawing.Point(105, 129);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(82, 48);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.ForestGreen;
            this.btn7.Location = new System.Drawing.Point(16, 129);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(82, 48);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btntambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntambah.Location = new System.Drawing.Point(282, 183);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(82, 48);
            this.btntambah.TabIndex = 12;
            this.btntambah.Text = "+";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.ForestGreen;
            this.btn6.Location = new System.Drawing.Point(194, 183);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(82, 48);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.ForestGreen;
            this.btn5.Location = new System.Drawing.Point(105, 183);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(82, 48);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.ForestGreen;
            this.btn4.Location = new System.Drawing.Point(16, 183);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(82, 48);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnkurang
            // 
            this.btnkurang.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnkurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkurang.Location = new System.Drawing.Point(282, 237);
            this.btnkurang.Name = "btnkurang";
            this.btnkurang.Size = new System.Drawing.Size(82, 48);
            this.btnkurang.TabIndex = 16;
            this.btnkurang.Text = "-";
            this.btnkurang.UseVisualStyleBackColor = false;
            this.btnkurang.Click += new System.EventHandler(this.btnkurang_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.ForestGreen;
            this.btn3.Location = new System.Drawing.Point(193, 237);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(82, 48);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.ForestGreen;
            this.btn2.Location = new System.Drawing.Point(104, 237);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(82, 48);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.ForestGreen;
            this.btn1.Location = new System.Drawing.Point(16, 237);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(82, 48);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnHasil
            // 
            this.btnHasil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHasil.Location = new System.Drawing.Point(282, 291);
            this.btnHasil.Name = "btnHasil";
            this.btnHasil.Size = new System.Drawing.Size(82, 48);
            this.btnHasil.TabIndex = 20;
            this.btnHasil.Text = "=";
            this.btnHasil.UseVisualStyleBackColor = false;
            this.btnHasil.Click += new System.EventHandler(this.btnHasil_Click);
            // 
            // btntitik
            // 
            this.btntitik.BackColor = System.Drawing.Color.SpringGreen;
            this.btntitik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntitik.Location = new System.Drawing.Point(194, 291);
            this.btntitik.Name = "btntitik";
            this.btntitik.Size = new System.Drawing.Size(82, 48);
            this.btntitik.TabIndex = 19;
            this.btntitik.Text = ".";
            this.btntitik.UseVisualStyleBackColor = false;
            this.btntitik.Click += new System.EventHandler(this.btntitik_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.ForestGreen;
            this.btn0.Location = new System.Drawing.Point(105, 291);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(82, 48);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnkl
            // 
            this.btnkl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnkl.Location = new System.Drawing.Point(16, 291);
            this.btnkl.Name = "btnkl";
            this.btnkl.Size = new System.Drawing.Size(82, 48);
            this.btnkl.TabIndex = 17;
            this.btnkl.Text = "+/-";
            this.btnkl.UseVisualStyleBackColor = false;
            this.btnkl.Click += new System.EventHandler(this.btnkl_Click);
            // 
            // txtDisplay2
            // 
            this.txtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay2.Location = new System.Drawing.Point(14, 26);
            this.txtDisplay2.Name = "txtDisplay2";
            this.txtDisplay2.Size = new System.Drawing.Size(63, 13);
            this.txtDisplay2.TabIndex = 21;
            // 
            // kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(376, 350);
            this.Controls.Add(this.txtDisplay2);
            this.Controls.Add(this.btnHasil);
            this.Controls.Add(this.btntitik);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnkl);
            this.Controls.Add(this.btnkurang);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnkali);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnbagi);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "kalkulator";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnbagi;
        private System.Windows.Forms.Button btnkali;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnkurang;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnHasil;
        private System.Windows.Forms.Button btntitik;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnkl;
        private System.Windows.Forms.TextBox txtDisplay2;
    }
}

