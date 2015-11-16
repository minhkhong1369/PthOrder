namespace PTHOrder.Forms
{
    partial class frmStore_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStore_Update));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.txtStoreCode = new DevExpress.XtraEditors.TextEdit();
            this.txtTelephone = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtStoreName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelephone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Action_Save_New_32x32.png");
            this.imageCollection1.Images.SetKeyName(1, "Action_Save_Close_32x32.png");
            this.imageCollection1.Images.SetKeyName(2, "Action_Exit_32x32.png");
            // 
            // txtStoreCode
            // 
            this.txtStoreCode.Location = new System.Drawing.Point(106, 13);
            this.txtStoreCode.Name = "txtStoreCode";
            this.txtStoreCode.Size = new System.Drawing.Size(119, 20);
            this.txtStoreCode.TabIndex = 9;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(106, 65);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(119, 20);
            this.txtTelephone.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(106, 91);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(238, 20);
            this.txtAddress.TabIndex = 11;
            // 
            // txtStoreName
            // 
            this.txtStoreName.Location = new System.Drawing.Point(106, 39);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(238, 20);
            this.txtStoreName.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Tên Kho:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(33, 72);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(55, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Điện Thoại:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Địa Chỉ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Mã Kho:";
            // 
            // btnExit
            // 
            this.btnExit.ImageIndex = 2;
            this.btnExit.ImageList = this.imageCollection1;
            this.btnExit.Location = new System.Drawing.Point(272, 125);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 34);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Đóng";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.ImageIndex = 0;
            this.btnSaveNew.ImageList = this.imageCollection1;
            this.btnSaveNew.Location = new System.Drawing.Point(154, 125);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(112, 34);
            this.btnSaveNew.TabIndex = 14;
            this.btnSaveNew.Text = "Lưu && Thêm";
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 1;
            this.btnSave.ImageList = this.imageCollection1;
            this.btnSave.Location = new System.Drawing.Point(40, 125);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu && Đóng";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmStore_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 166);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStoreCode);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtStoreName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmStore_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật danh mục kho hàng";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelephone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.TextEdit txtStoreCode;
        private DevExpress.XtraEditors.TextEdit txtTelephone;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtStoreName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnSaveNew;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}