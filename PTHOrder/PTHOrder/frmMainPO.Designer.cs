namespace PTHOrder
{
    partial class frmMainPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPO));
            this.pControls = new DevExpress.XtraEditors.PanelControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnSupplier = new DevExpress.XtraNavBar.NavBarItem();
            this.btnMaterial = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnListOrder = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnMaterialDetails = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnChangePass = new DevExpress.XtraNavBar.NavBarItem();
            this.imageLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.Waiting = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PTHOrder.frmWaiting), true, true);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.defaultStyle = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnLogIn = new DevExpress.XtraNavBar.NavBarItem();
            this.btnLogOut = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.pControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pControls
            // 
            this.pControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pControls.Location = new System.Drawing.Point(168, 4);
            this.pControls.Name = "pControls";
            this.pControls.Size = new System.Drawing.Size(592, 378);
            this.pControls.TabIndex = 1;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnSupplier,
            this.btnMaterial,
            this.navBarItem2,
            this.btnListOrder,
            this.btnMaterialDetails,
            this.btnChangePass,
            this.btnLogIn,
            this.btnLogOut});
            this.navBarControl1.LargeImages = this.imageLarge;
            this.navBarControl1.Location = new System.Drawing.Point(0, 103);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 162;
            this.navBarControl1.Size = new System.Drawing.Size(162, 269);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Danh mục";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnSupplier),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnMaterial),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
            this.navBarGroup1.LargeImageIndex = 2;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // btnSupplier
            // 
            this.btnSupplier.Caption = "Nhà cung cấp";
            this.btnSupplier.LargeImageIndex = 9;
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnSupplier_LinkClicked);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Caption = "Vật tư";
            this.btnMaterial.LargeImageIndex = 7;
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnMaterial_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Kho";
            this.navBarItem2.LargeImageIndex = 10;
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Quản lý đơn hàng";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnListOrder)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // btnListOrder
            // 
            this.btnListOrder.Caption = "Đơn đặt hàng";
            this.btnListOrder.LargeImageIndex = 3;
            this.btnListOrder.Name = "btnListOrder";
            this.btnListOrder.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnListOrder_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Quản lý kho";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnMaterialDetails)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // btnMaterialDetails
            // 
            this.btnMaterialDetails.Caption = "Quản lý Xuất kho";
            this.btnMaterialDetails.LargeImageIndex = 2;
            this.btnMaterialDetails.Name = "btnMaterialDetails";
            this.btnMaterialDetails.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnMaterialDetails_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Quản lý tài khoản";
            this.navBarGroup4.Expanded = true;
            this.navBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnChangePass),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnLogIn),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnLogOut)});
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Caption = "Thay đổi mật khẩu";
            this.btnChangePass.LargeImageIndex = 1;
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnChangePass_LinkClicked);
            // 
            // imageLarge
            // 
            this.imageLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.imageLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageLarge.ImageStream")));
            this.imageLarge.Images.SetKeyName(0, "BO_Security_Permission_32x32.png");
            this.imageLarge.Images.SetKeyName(1, "Action_ResetPassword_32x32.png");
            this.imageLarge.Images.SetKeyName(2, "Action_Open_Object_32x32.png");
            this.imageLarge.Images.SetKeyName(3, "BO_Order_Item_32x32.png");
            this.imageLarge.Images.SetKeyName(4, "BO_User_32x32.png");
            this.imageLarge.Images.SetKeyName(5, "Action_ChooseSkin_32x32.png");
            this.imageLarge.Images.SetKeyName(6, "Store.png");
            this.imageLarge.Images.SetKeyName(7, "Action_Search_Object_FindObjectByID_32x32.png");
            this.imageLarge.Images.SetKeyName(8, "Action_Search_32x32.png");
            this.imageLarge.Images.SetKeyName(9, "Icon_Suppelier.png");
            this.imageLarge.Images.SetKeyName(10, "Icon_warehouse.png");
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::PTHOrder.Properties.Resources.PTH_color2;
            this.pictureEdit1.Location = new System.Drawing.Point(27, 4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(113, 81);
            this.pictureEdit1.TabIndex = 2;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Caption = "Đăng nhập";
            this.btnLogIn.LargeImageIndex = 4;
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnLogIn_LinkClicked);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Đăng xuất";
            this.btnLogOut.LargeImageIndex = 0;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnLogOut_LinkClicked);
            // 
            // frmMainPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 386);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.pControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainPO";
            this.Text = "PRSIBI Management Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pControls;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem btnSupplier;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.Utils.ImageCollection imageLarge;
        private DevExpress.XtraNavBar.NavBarItem btnMaterial;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem btnListOrder;
        private DevExpress.XtraNavBar.NavBarItem btnMaterialDetails;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultStyle;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem btnChangePass;
        private DevExpress.XtraNavBar.NavBarItem btnLogIn;
        private DevExpress.XtraNavBar.NavBarItem btnLogOut;
        private DevExpress.XtraSplashScreen.SplashScreenManager Waiting;
    }
}