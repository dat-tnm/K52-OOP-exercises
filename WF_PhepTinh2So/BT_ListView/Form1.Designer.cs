namespace BT_ListView
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
            this.btnNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnLonNhat = new System.Windows.Forms.Button();
            this.btnNhoNhat = new System.Windows.Forms.Button();
            this.btnTangDan = new System.Windows.Forms.Button();
            this.btnGiamDan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDiemTB = new System.Windows.Forms.TextBox();
            this.btnChen = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(12, 120);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(81, 7);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(160, 20);
            this.tbHoTen.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 171);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(339, 242);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnLonNhat
            // 
            this.btnLonNhat.Location = new System.Drawing.Point(12, 429);
            this.btnLonNhat.Name = "btnLonNhat";
            this.btnLonNhat.Size = new System.Drawing.Size(75, 23);
            this.btnLonNhat.TabIndex = 4;
            this.btnLonNhat.Text = "Lớn nhất";
            this.btnLonNhat.UseVisualStyleBackColor = true;
            this.btnLonNhat.Click += new System.EventHandler(this.btnLonNhat_Click);
            // 
            // btnNhoNhat
            // 
            this.btnNhoNhat.Location = new System.Drawing.Point(93, 429);
            this.btnNhoNhat.Name = "btnNhoNhat";
            this.btnNhoNhat.Size = new System.Drawing.Size(75, 23);
            this.btnNhoNhat.TabIndex = 5;
            this.btnNhoNhat.Text = "Nhỏ nhất";
            this.btnNhoNhat.UseVisualStyleBackColor = true;
            this.btnNhoNhat.Click += new System.EventHandler(this.btnNhoNhat_Click);
            // 
            // btnTangDan
            // 
            this.btnTangDan.Location = new System.Drawing.Point(174, 429);
            this.btnTangDan.Name = "btnTangDan";
            this.btnTangDan.Size = new System.Drawing.Size(75, 23);
            this.btnTangDan.TabIndex = 6;
            this.btnTangDan.Text = "Tăng dần";
            this.btnTangDan.UseVisualStyleBackColor = true;
            this.btnTangDan.Click += new System.EventHandler(this.btnTangDan_Click);
            // 
            // btnGiamDan
            // 
            this.btnGiamDan.Location = new System.Drawing.Point(255, 429);
            this.btnGiamDan.Name = "btnGiamDan";
            this.btnGiamDan.Size = new System.Drawing.Size(75, 23);
            this.btnGiamDan.TabIndex = 7;
            this.btnGiamDan.Text = "Giảm dần";
            this.btnGiamDan.UseVisualStyleBackColor = true;
            this.btnGiamDan.Click += new System.EventHandler(this.btnGiamDan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Điểm TB";
            // 
            // tbDiemTB
            // 
            this.tbDiemTB.Location = new System.Drawing.Point(81, 35);
            this.tbDiemTB.Name = "tbDiemTB";
            this.tbDiemTB.Size = new System.Drawing.Size(160, 20);
            this.tbDiemTB.TabIndex = 9;
            // 
            // btnChen
            // 
            this.btnChen.Location = new System.Drawing.Point(93, 120);
            this.btnChen.Name = "btnChen";
            this.btnChen.Size = new System.Drawing.Size(75, 23);
            this.btnChen.TabIndex = 10;
            this.btnChen.Text = "Chèn";
            this.btnChen.UseVisualStyleBackColor = true;
            this.btnChen.Click += new System.EventHandler(this.btnChen_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(174, 120);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(255, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 464);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnChen);
            this.Controls.Add(this.tbDiemTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGiamDan);
            this.Controls.Add(this.btnTangDan);
            this.Controls.Add(this.btnNhoNhat);
            this.Controls.Add(this.btnLonNhat);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnLonNhat;
        private System.Windows.Forms.Button btnNhoNhat;
        private System.Windows.Forms.Button btnTangDan;
        private System.Windows.Forms.Button btnGiamDan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDiemTB;
        private System.Windows.Forms.Button btnChen;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}

