namespace AppDateTime
{
    partial class FrmDateTimeCount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnHitung = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpJamSampai = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.NudLamaPerjalanan = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpJamBerangkat = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnHitung2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpJamSampai2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.NudLamaPerjalanan2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpJamBerangkat2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudLamaPerjalanan)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudLamaPerjalanan2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnHitung);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DtpJamSampai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NudLamaPerjalanan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtpJamBerangkat);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Add";
            // 
            // BtnHitung
            // 
            this.BtnHitung.Location = new System.Drawing.Point(140, 97);
            this.BtnHitung.Name = "BtnHitung";
            this.BtnHitung.Size = new System.Drawing.Size(72, 23);
            this.BtnHitung.TabIndex = 6;
            this.BtnHitung.Text = "Hitung";
            this.BtnHitung.UseVisualStyleBackColor = true;
            this.BtnHitung.Click += new System.EventHandler(this.BtnHitung_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jam sampai";
            // 
            // DtpJamSampai
            // 
            this.DtpJamSampai.CustomFormat = "HH:mm:ss";
            this.DtpJamSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpJamSampai.Location = new System.Drawing.Point(140, 71);
            this.DtpJamSampai.Name = "DtpJamSampai";
            this.DtpJamSampai.ShowUpDown = true;
            this.DtpJamSampai.Size = new System.Drawing.Size(72, 20);
            this.DtpJamSampai.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lama perjalanan (detik)";
            // 
            // NudLamaPerjalanan
            // 
            this.NudLamaPerjalanan.Location = new System.Drawing.Point(140, 45);
            this.NudLamaPerjalanan.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NudLamaPerjalanan.Name = "NudLamaPerjalanan";
            this.NudLamaPerjalanan.Size = new System.Drawing.Size(72, 20);
            this.NudLamaPerjalanan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jam berangkat";
            // 
            // DtpJamBerangkat
            // 
            this.DtpJamBerangkat.CustomFormat = "HH:mm:ss";
            this.DtpJamBerangkat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpJamBerangkat.Location = new System.Drawing.Point(140, 19);
            this.DtpJamBerangkat.Name = "DtpJamBerangkat";
            this.DtpJamBerangkat.ShowUpDown = true;
            this.DtpJamBerangkat.Size = new System.Drawing.Size(72, 20);
            this.DtpJamBerangkat.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnHitung2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DtpJamSampai2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.NudLamaPerjalanan2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.DtpJamBerangkat2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date Diff";
            // 
            // BtnHitung2
            // 
            this.BtnHitung2.Location = new System.Drawing.Point(140, 97);
            this.BtnHitung2.Name = "BtnHitung2";
            this.BtnHitung2.Size = new System.Drawing.Size(72, 23);
            this.BtnHitung2.TabIndex = 6;
            this.BtnHitung2.Text = "Hitung";
            this.BtnHitung2.UseVisualStyleBackColor = true;
            this.BtnHitung2.Click += new System.EventHandler(this.BtnHitung2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jam sampai";
            // 
            // DtpJamSampai2
            // 
            this.DtpJamSampai2.CustomFormat = "HH:mm:ss";
            this.DtpJamSampai2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpJamSampai2.Location = new System.Drawing.Point(140, 45);
            this.DtpJamSampai2.Name = "DtpJamSampai2";
            this.DtpJamSampai2.ShowUpDown = true;
            this.DtpJamSampai2.Size = new System.Drawing.Size(72, 20);
            this.DtpJamSampai2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lama perjalanan (detik)";
            // 
            // NudLamaPerjalanan2
            // 
            this.NudLamaPerjalanan2.Location = new System.Drawing.Point(140, 71);
            this.NudLamaPerjalanan2.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NudLamaPerjalanan2.Name = "NudLamaPerjalanan2";
            this.NudLamaPerjalanan2.Size = new System.Drawing.Size(72, 20);
            this.NudLamaPerjalanan2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Jam berangkat";
            // 
            // DtpJamBerangkat2
            // 
            this.DtpJamBerangkat2.CustomFormat = "HH:mm:ss";
            this.DtpJamBerangkat2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpJamBerangkat2.Location = new System.Drawing.Point(140, 19);
            this.DtpJamBerangkat2.Name = "DtpJamBerangkat2";
            this.DtpJamBerangkat2.ShowUpDown = true;
            this.DtpJamBerangkat2.Size = new System.Drawing.Size(72, 20);
            this.DtpJamBerangkat2.TabIndex = 0;
            // 
            // FrmDateTimeCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 327);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDateTimeCount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDateTimeCount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudLamaPerjalanan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudLamaPerjalanan2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnHitung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpJamSampai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudLamaPerjalanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpJamBerangkat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnHitung2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpJamSampai2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NudLamaPerjalanan2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpJamBerangkat2;
    }
}