namespace BaiTapLon_HeQuanTriCSDL
{
    partial class F_QLSACH
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
            this.btn_TruyCap = new System.Windows.Forms.Button();
            this.textBox_TaiKhoan = new System.Windows.Forms.TextBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.label_TaiKhoan = new System.Windows.Forms.Label();
            this.label_MatKhau = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_ThuVienThuyLoi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TruyCap
            // 
            this.btn_TruyCap.Location = new System.Drawing.Point(336, 343);
            this.btn_TruyCap.Name = "btn_TruyCap";
            this.btn_TruyCap.Size = new System.Drawing.Size(305, 54);
            this.btn_TruyCap.TabIndex = 2;
            this.btn_TruyCap.Text = "Truy cập hệ thống";
            this.btn_TruyCap.UseVisualStyleBackColor = true;
            this.btn_TruyCap.Click += new System.EventHandler(this.btn_TruyCap_Click);
            // 
            // textBox_TaiKhoan
            // 
            this.textBox_TaiKhoan.Location = new System.Drawing.Point(253, 41);
            this.textBox_TaiKhoan.Name = "textBox_TaiKhoan";
            this.textBox_TaiKhoan.Size = new System.Drawing.Size(305, 26);
            this.textBox_TaiKhoan.TabIndex = 0;
            this.textBox_TaiKhoan.Text = "admin";
            this.textBox_TaiKhoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(253, 107);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.PasswordChar = '*';
            this.textBox_MatKhau.Size = new System.Drawing.Size(305, 26);
            this.textBox_MatKhau.TabIndex = 1;
            this.textBox_MatKhau.Text = "admin";
            this.textBox_MatKhau.TextChanged += new System.EventHandler(this.textBox_MatKhau_TextChanged);
            // 
            // label_TaiKhoan
            // 
            this.label_TaiKhoan.AutoSize = true;
            this.label_TaiKhoan.Location = new System.Drawing.Point(36, 44);
            this.label_TaiKhoan.Name = "label_TaiKhoan";
            this.label_TaiKhoan.Size = new System.Drawing.Size(158, 20);
            this.label_TaiKhoan.TabIndex = 3;
            this.label_TaiKhoan.Text = "Tài khoản đăng nhập";
            this.label_TaiKhoan.Click += new System.EventHandler(this.label_TaiKhoan_Click);
            // 
            // label_MatKhau
            // 
            this.label_MatKhau.AutoSize = true;
            this.label_MatKhau.Location = new System.Drawing.Point(36, 110);
            this.label_MatKhau.Name = "label_MatKhau";
            this.label_MatKhau.Size = new System.Drawing.Size(75, 20);
            this.label_MatKhau.TabIndex = 4;
            this.label_MatKhau.Text = "Mật khẩu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_MatKhau);
            this.panel1.Controls.Add(this.label_TaiKhoan);
            this.panel1.Controls.Add(this.textBox_MatKhau);
            this.panel1.Controls.Add(this.textBox_TaiKhoan);
            this.panel1.Location = new System.Drawing.Point(83, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 173);
            this.panel1.TabIndex = 5;
            // 
            // label_ThuVienThuyLoi
            // 
            this.label_ThuVienThuyLoi.AutoSize = true;
            this.label_ThuVienThuyLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThuVienThuyLoi.Location = new System.Drawing.Point(112, 38);
            this.label_ThuVienThuyLoi.Name = "label_ThuVienThuyLoi";
            this.label_ThuVienThuyLoi.Size = new System.Drawing.Size(559, 64);
            this.label_ThuVienThuyLoi.TabIndex = 6;
            this.label_ThuVienThuyLoi.Text = "THƯ VIỆN THỦY LỢI";
            // 
            // F_QLSACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_ThuVienThuyLoi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_TruyCap);
            this.Name = "F_QLSACH";
            this.Text = "Trình quản lý thư viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TruyCap;
        private System.Windows.Forms.TextBox textBox_TaiKhoan;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.Label label_TaiKhoan;
        private System.Windows.Forms.Label label_MatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_ThuVienThuyLoi;
    }
}

