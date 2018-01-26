namespace TinhTong2PhanSo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhanSo1 = new System.Windows.Forms.TextBox();
            this.txtPhanSo2 = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân Số 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phân Số 2";
            // 
            // txtPhanSo1
            // 
            this.txtPhanSo1.Location = new System.Drawing.Point(107, 42);
            this.txtPhanSo1.Name = "txtPhanSo1";
            this.txtPhanSo1.Size = new System.Drawing.Size(100, 20);
            this.txtPhanSo1.TabIndex = 2;
            // 
            // txtPhanSo2
            // 
            this.txtPhanSo2.Location = new System.Drawing.Point(107, 65);
            this.txtPhanSo2.Name = "txtPhanSo2";
            this.txtPhanSo2.Size = new System.Drawing.Size(100, 20);
            this.txtPhanSo2.TabIndex = 3;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(34, 131);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(173, 23);
            this.btnCong.TabIndex = 4;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(107, 112);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(46, 13);
            this.lblKetQua.TabIndex = 5;
            this.lblKetQua.Text = "Kết Quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 261);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtPhanSo2);
            this.Controls.Add(this.txtPhanSo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhanSo1;
        private System.Windows.Forms.TextBox txtPhanSo2;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Label lblKetQua;
    }
}

