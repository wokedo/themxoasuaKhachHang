namespace DXApplication1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gcKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gvKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPipelineId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemPhanLoai = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gcPhanLoai = new DevExpress.XtraGrid.GridControl();
            this.campaignTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DXApplication1.DataSet1();
            this.gvPhanLoai = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_PipelineId = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_AccountId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Phone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Uid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ID = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.campaignTypeTableAdapter = new DXApplication1.DataSet1TableAdapters.CampaignTypeTableAdapter();
            this.contactTableAdapter = new DXApplication1.DataSet1TableAdapters.ContactTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhanLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campaignTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PipelineId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AccountId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Uid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btn_ThemPhanLoai);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Location = new System.Drawing.Point(14, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 632);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gcKhachHang);
            this.groupBox3.Controls.Add(this.simpleButton5);
            this.groupBox3.Controls.Add(this.simpleButton6);
            this.groupBox3.Controls.Add(this.simpleButton4);
            this.groupBox3.Location = new System.Drawing.Point(7, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(628, 314);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // gcKhachHang
            // 
            this.gcKhachHang.Location = new System.Drawing.Point(7, 66);
            this.gcKhachHang.MainView = this.gvKhachHang;
            this.gcKhachHang.Name = "gcKhachHang";
            this.gcKhachHang.Size = new System.Drawing.Size(615, 242);
            this.gcKhachHang.TabIndex = 7;
            this.gcKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhachHang});
            this.gcKhachHang.Click += new System.EventHandler(this.gcKhachHang_Click);
            // 
            // gvKhachHang
            // 
            this.gvKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colName1,
            this.colUid,
            this.colPhone,
            this.colEmail,
            this.colAccountId,
            this.colPipelineId});
            this.gvKhachHang.GridControl = this.gcKhachHang;
            this.gvKhachHang.Name = "gvKhachHang";
            this.gvKhachHang.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvKhachHang.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvKhachHang.OptionsCustomization.AllowColumnMoving = false;
            this.gvKhachHang.OptionsCustomization.AllowColumnResizing = false;
            this.gvKhachHang.OptionsCustomization.AllowFilter = false;
            this.gvKhachHang.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvKhachHang.OptionsView.ColumnAutoWidth = false;
            this.gvKhachHang.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvKhachHang.OptionsView.ShowGroupPanel = false;
            this.gvKhachHang.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvKhachHang_RowUpdated);
            // 
            // colId1
            // 
            this.colId1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colId1.AppearanceHeader.Options.UseFont = true;
            this.colId1.AppearanceHeader.Options.UseTextOptions = true;
            this.colId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            this.colId1.Visible = true;
            this.colId1.VisibleIndex = 0;
            this.colId1.Width = 50;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 1;
            // 
            // colUid
            // 
            this.colUid.FieldName = "Uid";
            this.colUid.Name = "colUid";
            this.colUid.Visible = true;
            this.colUid.VisibleIndex = 2;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            // 
            // colAccountId
            // 
            this.colAccountId.FieldName = "AccountId";
            this.colAccountId.Name = "colAccountId";
            this.colAccountId.Visible = true;
            this.colAccountId.VisibleIndex = 5;
            // 
            // colPipelineId
            // 
            this.colPipelineId.FieldName = "PipelineId";
            this.colPipelineId.Name = "colPipelineId";
            this.colPipelineId.Visible = true;
            this.colPipelineId.VisibleIndex = 6;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.simpleButton5.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseForeColor = true;
            this.simpleButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton5.Location = new System.Drawing.Point(7, 33);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(58, 27);
            this.simpleButton5.TabIndex = 6;
            this.simpleButton5.Text = "Thêm";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.simpleButton6.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton6.Appearance.Options.UseBackColor = true;
            this.simpleButton6.Appearance.Options.UseForeColor = true;
            this.simpleButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.simpleButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton6.Location = new System.Drawing.Point(72, 33);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(58, 27);
            this.simpleButton6.TabIndex = 5;
            this.simpleButton6.Text = "Xóa";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.simpleButton4.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseForeColor = true;
            this.simpleButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton4.Location = new System.Drawing.Point(7, 0);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(87, 27);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Khách Hàng";
            // 
            // btn_ThemPhanLoai
            // 
            this.btn_ThemPhanLoai.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ThemPhanLoai.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_ThemPhanLoai.Appearance.Options.UseBackColor = true;
            this.btn_ThemPhanLoai.Appearance.Options.UseForeColor = true;
            this.btn_ThemPhanLoai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ThemPhanLoai.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_ThemPhanLoai.Location = new System.Drawing.Point(7, 46);
            this.btn_ThemPhanLoai.Name = "btn_ThemPhanLoai";
            this.btn_ThemPhanLoai.Size = new System.Drawing.Size(126, 32);
            this.btn_ThemPhanLoai.TabIndex = 2;
            this.btn_ThemPhanLoai.Text = "Thêm Phân Loại";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gcPhanLoai);
            this.groupBox2.Controls.Add(this.simpleButton3);
            this.groupBox2.Location = new System.Drawing.Point(7, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // gcPhanLoai
            // 
            this.gcPhanLoai.DataSource = this.campaignTypeBindingSource;
            this.gcPhanLoai.Location = new System.Drawing.Point(7, 33);
            this.gcPhanLoai.MainView = this.gvPhanLoai;
            this.gcPhanLoai.Name = "gcPhanLoai";
            this.gcPhanLoai.Size = new System.Drawing.Size(615, 155);
            this.gcPhanLoai.TabIndex = 4;
            this.gcPhanLoai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhanLoai});
            // 
            // campaignTypeBindingSource
            // 
            this.campaignTypeBindingSource.DataMember = "CampaignType";
            this.campaignTypeBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvPhanLoai
            // 
            this.gvPhanLoai.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName});
            this.gvPhanLoai.GridControl = this.gcPhanLoai;
            this.gvPhanLoai.Name = "gvPhanLoai";
            this.gvPhanLoai.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvPhanLoai.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvPhanLoai.OptionsCustomization.AllowColumnMoving = false;
            this.gvPhanLoai.OptionsCustomization.AllowColumnResizing = false;
            this.gvPhanLoai.OptionsCustomization.AllowFilter = false;
            this.gvPhanLoai.OptionsCustomization.AllowSort = false;
            this.gvPhanLoai.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvPhanLoai.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvPhanLoai.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton3.Location = new System.Drawing.Point(7, 0);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(87, 27);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Phân Loại";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.Location = new System.Drawing.Point(7, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 27);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Group";
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "Contact";
            this.contactBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelControl7);
            this.groupBox4.Controls.Add(this.txt_PipelineId);
            this.groupBox4.Controls.Add(this.labelControl6);
            this.groupBox4.Controls.Add(this.txt_AccountId);
            this.groupBox4.Controls.Add(this.labelControl5);
            this.groupBox4.Controls.Add(this.txt_Email);
            this.groupBox4.Controls.Add(this.labelControl4);
            this.groupBox4.Controls.Add(this.txt_Phone);
            this.groupBox4.Controls.Add(this.labelControl3);
            this.groupBox4.Controls.Add(this.txt_Uid);
            this.groupBox4.Controls.Add(this.labelControl2);
            this.groupBox4.Controls.Add(this.txt_Name);
            this.groupBox4.Controls.Add(this.labelControl1);
            this.groupBox4.Controls.Add(this.txt_ID);
            this.groupBox4.Controls.Add(this.simpleButton8);
            this.groupBox4.Controls.Add(this.simpleButton7);
            this.groupBox4.Location = new System.Drawing.Point(661, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 299);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(21, 217);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Pipeline Id";
            // 
            // txt_PipelineId
            // 
            this.txt_PipelineId.Location = new System.Drawing.Point(119, 214);
            this.txt_PipelineId.MenuManager = this.barManager1;
            this.txt_PipelineId.Name = "txt_PipelineId";
            this.txt_PipelineId.Size = new System.Drawing.Size(137, 20);
            this.txt_PipelineId.TabIndex = 17;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 0;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(982, 49);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 693);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(982, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 644);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(982, 49);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 644);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(21, 191);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 13);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Account Id";
            // 
            // txt_AccountId
            // 
            this.txt_AccountId.Location = new System.Drawing.Point(119, 188);
            this.txt_AccountId.MenuManager = this.barManager1;
            this.txt_AccountId.Name = "txt_AccountId";
            this.txt_AccountId.Size = new System.Drawing.Size(137, 20);
            this.txt_AccountId.TabIndex = 15;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 165);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(119, 162);
            this.txt_Email.MenuManager = this.barManager1;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(137, 20);
            this.txt_Email.TabIndex = 13;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 139);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Phone";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(119, 136);
            this.txt_Phone.MenuManager = this.barManager1;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(137, 20);
            this.txt_Phone.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(15, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Uid";
            // 
            // txt_Uid
            // 
            this.txt_Uid.Location = new System.Drawing.Point(119, 110);
            this.txt_Uid.MenuManager = this.barManager1;
            this.txt_Uid.Name = "txt_Uid";
            this.txt_Uid.Size = new System.Drawing.Size(137, 20);
            this.txt_Uid.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(119, 84);
            this.txt_Name.MenuManager = this.barManager1;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(137, 20);
            this.txt_Name.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(119, 58);
            this.txt_ID.MenuManager = this.barManager1;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(137, 20);
            this.txt_ID.TabIndex = 5;
            // 
            // simpleButton8
            // 
            this.simpleButton8.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.simpleButton8.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton8.Appearance.Options.UseBackColor = true;
            this.simpleButton8.Appearance.Options.UseForeColor = true;
            this.simpleButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.simpleButton8.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton8.Location = new System.Drawing.Point(229, 266);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(78, 27);
            this.simpleButton8.TabIndex = 4;
            this.simpleButton8.Text = "Lưu";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.simpleButton7.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton7.Appearance.Options.UseBackColor = true;
            this.simpleButton7.Appearance.Options.UseForeColor = true;
            this.simpleButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.simpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton7.Location = new System.Drawing.Point(7, 0);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(87, 27);
            this.simpleButton7.TabIndex = 3;
            this.simpleButton7.Text = "Show Form";
            // 
            // campaignTypeTableAdapter
            // 
            this.campaignTypeTableAdapter.ClearBeforeFill = true;
            // 
            // contactTableAdapter
            // 
            this.contactTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 716);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhanLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campaignTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PipelineId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AccountId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Uid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gcKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhachHang;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton btn_ThemPhanLoai;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gcPhanLoai;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhanLoai;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource campaignTypeBindingSource;
        private DataSet1TableAdapters.CampaignTypeTableAdapter campaignTypeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private DataSet1TableAdapters.ContactTableAdapter contactTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colUid;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn colPipelineId;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_PipelineId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_AccountId;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_Email;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Phone;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Uid;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_ID;




    }
}

