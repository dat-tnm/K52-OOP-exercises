namespace WindowsFormsApp1
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
            this.ps1TuSo = new System.Windows.Forms.TextBox();
            this.ps1MauSo = new System.Windows.Forms.TextBox();
            this.ps2TuSo = new System.Windows.Forms.TextBox();
            this.ps2MauSo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.kqTuSo = new System.Windows.Forms.TextBox();
            this.kqMauSo = new System.Windows.Forms.TextBox();
            this.Lammoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ps1TuSo
            // 
            this.ps1TuSo.Location = new System.Drawing.Point(72, 35);
            this.ps1TuSo.Name = "ps1TuSo";
            this.ps1TuSo.Size = new System.Drawing.Size(54, 20);
            this.ps1TuSo.TabIndex = 0;
            this.ps1TuSo.TextChanged += new System.EventHandler(this.ps1TuSo_TextChanged);
            // 
            // ps1MauSo
            // 
            this.ps1MauSo.Location = new System.Drawing.Point(72, 61);
            this.ps1MauSo.Name = "ps1MauSo";
            this.ps1MauSo.Size = new System.Drawing.Size(54, 20);
            this.ps1MauSo.TabIndex = 1;
            this.ps1MauSo.TextChanged += new System.EventHandler(this.ps1MauSo_TextChanged);
            // 
            // ps2TuSo
            // 
            this.ps2TuSo.Location = new System.Drawing.Point(72, 169);
            this.ps2TuSo.Name = "ps2TuSo";
            this.ps2TuSo.Size = new System.Drawing.Size(54, 20);
            this.ps2TuSo.TabIndex = 2;
            this.ps2TuSo.TextChanged += new System.EventHandler(this.ps2TuSo_TextChanged);
            // 
            // ps2MauSo
            // 
            this.ps2MauSo.Location = new System.Drawing.Point(72, 195);
            this.ps2MauSo.Name = "ps2MauSo";
            this.ps2MauSo.Size = new System.Drawing.Size(54, 20);
            this.ps2MauSo.TabIndex = 3;
            this.ps2MauSo.TextChanged += new System.EventHandler(this.ps2MauSo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phan So 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phan So 2";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(217, 46);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(56, 49);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(217, 113);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(56, 53);
            this.minusBtn.TabIndex = 7;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Location = new System.Drawing.Point(217, 181);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(56, 47);
            this.multiplyBtn.TabIndex = 8;
            this.multiplyBtn.Text = "x";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            // 
            // divideBtn
            // 
            this.divideBtn.Location = new System.Drawing.Point(217, 244);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(56, 49);
            this.divideBtn.TabIndex = 9;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ket qua";
            // 
            // kqTuSo
            // 
            this.kqTuSo.Location = new System.Drawing.Point(474, 133);
            this.kqTuSo.Name = "kqTuSo";
            this.kqTuSo.Size = new System.Drawing.Size(58, 20);
            this.kqTuSo.TabIndex = 11;
            // 
            // kqMauSo
            // 
            this.kqMauSo.Location = new System.Drawing.Point(474, 169);
            this.kqMauSo.Name = "kqMauSo";
            this.kqMauSo.Size = new System.Drawing.Size(58, 20);
            this.kqMauSo.TabIndex = 12;
            // 
            // Lammoi
            // 
            this.Lammoi.Location = new System.Drawing.Point(388, 244);
            this.Lammoi.Name = "Lammoi";
            this.Lammoi.Size = new System.Drawing.Size(93, 36);
            this.Lammoi.TabIndex = 13;
            this.Lammoi.Text = "Lam moi";
            this.Lammoi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 320);
            this.Controls.Add(this.Lammoi);
            this.Controls.Add(this.kqMauSo);
            this.Controls.Add(this.kqTuSo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ps2MauSo);
            this.Controls.Add(this.ps2TuSo);
            this.Controls.Add(this.ps1MauSo);
            this.Controls.Add(this.ps1TuSo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ps1TuSo;
        private System.Windows.Forms.TextBox ps1MauSo;
        private System.Windows.Forms.TextBox ps2TuSo;
        private System.Windows.Forms.TextBox ps2MauSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kqTuSo;
        private System.Windows.Forms.TextBox kqMauSo;
        private System.Windows.Forms.Button Lammoi;
    }
}

