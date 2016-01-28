namespace PTHOrder.Forms
{
    partial class frmListMaterial_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListMaterial_Update));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaterialCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaterialName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuota = new DevExpress.XtraEditors.TextEdit();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.editImages = new DevExpress.XtraEditors.PictureEdit();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cboGroups = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtMinimum = new DevExpress.XtraEditors.TextEdit();
            this.txtMaximum = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblChoose = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editImages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGroups.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinimum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaximum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã vật tư";
            // 
            // txtMaterialCode
            // 
            this.txtMaterialCode.Location = new System.Drawing.Point(127, 53);
            this.txtMaterialCode.Name = "txtMaterialCode";
            this.txtMaterialCode.Size = new System.Drawing.Size(135, 20);
            this.txtMaterialCode.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên vật tư";
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Location = new System.Drawing.Point(127, 83);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(135, 20);
            this.txtMaterialName.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 209);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Định mức";
            // 
            // txtQuota
            // 
            this.txtQuota.Location = new System.Drawing.Point(127, 202);
            this.txtQuota.Name = "txtQuota";
            this.txtQuota.Size = new System.Drawing.Size(100, 20);
            this.txtQuota.TabIndex = 6;
            this.txtQuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuota_KeyPress);
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(125, 234);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "";
            this.chkActive.Size = new System.Drawing.Size(75, 19);
            this.chkActive.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(28, 236);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Trạng thái";
            // 
            // editImages
            // 
            this.editImages.Location = new System.Drawing.Point(281, 53);
            this.editImages.Name = "editImages";
            this.editImages.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.editImages.Size = new System.Drawing.Size(223, 200);
            this.editImages.TabIndex = 8;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Action_Save_32x32.png");
            this.imageCollection1.Images.SetKeyName(1, "Action_Save_New_32x32.png");
            this.imageCollection1.Images.SetKeyName(2, "Action_Exit_32x32.png");
            // 
            // btnExit
            // 
            this.btnExit.ImageIndex = 2;
            this.btnExit.ImageList = this.imageCollection1;
            this.btnExit.Location = new System.Drawing.Point(430, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 30);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Đóng";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.ImageIndex = 0;
            this.btnSaveNew.ImageList = this.imageCollection1;
            this.btnSaveNew.Location = new System.Drawing.Point(326, 268);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(99, 30);
            this.btnSaveNew.TabIndex = 10;
            this.btnSaveNew.Text = "Lưu && Thêm";
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 1;
            this.btnSave.ImageList = this.imageCollection1;
            this.btnSave.Location = new System.Drawing.Point(223, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu && Đóng";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(28, 115);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Nhóm vật tư";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(28, 147);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(84, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Số lượng tối thiểu";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(28, 178);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(72, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Số lượng tối đa";
            // 
            // cboGroups
            // 
            this.cboGroups.EditValue = "[Vui lòng chọn nhóm]";
            this.cboGroups.Location = new System.Drawing.Point(127, 112);
            this.cboGroups.Name = "cboGroups";
            this.cboGroups.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGroups.Properties.Items.AddRange(new object[] {
            "Nhóm 1",
            "Nhóm 2",
            "Nhóm 3"});
            this.cboGroups.Size = new System.Drawing.Size(135, 20);
            this.cboGroups.TabIndex = 3;
            // 
            // txtMinimum
            // 
            this.txtMinimum.Location = new System.Drawing.Point(127, 144);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.Size = new System.Drawing.Size(100, 20);
            this.txtMinimum.TabIndex = 4;
            this.txtMinimum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimum_KeyPress);
            // 
            // txtMaximum
            // 
            this.txtMaximum.Location = new System.Drawing.Point(127, 170);
            this.txtMaximum.Name = "txtMaximum";
            this.txtMaximum.Size = new System.Drawing.Size(100, 20);
            this.txtMaximum.TabIndex = 5;
            this.txtMaximum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaximum_KeyPress);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.lblChoose);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Location = new System.Drawing.Point(-3, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(532, 45);
            this.panelControl1.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Location = new System.Drawing.Point(83, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(158, 19);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "DANH MỤC VẬT TƯ";
            // 
            // lblChoose
            // 
            this.lblChoose.AllowHtmlString = true;
            this.lblChoose.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblChoose.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblChoose.Location = new System.Drawing.Point(170, 26);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(71, 14);
            this.lblChoose.TabIndex = 0;
            this.lblChoose.Text = "Tình trạng:[]";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl9.Location = new System.Drawing.Point(16, 5);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(56, 17);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Cập nhật";
            // 
            // frmListMaterial_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 309);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.txtMaximum);
            this.Controls.Add(this.txtMinimum);
            this.Controls.Add(this.cboGroups);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.editImages);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtQuota);
            this.Controls.Add(this.txtMaterialName);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtMaterialCode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListMaterial_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật danh mục vật tư";
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editImages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGroups.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinimum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaximum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaterialCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaterialName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtQuota;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit editImages;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnSaveNew;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cboGroups;
        private DevExpress.XtraEditors.TextEdit txtMinimum;
        private DevExpress.XtraEditors.TextEdit txtMaximum;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblChoose;
        private DevExpress.XtraEditors.LabelControl labelControl9;

    }
}