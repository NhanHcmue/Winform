namespace WindowsFormsApp1
{
    partial class DangNhap
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
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_login = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tb_matkhau = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cb_hienthimatkhau = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.tb_taikhoan = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.tb_matkhau);
            this.panel1.Controls.Add(this.cb_hienthimatkhau);
            this.panel1.Controls.Add(this.tb_taikhoan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 538);
            this.panel1.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(102, 391);
            this.btn_login.Name = "btn_login";
            this.btn_login.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_login.Size = new System.Drawing.Size(153, 70);
            this.btn_login.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_login.StateCommon.Border.Rounding = 30;
            this.btn_login.StateCommon.Border.Width = 1;
            this.btn_login.TabIndex = 6;
            this.btn_login.Values.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(39, 247);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.PasswordChar = '●';
            this.tb_matkhau.Size = new System.Drawing.Size(300, 44);
            this.tb_matkhau.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tb_matkhau.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tb_matkhau.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.tb_matkhau.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_matkhau.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tb_matkhau.StateCommon.Border.Rounding = 20;
            this.tb_matkhau.StateCommon.Border.Width = 1;
            this.tb_matkhau.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.tb_matkhau.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_matkhau.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tb_matkhau.TabIndex = 5;
            this.tb_matkhau.Text = "Password";
            this.tb_matkhau.Enter += new System.EventHandler(this.tb_matkhau_Enter);
            this.tb_matkhau.Leave += new System.EventHandler(this.tb_matkhau_Leave);
            // 
            // cb_hienthimatkhau
            // 
            this.cb_hienthimatkhau.Location = new System.Drawing.Point(102, 324);
            this.cb_hienthimatkhau.Name = "cb_hienthimatkhau";
            this.cb_hienthimatkhau.Size = new System.Drawing.Size(171, 29);
            this.cb_hienthimatkhau.TabIndex = 4;
            this.cb_hienthimatkhau.Values.Text = "Hiển thị mật khẩu";
            this.cb_hienthimatkhau.CheckedChanged += new System.EventHandler(this.cb_hienthimatkhau_CheckedChanged);
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.Location = new System.Drawing.Point(39, 173);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.Size = new System.Drawing.Size(300, 44);
            this.tb_taikhoan.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tb_taikhoan.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.tb_taikhoan.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.tb_taikhoan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_taikhoan.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tb_taikhoan.StateCommon.Border.Rounding = 20;
            this.tb_taikhoan.StateCommon.Border.Width = 1;
            this.tb_taikhoan.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.tb_taikhoan.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_taikhoan.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tb_taikhoan.TabIndex = 1;
            this.tb_taikhoan.Text = "User Name";
            this.tb_taikhoan.UseMnemonic = false;
            this.tb_taikhoan.TextChanged += new System.EventHandler(this.tb_taikhoan_TextChanged);
            this.tb_taikhoan.Enter += new System.EventHandler(this.kryptonTextBox1_Enter);
            this.tb_taikhoan.Leave += new System.EventHandler(this.kryptonTextBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(898, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bg_dangnhap;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 629);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhap";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 15;
            this.StateActive.Border.Width = 1;
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 12;
            this.StateCommon.Border.Width = 0;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Border.Rounding = 12;
            this.StateCommon.Header.Border.Width = 0;
            this.Text = "DangNhap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_taikhoan;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox cb_hienthimatkhau;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_matkhau;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}