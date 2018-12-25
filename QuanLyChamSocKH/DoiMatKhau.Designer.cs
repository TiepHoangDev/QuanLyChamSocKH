namespace QuanLyChamSocKH
{
    partial class DoiMatKhau
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
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabItem6 = new DevComponents.DotNetBar.TabItem(this.components);
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.txtMatkhaumoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhaplaimatkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.ForeColor = System.Drawing.Color.Blue;
            this.tabControl1.Location = new System.Drawing.Point(4, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(997, 286);
            this.tabControl1.TabIndex = 110;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem6);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.txtNhaplaimatkhau);
            this.tabControlPanel2.Controls.Add(this.label3);
            this.tabControlPanel2.Controls.Add(this.txtMatkhaumoi);
            this.tabControlPanel2.Controls.Add(this.label1);
            this.tabControlPanel2.Controls.Add(this.txtMatkhau);
            this.tabControlPanel2.Controls.Add(this.label2);
            this.tabControlPanel2.Controls.Add(this.txtUsername);
            this.tabControlPanel2.Controls.Add(this.label9);
            this.tabControlPanel2.Controls.Add(this.btnSua);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(997, 260);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem6;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMatkhau.Location = new System.Drawing.Point(388, 69);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(134, 20);
            this.txtMatkhau.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Location = new System.Drawing.Point(264, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 103;
            this.label2.Text = "Mật Khẩu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.Location = new System.Drawing.Point(388, 21);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(134, 20);
            this.txtUsername.TabIndex = 104;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.Location = new System.Drawing.Point(264, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 101;
            this.label9.Text = "Username";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabItem6
            // 
            this.tabItem6.AttachedControl = this.tabControlPanel2;
            this.tabItem6.Name = "tabItem6";
            this.tabItem6.Text = "Đổi Mật Khẩu";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.ForeColor = System.Drawing.Color.Snow;
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(4, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new System.Drawing.Size(997, 48);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 108;
            this.ribbonControl1.Text = "Thông Tin";
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Image = global::QuanLyChamSocKH.Properties.Resources.check;
            this.btnSua.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnSua.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnSua.Location = new System.Drawing.Point(311, 198);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(164, 29);
            this.btnSua.TabIndex = 70;
            this.btnSua.Text = "Đổi Mật Khẩu";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.Image = global::QuanLyChamSocKH.Properties.Resources.stop_alt;
            this.btnThoat.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnThoat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnThoat.Location = new System.Drawing.Point(4, 341);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(997, 29);
            this.btnThoat.TabIndex = 109;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMatkhaumoi.Location = new System.Drawing.Point(388, 111);
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.PasswordChar = '*';
            this.txtMatkhaumoi.Size = new System.Drawing.Size(134, 20);
            this.txtMatkhaumoi.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Location = new System.Drawing.Point(264, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 111;
            this.label1.Text = "Mật Khẩu Mới";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNhaplaimatkhau
            // 
            this.txtNhaplaimatkhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhaplaimatkhau.Location = new System.Drawing.Point(388, 153);
            this.txtNhaplaimatkhau.Name = "txtNhaplaimatkhau";
            this.txtNhaplaimatkhau.PasswordChar = '*';
            this.txtNhaplaimatkhau.Size = new System.Drawing.Size(134, 20);
            this.txtNhaplaimatkhau.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Location = new System.Drawing.Point(264, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 113;
            this.label3.Text = "Nhập Lại Mật Khẩu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1005, 372);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.btnThoat);
            this.Name = "DoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.tabControlPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label9;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.TabItem tabItem6;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private System.Windows.Forms.TextBox txtNhaplaimatkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatkhaumoi;
        private System.Windows.Forms.Label label1;
    }
}