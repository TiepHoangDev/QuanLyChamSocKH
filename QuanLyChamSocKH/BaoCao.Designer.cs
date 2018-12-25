namespace QuanLyChamSocKH
{
    partial class BaoCao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBaocao = new DevComponents.DotNetBar.ButtonX();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.label2 = new System.Windows.Forms.Label();
            this.datedenngay = new System.Windows.Forms.DateTimePicker();
            this.datetungay = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datedenngay1 = new System.Windows.Forms.DateTimePicker();
            this.datetungay1 = new System.Windows.Forms.DateTimePicker();
            this.btnBaocao1 = new DevComponents.DotNetBar.ButtonX();
            this.DanhGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new QuanLyChamSocKH.DataSet1();
            this.HoTroYCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoTroYCTableAdapter = new QuanLyChamSocKH.DataSet1TableAdapters.HoTroYCTableAdapter();
            this.DanhGiaTableAdapter = new QuanLyChamSocKH.DataSet1TableAdapters.DanhGiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DanhGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoTroYCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.Image = global::QuanLyChamSocKH.Properties.Resources.stop_alt;
            this.btnThoat.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnThoat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnThoat.Location = new System.Drawing.Point(4, 349);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(654, 29);
            this.btnThoat.TabIndex = 59;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Location = new System.Drawing.Point(4, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 294);
            this.tabControl1.TabIndex = 58;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlPanel1.Controls.Add(this.label2);
            this.tabControlPanel1.Controls.Add(this.datedenngay);
            this.tabControlPanel1.Controls.Add(this.datetungay);
            this.tabControlPanel1.Controls.Add(this.label17);
            this.tabControlPanel1.Controls.Add(this.reportViewer1);
            this.tabControlPanel1.Controls.Add(this.btnBaocao);
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(654, 268);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 4;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoTroYCBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyChamSocKH.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 145);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(650, 85);
            this.reportViewer1.TabIndex = 109;
            // 
            // btnBaocao
            // 
            this.btnBaocao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBaocao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBaocao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBaocao.Image = global::QuanLyChamSocKH.Properties.Resources.Calendar2;
            this.btnBaocao.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnBaocao.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnBaocao.Location = new System.Drawing.Point(194, 110);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(185, 29);
            this.btnBaocao.TabIndex = 104;
            this.btnBaocao.Text = "Báo Cáo Hỗ Trợ";
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Báo Cáo Hỗ Trợ";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.btnBaocao1);
            this.tabControlPanel2.Controls.Add(this.label1);
            this.tabControlPanel2.Controls.Add(this.label3);
            this.tabControlPanel2.Controls.Add(this.datedenngay1);
            this.tabControlPanel2.Controls.Add(this.datetungay1);
            this.tabControlPanel2.Controls.Add(this.reportViewer2);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(654, 268);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "Báo Cáo Đánh Giá";
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
            this.ribbonControl1.Size = new System.Drawing.Size(654, 48);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 57;
            this.ribbonControl1.Text = "Thông Tin";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(129, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 114;
            this.label2.Text = "Đến Ngày";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datedenngay
            // 
            this.datedenngay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datedenngay.CustomFormat = "";
            this.datedenngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datedenngay.Location = new System.Drawing.Point(298, 73);
            this.datedenngay.Name = "datedenngay";
            this.datedenngay.Size = new System.Drawing.Size(162, 20);
            this.datedenngay.TabIndex = 113;
            // 
            // datetungay
            // 
            this.datetungay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datetungay.CustomFormat = "";
            this.datetungay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetungay.Location = new System.Drawing.Point(298, 18);
            this.datetungay.Name = "datetungay";
            this.datetungay.Size = new System.Drawing.Size(162, 20);
            this.datetungay.TabIndex = 112;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(129, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 23);
            this.label17.TabIndex = 111;
            this.label17.Text = "Từ Ngày";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DanhGiaBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QuanLyChamSocKH.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 158);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(630, 106);
            this.reportViewer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(162, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 117;
            this.label1.Text = "Từ Ngày";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(162, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 116;
            this.label3.Text = "Đến Ngày";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datedenngay1
            // 
            this.datedenngay1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datedenngay1.CustomFormat = "";
            this.datedenngay1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datedenngay1.Location = new System.Drawing.Point(331, 61);
            this.datedenngay1.Name = "datedenngay1";
            this.datedenngay1.Size = new System.Drawing.Size(162, 20);
            this.datedenngay1.TabIndex = 115;
            // 
            // datetungay1
            // 
            this.datetungay1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datetungay1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetungay1.Location = new System.Drawing.Point(331, 14);
            this.datetungay1.Name = "datetungay1";
            this.datetungay1.Size = new System.Drawing.Size(162, 20);
            this.datetungay1.TabIndex = 114;
            // 
            // btnBaocao1
            // 
            this.btnBaocao1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBaocao1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBaocao1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBaocao1.Image = global::QuanLyChamSocKH.Properties.Resources.Calendar2;
            this.btnBaocao1.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnBaocao1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnBaocao1.Location = new System.Drawing.Point(235, 120);
            this.btnBaocao1.Name = "btnBaocao1";
            this.btnBaocao1.Size = new System.Drawing.Size(185, 29);
            this.btnBaocao1.TabIndex = 118;
            this.btnBaocao1.Text = "Báo Cáo  Đánh Giá";
            this.btnBaocao1.Click += new System.EventHandler(this.btnBaocao1_Click);
            // 
            // DanhGiaBindingSource
            // 
            this.DanhGiaBindingSource.DataMember = "DanhGia";
            this.DanhGiaBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HoTroYCBindingSource
            // 
            this.HoTroYCBindingSource.DataMember = "HoTroYC";
            this.HoTroYCBindingSource.DataSource = this.DataSet1;
            // 
            // HoTroYCTableAdapter
            // 
            this.HoTroYCTableAdapter.ClearBeforeFill = true;
            // 
            // DanhGiaTableAdapter
            // 
            this.DanhGiaTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(662, 380);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "BaoCao";
            this.Text = "Thông Tin Báo Cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DanhGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoTroYCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private System.Windows.Forms.BindingSource HoTroYCBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.HoTroYCTableAdapter HoTroYCTableAdapter;
        private System.Windows.Forms.BindingSource DanhGiaBindingSource;
        private DataSet1TableAdapters.DanhGiaTableAdapter DanhGiaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevComponents.DotNetBar.ButtonX btnBaocao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datedenngay;
        private System.Windows.Forms.DateTimePicker datetungay;
        private System.Windows.Forms.Label label17;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datedenngay1;
        private System.Windows.Forms.DateTimePicker datetungay1;
        private DevComponents.DotNetBar.ButtonX btnBaocao1;

    }
}