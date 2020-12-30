namespace Stack
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
            this.label2 = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.btnHeSo2 = new System.Windows.Forms.Button();
            this.btnHeSo16 = new System.Windows.Forms.Button();
            this.btnHeSo8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Input";
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(157, 26);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(100, 20);
            this.textInput.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Result";
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(558, 29);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(100, 20);
            this.textResult.TabIndex = 12;
            // 
            // btnHeSo2
            // 
            this.btnHeSo2.Location = new System.Drawing.Point(350, 27);
            this.btnHeSo2.Name = "btnHeSo2";
            this.btnHeSo2.Size = new System.Drawing.Size(75, 23);
            this.btnHeSo2.TabIndex = 13;
            this.btnHeSo2.Text = "/2Convert";
            this.btnHeSo2.UseVisualStyleBackColor = true;
            this.btnHeSo2.Click += new System.EventHandler(this.btnHeSo2_Click);
            // 
            // btnHeSo16
            // 
            this.btnHeSo16.Location = new System.Drawing.Point(350, 124);
            this.btnHeSo16.Name = "btnHeSo16";
            this.btnHeSo16.Size = new System.Drawing.Size(75, 23);
            this.btnHeSo16.TabIndex = 14;
            this.btnHeSo16.Text = "/16Convert";
            this.btnHeSo16.UseVisualStyleBackColor = true;
            this.btnHeSo16.Click += new System.EventHandler(this.btnHeSo16_Click);
            // 
            // btnHeSo8
            // 
            this.btnHeSo8.Location = new System.Drawing.Point(350, 72);
            this.btnHeSo8.Name = "btnHeSo8";
            this.btnHeSo8.Size = new System.Drawing.Size(75, 23);
            this.btnHeSo8.TabIndex = 15;
            this.btnHeSo8.Text = "/8Convert";
            this.btnHeSo8.UseVisualStyleBackColor = true;
            this.btnHeSo8.Click += new System.EventHandler(this.btnHeSo8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "/10Convert";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 197);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHeSo8);
            this.Controls.Add(this.btnHeSo16);
            this.Controls.Add(this.btnHeSo2);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button btnHeSo2;
        private System.Windows.Forms.Button btnHeSo16;
        private System.Windows.Forms.Button btnHeSo8;
        private System.Windows.Forms.Button button1;
    }
}

