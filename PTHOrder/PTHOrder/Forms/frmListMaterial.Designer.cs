namespace PTHOrder.Forms
{
    partial class frmListMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListMaterial));
            this.gridItem = new DevExpress.XtraGrid.GridControl();
            this.gridItemDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaterialCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colGroups = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinimum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaximum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportFile = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblChoose = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmall)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridItem
            // 
            this.gridItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridItem.Location = new System.Drawing.Point(0, 54);
            this.gridItem.MainView = this.gridItemDetail;
            this.gridItem.Name = "gridItem";
            this.gridItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridItem.Size = new System.Drawing.Size(762, 240);
            this.gridItem.TabIndex = 0;
            this.gridItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridItemDetail});
            // 
            // gridItemDetail
            // 
            this.gridItemDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaterialCode,
            this.colMaterialName,
            this.colImages,
            this.colGroups,
            this.colMinimum,
            this.colMaximum,
            this.colQuota,
            this.colActive});
            this.gridItemDetail.GridControl = this.gridItem;
            this.gridItemDetail.IndicatorWidth = 40;
            this.gridItemDetail.Name = "gridItemDetail";
            this.gridItemDetail.OptionsBehavior.Editable = false;
            this.gridItemDetail.OptionsView.ColumnAutoWidth = false;
            this.gridItemDetail.OptionsView.ShowGroupPanel = false;
            this.gridItemDetail.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridItemDetail_CustomDrawRowIndicator_1);
            this.gridItemDetail.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridItemDetail_FocusedRowChanged_1);
            this.gridItemDetail.DoubleClick += new System.EventHandler(this.gridItemDetail_DoubleClick_1);
            // 
            // colMaterialCode
            // 
            this.colMaterialCode.Caption = "Mã DM Vật tư";
            this.colMaterialCode.FieldName = "MaterialCode";
            this.colMaterialCode.Name = "colMaterialCode";
            this.colMaterialCode.Visible = true;
            this.colMaterialCode.VisibleIndex = 0;
            this.colMaterialCode.Width = 100;
            // 
            // colMaterialName
            // 
            this.colMaterialName.Caption = "Tên DM Vật tư";
            this.colMaterialName.FieldName = "MaterialName";
            this.colMaterialName.Name = "colMaterialName";
            this.colMaterialName.Visible = true;
            this.colMaterialName.VisibleIndex = 1;
            this.colMaterialName.Width = 118;
            // 
            // colImages
            // 
            this.colImages.Caption = "Hình ảnh";
            this.colImages.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colImages.FieldName = "Images";
            this.colImages.Name = "colImages";
            this.colImages.Visible = true;
            this.colImages.VisibleIndex = 2;
            this.colImages.Width = 139;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // colGroups
            // 
            this.colGroups.Caption = "Nhóm Vật tư";
            this.colGroups.FieldName = "Groups";
            this.colGroups.Name = "colGroups";
            this.colGroups.Visible = true;
            this.colGroups.VisibleIndex = 3;
            this.colGroups.Width = 123;
            // 
            // colMinimum
            // 
            this.colMinimum.Caption = "Số lượng tối thiểu";
            this.colMinimum.FieldName = "Minimum";
            this.colMinimum.Name = "colMinimum";
            this.colMinimum.Visible = true;
            this.colMinimum.VisibleIndex = 4;
            this.colMinimum.Width = 91;
            // 
            // colMaximum
            // 
            this.colMaximum.Caption = "Số lượng tối đa";
            this.colMaximum.FieldName = "Maximum";
            this.colMaximum.Name = "colMaximum";
            this.colMaximum.Visible = true;
            this.colMaximum.VisibleIndex = 5;
            this.colMaximum.Width = 82;
            // 
            // colQuota
            // 
            this.colQuota.Caption = "Định mức";
            this.colQuota.FieldName = "Quota";
            this.colQuota.Name = "colQuota";
            this.colQuota.Visible = true;
            this.colQuota.VisibleIndex = 6;
            this.colQuota.Width = 52;
            // 
            // colActive
            // 
            this.colActive.Caption = "Trạng thái";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 7;
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
            this.barManager1.LargeImages = this.imageSmall;
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
            this.barDockControlTop.Size = new System.Drawing.Size(762, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 294);
            this.barDockControlBottom.Size = new System.Drawing.Size(762, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 294);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(762, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 294);
            // 
            // imageSmall
            // 
            this.imageSmall.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageSmall.ImageStream")));
            this.imageSmall.Images.SetKeyName(0, "Action_LinkUnlink_Link.png");
            this.imageSmall.Images.SetKeyName(1, "Action_Edit.png");
            this.imageSmall.Images.SetKeyName(2, "Action_Delete.png");
            this.imageSmall.Images.SetKeyName(3, "Action_Printing_Print.png");
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
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(762, 55);
            this.panelControl1.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(82, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(158, 23);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Danh mục vật tư";
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
            // frmListMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 321);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridItem);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListMaterial";
            this.Text = "Danh mục vật tư";
            this.Load += new System.EventHandler(this.frmListMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmall)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridItem;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_Add;
        private System.Windows.Forms.ToolStripMenuItem btn_Update;
        private System.Windows.Forms.ToolStripMenuItem btn_Delete;
        private System.Windows.Forms.ToolStripMenuItem btnExportFile;
        private DevExpress.Utils.ImageCollection imageSmall;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblChoose;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridItemDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn colImages;
        private DevExpress.XtraGrid.Columns.GridColumn colGroups;
        private DevExpress.XtraGrid.Columns.GridColumn colMinimum;
        private DevExpress.XtraGrid.Columns.GridColumn colMaximum;
        private DevExpress.XtraGrid.Columns.GridColumn colQuota;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
    }
}