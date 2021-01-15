namespace QuanLyDiem
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMail = new System.Windows.Forms.TabPage();
            this.btnMAdd = new System.Windows.Forms.Button();
            this.cbbMType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMDelete = new System.Windows.Forms.Button();
            this.tbMToAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMEdit = new System.Windows.Forms.Button();
            this.tbMReceiver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabItem = new System.Windows.Forms.TabPage();
            this.btnIAdd = new System.Windows.Forms.Button();
            this.tbIWeight = new System.Windows.Forms.TextBox();
            this.btnIDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIEdit = new System.Windows.Forms.Button();
            this.tbIToAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIReceiver = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabMail.SuspendLayout();
            this.tabItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMail);
            this.tabControl1.Controls.Add(this.tabItem);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 148);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMail
            // 
            this.tabMail.Controls.Add(this.btnMAdd);
            this.tabMail.Controls.Add(this.cbbMType);
            this.tabMail.Controls.Add(this.label3);
            this.tabMail.Controls.Add(this.btnMDelete);
            this.tabMail.Controls.Add(this.tbMToAddress);
            this.tabMail.Controls.Add(this.label2);
            this.tabMail.Controls.Add(this.btnMEdit);
            this.tabMail.Controls.Add(this.tbMReceiver);
            this.tabMail.Controls.Add(this.label1);
            this.tabMail.Location = new System.Drawing.Point(4, 22);
            this.tabMail.Name = "tabMail";
            this.tabMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabMail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabMail.Size = new System.Drawing.Size(463, 122);
            this.tabMail.TabIndex = 0;
            this.tabMail.Text = "Thư";
            this.tabMail.UseVisualStyleBackColor = true;
            // 
            // btnMAdd
            // 
            this.btnMAdd.Location = new System.Drawing.Point(7, 93);
            this.btnMAdd.Name = "btnMAdd";
            this.btnMAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMAdd.TabIndex = 14;
            this.btnMAdd.Text = "Thêm mới";
            this.btnMAdd.UseVisualStyleBackColor = true;
            this.btnMAdd.Click += new System.EventHandler(this.btnMAdd_Click);
            // 
            // cbbMType
            // 
            this.cbbMType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMType.FormattingEnabled = true;
            this.cbbMType.Location = new System.Drawing.Point(107, 58);
            this.cbbMType.Name = "cbbMType";
            this.cbbMType.Size = new System.Drawing.Size(121, 21);
            this.cbbMType.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại thư";
            // 
            // btnMDelete
            // 
            this.btnMDelete.Location = new System.Drawing.Point(169, 93);
            this.btnMDelete.Name = "btnMDelete";
            this.btnMDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMDelete.TabIndex = 16;
            this.btnMDelete.Text = "Xóa";
            this.btnMDelete.UseVisualStyleBackColor = true;
            this.btnMDelete.Click += new System.EventHandler(this.btnMDelete_Click);
            // 
            // tbMToAddress
            // 
            this.tbMToAddress.Location = new System.Drawing.Point(107, 32);
            this.tbMToAddress.Name = "tbMToAddress";
            this.tbMToAddress.Size = new System.Drawing.Size(245, 20);
            this.tbMToAddress.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Địa chỉ nhận";
            // 
            // btnMEdit
            // 
            this.btnMEdit.Location = new System.Drawing.Point(88, 93);
            this.btnMEdit.Name = "btnMEdit";
            this.btnMEdit.Size = new System.Drawing.Size(75, 23);
            this.btnMEdit.TabIndex = 15;
            this.btnMEdit.Text = "Sửa";
            this.btnMEdit.UseVisualStyleBackColor = true;
            this.btnMEdit.Click += new System.EventHandler(this.btnMEdit_Click);
            // 
            // tbMReceiver
            // 
            this.tbMReceiver.Location = new System.Drawing.Point(107, 6);
            this.tbMReceiver.Name = "tbMReceiver";
            this.tbMReceiver.Size = new System.Drawing.Size(245, 20);
            this.tbMReceiver.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Người nhận";
            // 
            // tabItem
            // 
            this.tabItem.Controls.Add(this.btnIAdd);
            this.tabItem.Controls.Add(this.tbIWeight);
            this.tabItem.Controls.Add(this.btnIDelete);
            this.tabItem.Controls.Add(this.label6);
            this.tabItem.Controls.Add(this.btnIEdit);
            this.tabItem.Controls.Add(this.tbIToAddress);
            this.tabItem.Controls.Add(this.label4);
            this.tabItem.Controls.Add(this.label5);
            this.tabItem.Controls.Add(this.tbIReceiver);
            this.tabItem.Location = new System.Drawing.Point(4, 22);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabItem.Size = new System.Drawing.Size(463, 122);
            this.tabItem.TabIndex = 1;
            this.tabItem.Text = "Hàng";
            this.tabItem.UseVisualStyleBackColor = true;
            // 
            // btnIAdd
            // 
            this.btnIAdd.Location = new System.Drawing.Point(9, 93);
            this.btnIAdd.Name = "btnIAdd";
            this.btnIAdd.Size = new System.Drawing.Size(75, 23);
            this.btnIAdd.TabIndex = 7;
            this.btnIAdd.Text = "Thêm mới";
            this.btnIAdd.UseVisualStyleBackColor = true;
            this.btnIAdd.Click += new System.EventHandler(this.btnIAdd_Click);
            // 
            // tbIWeight
            // 
            this.tbIWeight.Location = new System.Drawing.Point(115, 58);
            this.tbIWeight.Name = "tbIWeight";
            this.tbIWeight.Size = new System.Drawing.Size(245, 20);
            this.tbIWeight.TabIndex = 13;
            // 
            // btnIDelete
            // 
            this.btnIDelete.Location = new System.Drawing.Point(171, 93);
            this.btnIDelete.Name = "btnIDelete";
            this.btnIDelete.Size = new System.Drawing.Size(75, 23);
            this.btnIDelete.TabIndex = 9;
            this.btnIDelete.Text = "Xóa";
            this.btnIDelete.UseVisualStyleBackColor = true;
            this.btnIDelete.Click += new System.EventHandler(this.btnIDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Trọng lượng";
            // 
            // btnIEdit
            // 
            this.btnIEdit.Location = new System.Drawing.Point(90, 93);
            this.btnIEdit.Name = "btnIEdit";
            this.btnIEdit.Size = new System.Drawing.Size(75, 23);
            this.btnIEdit.TabIndex = 8;
            this.btnIEdit.Text = "Sửa";
            this.btnIEdit.UseVisualStyleBackColor = true;
            this.btnIEdit.Click += new System.EventHandler(this.btnIEdit_Click);
            // 
            // tbIToAddress
            // 
            this.tbIToAddress.Location = new System.Drawing.Point(115, 32);
            this.tbIToAddress.Name = "tbIToAddress";
            this.tbIToAddress.Size = new System.Drawing.Size(245, 20);
            this.tbIToAddress.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Địa chỉ nhận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Người nhận";
            // 
            // tbIReceiver
            // 
            this.tbIReceiver.Location = new System.Drawing.Point(115, 6);
            this.tbIReceiver.Name = "tbIReceiver";
            this.tbIReceiver.Size = new System.Drawing.Size(245, 20);
            this.tbIReceiver.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 192);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(661, 246);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(12, 166);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(196, 20);
            this.tbSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(214, 164);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabMail.ResumeLayout(false);
            this.tabMail.PerformLayout();
            this.tabItem.ResumeLayout(false);
            this.tabItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMail;
        private System.Windows.Forms.TabPage tabItem;
        private System.Windows.Forms.ComboBox cbbMType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMToAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMReceiver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox tbIWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIToAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIReceiver;
        private System.Windows.Forms.Button btnIAdd;
        private System.Windows.Forms.Button btnIDelete;
        private System.Windows.Forms.Button btnIEdit;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMAdd;
        private System.Windows.Forms.Button btnMDelete;
        private System.Windows.Forms.Button btnMEdit;
    }
}

