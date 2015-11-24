namespace PTHOrder.Forms
{
    partial class frmListOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListOrder));
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
            this.gridItem = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.trạngTháiĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChoDuyet = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDaDuyet = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHuy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoanThanh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExportFile = new System.Windows.Forms.ToolStripMenuItem();
            this.gridItemDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateSuggest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFollowers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlaceOfDelivery = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentConditions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.waiting = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PTHOrder.frmWaiting), true, true);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblChoose = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
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
            this.bar3.BarName = "Custom 4";
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
            this.bar3.Text = "Custom 4";
            // 
            // btnAdd
            // 
            this.btnAdd.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnAdd.Caption = "Thêm ";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageIndex = 2;
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
            this.btnDelete.ImageIndex = 0;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(746, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 317);
            this.barDockControlBottom.Size = new System.Drawing.Size(746, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 317);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(746, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 317);
            // 
            // imageSmall
            // 
            this.imageSmall.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageSmall.ImageStream")));
            this.imageSmall.Images.SetKeyName(0, "Action_Delete_12x12.png");
            this.imageSmall.Images.SetKeyName(1, "Action_Edit_12x12.png");
            this.imageSmall.Images.SetKeyName(2, "Action_New_12x12.png");
            this.imageSmall.Images.SetKeyName(3, "Action_LinkUnlink_Link.png");
            // 
            // gridItem
            // 
            this.gridItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridItem.ContextMenuStrip = this.contextMenuStrip1;
            this.gridItem.Location = new System.Drawing.Point(0, 52);
            this.gridItem.MainView = this.gridItemDetail;
            this.gridItem.Name = "gridItem";
            this.gridItem.Size = new System.Drawing.Size(746, 265);
            this.gridItem.TabIndex = 4;
            this.gridItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridItemDetail});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Add,
            this.btn_Update,
            this.btn_Delete,
            this.toolStripMenuItem1,
            this.btnReport,
            this.trạngTháiĐơnHàngToolStripMenuItem,
            this.toolStripMenuItem2,
            this.btnExportFile});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 148);
            // 
            // btn_Add
            // 
            this.btn_Add.Image = global::PTHOrder.Properties.Resources.Action_LinkUnlink_Link;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(182, 22);
            this.btn_Add.Text = "Thêm ";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Update.Image = global::PTHOrder.Properties.Resources.Action_Edit_12x12;
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(182, 22);
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::PTHOrder.Properties.Resources.Action_Delete_12x12;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(182, 22);
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 6);
            // 
            // btnReport
            // 
            this.btnReport.Image = global::PTHOrder.Properties.Resources.Action_Printing_Print;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(182, 22);
            this.btnReport.Text = "In đơn đặt hàng";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // trạngTháiĐơnHàngToolStripMenuItem
            // 
            this.trạngTháiĐơnHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChoDuyet,
            this.btnDaDuyet,
            this.btnHuy,
            this.btnHoanThanh});
            this.trạngTháiĐơnHàngToolStripMenuItem.Image = global::PTHOrder.Properties.Resources.Action_AboutInfo;
            this.trạngTháiĐơnHàngToolStripMenuItem.Name = "trạngTháiĐơnHàngToolStripMenuItem";
            this.trạngTháiĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.trạngTháiĐơnHàngToolStripMenuItem.Text = "Trạng thái đơn hàng";
            // 
            // btnChoDuyet
            // 
            this.btnChoDuyet.Image = global::PTHOrder.Properties.Resources.ModelEditor_GoToObject;
            this.btnChoDuyet.Name = "btnChoDuyet";
            this.btnChoDuyet.Size = new System.Drawing.Size(137, 22);
            this.btnChoDuyet.Text = "Chờ duyệt";
            this.btnChoDuyet.Click += new System.EventHandler(this.btnChoDuyet_Click);
            // 
            // btnDaDuyet
            // 
            this.btnDaDuyet.Image = global::PTHOrder.Properties.Resources.ModelEditor_GoToObject;
            this.btnDaDuyet.Name = "btnDaDuyet";
            this.btnDaDuyet.Size = new System.Drawing.Size(137, 22);
            this.btnDaDuyet.Text = "Đã duyệt";
            this.btnDaDuyet.Click += new System.EventHandler(this.btnDaDuyet_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::PTHOrder.Properties.Resources.ModelEditor_GoToObject;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(137, 22);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Image = global::PTHOrder.Properties.Resources.ModelEditor_GoToObject;
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(137, 22);
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(179, 6);
            // 
            // btnExportFile
            // 
            this.btnExportFile.Image = global::PTHOrder.Properties.Resources.Action_Export_ToExcel;
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(182, 22);
            this.btnExportFile.Text = "Xuất file excel";
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // gridItemDetail
            // 
            this.gridItemDetail.ColumnPanelRowHeight = 25;
            this.gridItemDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderCode,
            this.colDateSuggest,
            this.colFollowers,
            this.colSupplierCode,
            this.colDeliveryDate,
            this.colPlaceOfDelivery,
            this.colPaymentConditions,
            this.colVAT,
            this.colSupplierName,
            this.colStatus});
            this.gridItemDetail.GridControl = this.gridItem;
            this.gridItemDetail.IndicatorWidth = 45;
            this.gridItemDetail.Name = "gridItemDetail";
            this.gridItemDetail.OptionsBehavior.Editable = false;
            this.gridItemDetail.OptionsSelection.MultiSelect = true;
            this.gridItemDetail.OptionsView.ColumnAutoWidth = false;
            this.gridItemDetail.OptionsView.ShowGroupPanel = false;
            this.gridItemDetail.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridItemDetail_CustomDrawRowIndicator);
            this.gridItemDetail.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridItemDetail_FocusedRowChanged);
            this.gridItemDetail.DoubleClick += new System.EventHandler(this.gridItemDetail_DoubleClick);
            // 
            // colOrderCode
            // 
            this.colOrderCode.Caption = "Mã Đơn Đặt Hàng";
            this.colOrderCode.FieldName = "OrderCode";
            this.colOrderCode.Name = "colOrderCode";
            this.colOrderCode.Visible = true;
            this.colOrderCode.VisibleIndex = 0;
            this.colOrderCode.Width = 83;
            // 
            // colDateSuggest
            // 
            this.colDateSuggest.Caption = "Ngày Yêu Cầu";
            this.colDateSuggest.FieldName = "DateSuggest";
            this.colDateSuggest.Name = "colDateSuggest";
            this.colDateSuggest.Visible = true;
            this.colDateSuggest.VisibleIndex = 1;
            this.colDateSuggest.Width = 89;
            // 
            // colFollowers
            // 
            this.colFollowers.Caption = "Người Theo Dõi";
            this.colFollowers.FieldName = "Followers";
            this.colFollowers.Name = "colFollowers";
            this.colFollowers.Visible = true;
            this.colFollowers.VisibleIndex = 3;
            this.colFollowers.Width = 135;
            // 
            // colSupplierCode
            // 
            this.colSupplierCode.Caption = "Mã Nhà Cung Cấp";
            this.colSupplierCode.FieldName = "SupplierCode";
            this.colSupplierCode.Name = "colSupplierCode";
            this.colSupplierCode.Width = 94;
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.Caption = "Ngày Giao";
            this.colDeliveryDate.FieldName = "DeliveryDate";
            this.colDeliveryDate.Name = "colDeliveryDate";
            this.colDeliveryDate.Visible = true;
            this.colDeliveryDate.VisibleIndex = 4;
            this.colDeliveryDate.Width = 107;
            // 
            // colPlaceOfDelivery
            // 
            this.colPlaceOfDelivery.Caption = "Địa Điểm Giao";
            this.colPlaceOfDelivery.FieldName = "PlaceOfDelivery";
            this.colPlaceOfDelivery.Name = "colPlaceOfDelivery";
            this.colPlaceOfDelivery.Visible = true;
            this.colPlaceOfDelivery.VisibleIndex = 5;
            this.colPlaceOfDelivery.Width = 176;
            // 
            // colPaymentConditions
            // 
            this.colPaymentConditions.Caption = "Điều Kiện Thanh Toán";
            this.colPaymentConditions.FieldName = "PaymentConditions";
            this.colPaymentConditions.Name = "colPaymentConditions";
            this.colPaymentConditions.Visible = true;
            this.colPaymentConditions.VisibleIndex = 6;
            this.colPaymentConditions.Width = 112;
            // 
            // colVAT
            // 
            this.colVAT.Caption = "VAT";
            this.colVAT.FieldName = "VAT";
            this.colVAT.Name = "colVAT";
            this.colVAT.Visible = true;
            this.colVAT.VisibleIndex = 7;
            this.colVAT.Width = 57;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Caption = "Nhà Cung Cấp";
            this.colSupplierName.FieldName = "SupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 2;
            this.colSupplierName.Width = 148;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Trạng thái";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 8;
            this.colStatus.Width = 66;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lblChoose);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(0, -2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(753, 55);
            this.panelControl1.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(82, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(155, 23);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "ĐƠN ĐẶT HÀNG";
            // 
            // lblChoose
            // 
            this.lblChoose.AllowHtmlString = true;
            this.lblChoose.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblChoose.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblChoose.Location = new System.Drawing.Point(148, 34);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(73, 14);
            this.lblChoose.TabIndex = 0;
            this.lblChoose.Text = "Đang chọn:[]";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(15, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Danh sách";
            // 
            // frmListOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 344);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridItem);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListOrder";
            this.Text = "Danh Sách Đơn Hàng";
            this.Load += new System.EventHandler(this.frmListOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItemDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridItemDetail;
        private DevExpress.Utils.ImageCollection imageSmall;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDateSuggest;
        private DevExpress.XtraGrid.Columns.GridColumn colFollowers;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPlaceOfDelivery;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentConditions;
        private DevExpress.XtraGrid.Columns.GridColumn colVAT;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_Add;
        private System.Windows.Forms.ToolStripMenuItem btn_Update;
        private System.Windows.Forms.ToolStripMenuItem btn_Delete;
        private System.Windows.Forms.ToolStripMenuItem trạngTháiĐơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnChoDuyet;
        private System.Windows.Forms.ToolStripMenuItem btnDaDuyet;
        private System.Windows.Forms.ToolStripMenuItem btnHuy;
        private System.Windows.Forms.ToolStripMenuItem btnHoanThanh;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private System.Windows.Forms.ToolStripMenuItem btnExportFile;
        private System.Windows.Forms.ToolStripMenuItem btnReport;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private DevExpress.XtraSplashScreen.SplashScreenManager waiting;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblChoose;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}