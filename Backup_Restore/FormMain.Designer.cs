namespace Backup_Restore
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnNangcao = new DevExpress.XtraBars.BarCheckItem();
            this.btnNewdevice = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteOne = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteO = new DevExpress.XtraBars.BarButtonItem();
            this.Delete1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dS = new Backup_Restore.DS();
            this.bdsDatabases = new System.Windows.Forms.BindingSource(this.components);
            this.databasesTableAdapter = new Backup_Restore.DSTableAdapters.databasesTableAdapter();
            this.tableAdapterManager = new Backup_Restore.DSTableAdapters.TableAdapterManager();
            this.gcDatabases = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatabase_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsST_STT_BACKUP = new System.Windows.Forms.BindingSource(this.components);
            this.sT_STT_BACKUPTableAdapter = new Backup_Restore.DSTableAdapters.ST_STT_BACKUPTableAdapter();
            this.gcST_STT_BACKUP = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtthongbao = new System.Windows.Forms.Label();
            this.timeStop = new DevExpress.XtraEditors.TimeEdit();
            this.dateStop = new DevExpress.XtraEditors.DateEdit();
            this.chkInit = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtbansaoluu = new System.Windows.Forms.Label();
            this.bdsDevice = new System.Windows.Forms.BindingSource(this.components);
            this.backup_devicesTableAdapter = new Backup_Restore.DSTableAdapters.backup_devicesTableAdapter();
            this.dBNAMEToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtTenDB = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsST_STT_BACKUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcST_STT_BACKUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeStop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDevice)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSave,
            this.btnRestore,
            this.btnNangcao,
            this.btnNewdevice,
            this.btnClose,
            this.btnDeleteOne,
            this.btnDeleteO,
            this.Delete1,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRestore, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNangcao, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNewdevice, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteOne),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteO),
            new DevExpress.XtraBars.LinkPersistInfo(this.Delete1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 423;
            this.bar1.Text = "Tools";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Sao lưu";
            this.btnSave.Id = 0;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Phục hồi";
            this.btnRestore.Id = 1;
            this.btnRestore.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRestore.ImageOptions.SvgImage")));
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Làm Tươi";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // btnNangcao
            // 
            this.btnNangcao.Caption = "Tham số phục hồi theo thời gian";
            this.btnNangcao.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.btnNangcao.Id = 2;
            this.btnNangcao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNangcao.ImageOptions.SvgImage")));
            this.btnNangcao.Name = "btnNangcao";
            this.btnNangcao.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNangcao_CheckedChanged);
            // 
            // btnNewdevice
            // 
            this.btnNewdevice.Caption = "Tạo device sao lưu";
            this.btnNewdevice.Id = 3;
            this.btnNewdevice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewdevice.ImageOptions.Image")));
            this.btnNewdevice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNewdevice.ImageOptions.LargeImage")));
            this.btnNewdevice.Name = "btnNewdevice";
            this.btnNewdevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewdevice_ItemClick);
            // 
            // btnDeleteOne
            // 
            this.btnDeleteOne.Id = 6;
            this.btnDeleteOne.Name = "btnDeleteOne";
            // 
            // btnDeleteO
            // 
            this.btnDeleteO.Caption = "Xóa Đĩa";
            this.btnDeleteO.Hint = "Xóa";
            this.btnDeleteO.Id = 7;
            this.btnDeleteO.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteO.ImageOptions.SvgImage")));
            this.btnDeleteO.Name = "btnDeleteO";
            this.btnDeleteO.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDeleteO.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteO_ItemClick);
            // 
            // Delete1
            // 
            this.Delete1.Caption = "Xóa 1 Bản";
            this.Delete1.Id = 8;
            this.Delete1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Delete1.ImageOptions.SvgImage")));
            this.Delete1.Name = "Delete1";
            this.Delete1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.Delete1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Thoát";
            this.btnClose.Id = 4;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.LargeImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1438, 35);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 742);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1438, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 35);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 707);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1438, 35);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 707);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDatabases
            // 
            this.bdsDatabases.DataMember = "databases";
            this.bdsDatabases.DataSource = this.dS;
            // 
            // databasesTableAdapter
            // 
            this.databasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Backup_Restore.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcDatabases
            // 
            this.gcDatabases.DataSource = this.bdsDatabases;
            this.gcDatabases.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcDatabases.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcDatabases.Location = new System.Drawing.Point(0, 35);
            this.gcDatabases.MainView = this.gvData;
            this.gcDatabases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcDatabases.MenuManager = this.barManager1;
            this.gcDatabases.Name = "gcDatabases";
            this.gcDatabases.Size = new System.Drawing.Size(308, 707);
            this.gcDatabases.TabIndex = 5;
            this.gcDatabases.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            this.gcDatabases.Click += new System.EventHandler(this.gcDatabases_Click);
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.coldatabase_id});
            this.gvData.DetailHeight = 284;
            this.gvData.GridControl = this.gcDatabases;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.ReadOnly = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // colname
            // 
            this.colname.Caption = "Cơ sở dữ liệu";
            this.colname.FieldName = "name";
            this.colname.MinWidth = 21;
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.OptionsColumn.ReadOnly = true;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 81;
            // 
            // coldatabase_id
            // 
            this.coldatabase_id.FieldName = "database_id";
            this.coldatabase_id.MinWidth = 21;
            this.coldatabase_id.Name = "coldatabase_id";
            this.coldatabase_id.Width = 81;
            // 
            // bdsST_STT_BACKUP
            // 
            this.bdsST_STT_BACKUP.DataMember = "ST_STT_BACKUP";
            this.bdsST_STT_BACKUP.DataSource = this.dS;
            // 
            // sT_STT_BACKUPTableAdapter
            // 
            this.sT_STT_BACKUPTableAdapter.ClearBeforeFill = true;
            // 
            // gcST_STT_BACKUP
            // 
            this.gcST_STT_BACKUP.DataSource = this.bdsST_STT_BACKUP;
            this.gcST_STT_BACKUP.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcST_STT_BACKUP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcST_STT_BACKUP.Location = new System.Drawing.Point(308, 61);
            this.gcST_STT_BACKUP.MainView = this.gridView2;
            this.gcST_STT_BACKUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcST_STT_BACKUP.MenuManager = this.barManager1;
            this.gcST_STT_BACKUP.Name = "gcST_STT_BACKUP";
            this.gcST_STT_BACKUP.Size = new System.Drawing.Size(1130, 522);
            this.gcST_STT_BACKUP.TabIndex = 12;
            this.gcST_STT_BACKUP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gcST_STT_BACKUP.Click += new System.EventHandler(this.gcST_STT_BACKUP_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.colname1,
            this.colbackup_start_date,
            this.coluser_name});
            this.gridView2.DetailHeight = 284;
            this.gridView2.GridControl = this.gcST_STT_BACKUP;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colposition
            // 
            this.colposition.Caption = "Bản sao lưu thứ";
            this.colposition.FieldName = "position";
            this.colposition.MinWidth = 21;
            this.colposition.Name = "colposition";
            this.colposition.OptionsColumn.AllowEdit = false;
            this.colposition.OptionsColumn.ReadOnly = true;
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 0;
            this.colposition.Width = 81;
            // 
            // colname1
            // 
            this.colname1.Caption = "Tên bản sao lưu";
            this.colname1.FieldName = "name";
            this.colname1.MinWidth = 21;
            this.colname1.Name = "colname1";
            this.colname1.OptionsColumn.ReadOnly = true;
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 1;
            this.colname1.Width = 81;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.Caption = "Ngày sao lưu";
            this.colbackup_start_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colbackup_start_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.MinWidth = 21;
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.OptionsColumn.ReadOnly = true;
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 2;
            this.colbackup_start_date.Width = 81;
            // 
            // coluser_name
            // 
            this.coluser_name.Caption = "Tài khoản sao lưu";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.MinWidth = 21;
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.OptionsColumn.ReadOnly = true;
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 3;
            this.coluser_name.Width = 81;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtthongbao);
            this.groupBox1.Controls.Add(this.timeStop);
            this.groupBox1.Controls.Add(this.dateStop);
            this.groupBox1.Controls.Add(this.chkInit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(308, 583);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1130, 159);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // txtthongbao
            // 
            this.txtthongbao.AutoSize = true;
            this.txtthongbao.Location = new System.Drawing.Point(293, 120);
            this.txtthongbao.Name = "txtthongbao";
            this.txtthongbao.Size = new System.Drawing.Size(592, 13);
            this.txtthongbao.TabIndex = 7;
            this.txtthongbao.Text = "Hướng dân: Ngày giờ ta nhập vào là thời điểm ta muốn phục hồi cơ sở dữ liệu. Thời" +
    " gian phải lớn hơn bản backup cuối cùng";
            // 
            // timeStop
            // 
            this.timeStop.EditValue = new System.DateTime(2020, 4, 30, 0, 0, 0, 0);
            this.timeStop.Location = new System.Drawing.Point(751, 44);
            this.timeStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeStop.MenuManager = this.barManager1;
            this.timeStop.Name = "timeStop";
            this.timeStop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeStop.Size = new System.Drawing.Size(107, 20);
            this.timeStop.TabIndex = 6;
            // 
            // dateStop
            // 
            this.dateStop.EditValue = null;
            this.dateStop.Location = new System.Drawing.Point(575, 47);
            this.dateStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateStop.MenuManager = this.barManager1;
            this.dateStop.Name = "dateStop";
            this.dateStop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStop.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStop.Size = new System.Drawing.Size(107, 20);
            this.dateStop.TabIndex = 5;
            // 
            // chkInit
            // 
            this.chkInit.AutoSize = true;
            this.chkInit.Location = new System.Drawing.Point(425, 4);
            this.chkInit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkInit.Name = "chkInit";
            this.chkInit.Size = new System.Drawing.Size(338, 17);
            this.chkInit.TabIndex = 2;
            this.chkInit.Text = "Xóa tất cả các bản sao lưu cũ trong File trước khi sao lưu bản mới";
            this.chkInit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày giờ để phục hồi đến thời điểm đó";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtbansaoluu
            // 
            this.txtbansaoluu.AutoSize = true;
            this.txtbansaoluu.Location = new System.Drawing.Point(521, 61);
            this.txtbansaoluu.Name = "txtbansaoluu";
            this.txtbansaoluu.Size = new System.Drawing.Size(0, 13);
            this.txtbansaoluu.TabIndex = 8;
            this.txtbansaoluu.Visible = false;
            // 
            // bdsDevice
            // 
            this.bdsDevice.DataMember = "backup_devices";
            this.bdsDevice.DataSource = this.dS;
            // 
            // backup_devicesTableAdapter
            // 
            this.backup_devicesTableAdapter.ClearBeforeFill = true;
            // 
            // dBNAMEToolStripLabel
            // 
            this.dBNAMEToolStripLabel.Name = "dBNAMEToolStripLabel";
            this.dBNAMEToolStripLabel.Size = new System.Drawing.Size(114, 23);
            this.dBNAMEToolStripLabel.Text = "Tên cơ sở dữ liệu:";
            // 
            // txtTenDB
            // 
            this.txtTenDB.Font = new System.Drawing.Font("Segoe UI", 9.163636F);
            this.txtTenDB.Name = "txtTenDB";
            this.txtTenDB.Size = new System.Drawing.Size(140, 26);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 23);
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBNAMEToolStripLabel,
            this.txtTenDB,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(308, 35);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1130, 26);
            this.fillToolStrip.TabIndex = 12;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 765);
            this.Controls.Add(this.txtbansaoluu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcST_STT_BACKUP);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.gcDatabases);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Backup And Restore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatabases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatabases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsST_STT_BACKUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcST_STT_BACKUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeStop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDevice)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarCheckItem btnNangcao;
        private DevExpress.XtraBars.BarButtonItem btnNewdevice;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private System.Windows.Forms.BindingSource bdsDatabases;
        private DS dS;
        private DSTableAdapters.databasesTableAdapter databasesTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcDatabases;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn coldatabase_id;
        private System.Windows.Forms.BindingSource bdsST_STT_BACKUP;
        private DSTableAdapters.ST_STT_BACKUPTableAdapter sT_STT_BACKUPTableAdapter;
        private DevExpress.XtraGrid.GridControl gcST_STT_BACKUP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkInit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.DateEdit dateStop;
        private DevExpress.XtraEditors.TimeEdit timeStop;
        private System.Windows.Forms.Label txtthongbao;
        private System.Windows.Forms.Label txtbansaoluu;
        private System.Windows.Forms.BindingSource bdsDevice;
        private DSTableAdapters.backup_devicesTableAdapter backup_devicesTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnDeleteOne;
        private DevExpress.XtraBars.BarButtonItem btnDeleteO;
        private DevExpress.XtraBars.BarButtonItem Delete1;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel dBNAMEToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox txtTenDB;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}