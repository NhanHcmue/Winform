namespace WindowsFormsApp1
{
    partial class TaiKhoan
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
            this.tb_username = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tb_password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dataGridViewTKNhanVien = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTKNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 10;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Rounding = 10;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Width = 1;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.ColorAngle = 45F;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 10;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Width = 0;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(328, 91);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(475, 44);
            this.tb_username.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_username.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tb_username.StateCommon.Border.Rounding = 18;
            this.tb_username.StateCommon.Border.Width = 1;
            this.tb_username.TabIndex = 0;
            this.tb_username.Text = "User Name";
            this.tb_username.Enter += new System.EventHandler(this.tb_username_Enter);
            this.tb_username.Leave += new System.EventHandler(this.tb_username_Leave);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(328, 159);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(475, 44);
            this.tb_password.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_password.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tb_password.StateCommon.Border.Rounding = 18;
            this.tb_password.StateCommon.Border.Width = 1;
            this.tb_password.TabIndex = 1;
            this.tb_password.Text = "Password";
            this.tb_password.Enter += new System.EventHandler(this.tb_password_Enter);
            this.tb_password.Leave += new System.EventHandler(this.tb_password_Leave);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(328, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(366, 57);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Yellow;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Quản Lý Tài Khoản";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(150, 106);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(141, 29);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Tên Đăng Nhập";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(150, 174);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(91, 29);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Mật Khẩu";
            // 
            // dataGridViewTKNhanVien
            // 
            this.dataGridViewTKNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTKNhanVien.ColumnHeadersHeight = 34;
            this.dataGridViewTKNhanVien.Location = new System.Drawing.Point(26, 229);
            this.dataGridViewTKNhanVien.Name = "dataGridViewTKNhanVien";
            this.dataGridViewTKNhanVien.RowHeadersVisible = false;
            this.dataGridViewTKNhanVien.RowHeadersWidth = 62;
            this.dataGridViewTKNhanVien.RowTemplate.Height = 28;
            this.dataGridViewTKNhanVien.Size = new System.Drawing.Size(926, 215);
            this.dataGridViewTKNhanVien.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewTKNhanVien.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataGridViewTKNhanVien.StateCommon.DataCell.Border.Rounding = 15;
            this.dataGridViewTKNhanVien.StateCommon.DataCell.Border.Width = 0;
            this.dataGridViewTKNhanVien.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Cyan;
            this.dataGridViewTKNhanVien.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewTKNhanVien.StateCommon.HeaderColumn.Back.ColorAngle = 45F;
            this.dataGridViewTKNhanVien.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Cyan;
            this.dataGridViewTKNhanVien.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewTKNhanVien.StateCommon.HeaderColumn.Border.ColorAngle = 45F;
            this.dataGridViewTKNhanVien.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataGridViewTKNhanVien.StateCommon.HeaderColumn.Border.Rounding = 0;
            this.dataGridViewTKNhanVien.StateCommon.HeaderColumn.Border.Width = 0;
            this.dataGridViewTKNhanVien.TabIndex = 8;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(196, 468);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton3.Size = new System.Drawing.Size(114, 64);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.Olive;
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kryptonButton3.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton3.StateCommon.Border.Color1 = System.Drawing.Color.Yellow;
            this.kryptonButton3.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kryptonButton3.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton3.StateCommon.Border.Rounding = 20;
            this.kryptonButton3.StateCommon.Border.Width = 1;
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.kryptonButton3.TabIndex = 10;
            this.kryptonButton3.Values.Text = "Sửa";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(426, 468);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton2.Size = new System.Drawing.Size(114, 64);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.Blue;
            this.kryptonButton2.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.kryptonButton2.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.StateCommon.Border.Rounding = 20;
            this.kryptonButton2.StateCommon.Border.Width = 1;
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.kryptonButton2.TabIndex = 12;
            this.kryptonButton2.Values.Text = "Xóa";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(663, 468);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton4.Size = new System.Drawing.Size(114, 64);
            this.kryptonButton4.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.kryptonButton4.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
            this.kryptonButton4.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton4.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.kryptonButton4.StateCommon.Border.Color2 = System.Drawing.Color.DimGray;
            this.kryptonButton4.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton4.StateCommon.Border.Rounding = 20;
            this.kryptonButton4.StateCommon.Border.Width = 1;
            this.kryptonButton4.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.kryptonButton4.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton4.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.kryptonButton4.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StatePressed.Border.Rounding = 20;
            this.kryptonButton4.StatePressed.Border.Width = 1;
            this.kryptonButton4.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonButton4.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonButton4.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.TabIndex = 13;
            this.kryptonButton4.Values.Text = "Thoát";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(829, 120);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(114, 64);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.Lime;
            this.kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.kryptonButton1.TabIndex = 14;
            this.kryptonButton1.Values.Text = "Thêm";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonButton4);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.dataGridViewTKNhanVien);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaiKhoan";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTKNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_username;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_password;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridViewTKNhanVien;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}