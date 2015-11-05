namespace PTHOrder.Forms
{
    partial class frmListSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListSupplier));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.gridItemDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSupplierCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridItem = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportFile = new System.Windows.Forms.ToolStripMenuItem();
            this.waiting = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PTHOrder.frmWaiting), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageSmall;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete});
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnAdd
            // 
            this.btnAdd.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 1;
            this.btnEdit.ImageIndex = 1;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(685, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 364);
            this.barDockControlBottom.Size = new System.Drawing.Size(685, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 364);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(685, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 364);
            // 
            // imageSmall
            // 
            this.imageSmall.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageSmall.ImageStream")));
            this.imageSmall.Images.SetKeyName(0, "Action_LinkUnlink_Link.png");
            this.imageSmall.Images.SetKeyName(1, "Action_Edit.png");
            this.imageSmall.Images.SetKeyName(2, "Action_Delete.png");
            this.imageSmall.Images.SetKeyName(3, "Action_Printing_Print.png");
            // 
            // gridItemDetail
            // 
            this.gridItemDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSupplierCode,
            this.colSupplierName,
            this.colAddress,
            this.colTelephone,
            this.colMail,
            this.colGroup,
            this.colContact,
            this.colNote});
            this.gridItemDetail.CustomizationFormBounds = new System.Drawing.Rectangle(126, 294, 216, 178);
            this.gridItemDetail.GridControl = this.gridItem;
            this.gridItemDetail.IndicatorWidth = 45;
            this.gridItemDetail.Name = "gridItemDetail";
            this.gridItemDetail.OptionsBehavior.Editable = false;
            this.gridItemDetail.OptionsView.ShowGroupPanel = false;
            this.gridItemDetail.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGroup, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridItemDetail.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridItemDetail_CustomDrawRowIndicator);
            this.gridItemDetail.DoubleClick += new System.EventHandler(this.gridItemDetail_DoubleClick);
            // 
            // colSupplierCode
            // 
            this.colSupplierCode.Caption = "Mã Nhà Cung Cấp";
            this.colSupplierCode.FieldName = "SupplierCode";
            this.colSupplierCode.Name = "colSupplierCode";
            this.colSupplierCode.Visible = true;
            this.colSupplierCode.VisibleIndex = 0;
            this.colSupplierCode.Width = 72;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Caption = "Tên Nhà Cung Cấp";
            this.colSupplierName.FieldName = "SupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 1;
            this.colSupplierName.Width = 144;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Địa Chỉ";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            this.colAddress.Width = 161;
            // 
            // colTelephone
            // 
            this.colTelephone.Caption = "Điện Thoại";
            this.colTelephone.FieldName = "Telephone";
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.Visible = true;
            this.colTelephone.VisibleIndex = 3;
            this.colTelephone.Width = 117;
            // 
            // colMail
            // 
            this.colMail.Caption = "Email";
            this.colMail.FieldName = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.Visible = true;
            this.colMail.VisibleIndex = 4;
            this.colMail.Width = 126;
            // 
            // colGroup
            // 
            this.colGroup.Caption = "Nhóm";
            this.colGroup.FieldName = "Group";
            this.colGroup.Name = "colGroup";
            this.colGroup.Visible = true;
            this.colGroup.VisibleIndex = 5;
            this.colGroup.Width = 68;
            // 
            // colContact
            // 
            this.colContact.Caption = "Người Liên Hệ";
            this.colContact.FieldName = "Contact";
            this.colContact.Name = "colContact";
            this.colContact.Visible = true;
            this.colContact.VisibleIndex = 6;
            this.colContact.Width = 216;
            // 
            // colNote
            // 
            this.colNote.Caption = "Ghi Chú";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 7;
            this.colNote.Width = 247;
            // 
            // gridItem
            // 
            this.gridItem.ContextMenuStrip = this.contextMenuStrip1;
            this.gridItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridItem.Location = new System.Drawing.Point(0, 0);
            this.gridItem.MainView = this.gridItemDetail;
            this.gridItem.Name = "gridItem";
            this.gridItem.Size = new System.Drawing.Size(685, 364);
            this.gridItem.TabIndex = 0;
            this.gridItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridItemDetail});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Add,
            this.btn_Update,
            this.btn_Delete,
            this.btnExportFile});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 92);
            // 
            // btn_Add
            // 
            this.btn_Add.Image = global::PTHOrder.Properties.Resources.Action_LinkUnlink_Link;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(146, 22);
            this.btn_Add.Text = "Thêm ";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Update.Image = global::PTHOrder.Properties.Resources.Action_Edit_12x12;
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(146, 22);
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::PTHOrder.Properties.Resources.Action_Delete_12x12;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(146, 22);
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btnExportFile
            // 
            this.btnExportFile.Image = global::PTHOrder.Properties.Resources.Action_Export_ToExcel;
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(146, 22);
            this.btnExportFile.Text = "Xuất file excel";
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // frmListSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 391);
            this.Controls.Add(this.gridItem);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListSupplier";
            this.Text = "Danh Sách Nhà Cung Cấp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection imageSmall;
        private DevExpress.XtraGrid.GridControl gridItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridItemDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colTelephone;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colContact;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_Add;
        private System.Windows.Forms.ToolStripMenuItem btn_Update;
        private System.Windows.Forms.ToolStripMenuItem btn_Delete;
        private System.Windows.Forms.ToolStripMenuItem btnExportFile;
        private DevExpress.XtraSplashScreen.SplashScreenManager waiting;
    }
}