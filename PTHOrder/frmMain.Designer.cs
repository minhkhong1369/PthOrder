namespace PTHOrder
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.defaultStyle = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePass = new DevExpress.XtraBars.BarButtonItem();
            this.btnListSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.btnListOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cboThemes = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.imageLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.waiting = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PTHOrder.frmWaiting), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLogIn,
            this.btnChangePass,
            this.btnListSupplier,
            this.btnListOrder,
            this.btnLogOut,
            this.barEditItem1,
            this.cboThemes,
            this.barSubItem1});
            this.ribbonControl1.LargeImages = this.imageLarge;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 25;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.barSubItem1);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemComboBox3,
            this.repositoryItemComboBox4,
            this.repositoryItemComboBox5});
            this.ribbonControl1.Size = new System.Drawing.Size(765, 117);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Caption = "Đăng Nhập";
            this.btnLogIn.Id = 1;
            this.btnLogIn.LargeImageIndex = 0;
            this.btnLogIn.LargeWidth = 120;
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogIn_ItemClick);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Caption = "Đổi Mật Khẩu";
            this.btnChangePass.CloseRadialMenuOnItemClick = true;
            this.btnChangePass.Id = 2;
            this.btnChangePass.LargeImageIndex = 1;
            this.btnChangePass.LargeWidth = 120;
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePass_ItemClick);
            // 
            // btnListSupplier
            // 
            this.btnListSupplier.AllowAllUp = true;
            this.btnListSupplier.Caption = "Danh Sách Nhà Cung Cấp";
            this.btnListSupplier.Id = 7;
            this.btnListSupplier.LargeImageIndex = 2;
            this.btnListSupplier.LargeWidth = 120;
            this.btnListSupplier.Name = "btnListSupplier";
            this.btnListSupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnListSupplier_ItemClick);
            // 
            // btnListOrder
            // 
            this.btnListOrder.Caption = "Danh Sách Đơn Đặt Hàng";
            this.btnListOrder.Id = 8;
            this.btnListOrder.LargeImageIndex = 3;
            this.btnListOrder.LargeWidth = 120;
            this.btnListOrder.Name = "btnListOrder";
            this.btnListOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnListOrder_ItemClick);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Đăng Xuất";
            this.btnLogOut.Id = 13;
            this.btnLogOut.LargeImageIndex = 4;
            this.btnLogOut.LargeWidth = 120;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOut_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemComboBox1;
            this.barEditItem1.Id = 15;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // cboThemes
            // 
            this.cboThemes.Caption = "Giaodien";
            this.cboThemes.Edit = this.repositoryItemComboBox5;
            this.cboThemes.Id = 22;
            this.cboThemes.Name = "cboThemes";
            // 
            // repositoryItemComboBox5
            // 
            this.repositoryItemComboBox5.AutoHeight = false;
            this.repositoryItemComboBox5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox5.Name = "repositoryItemComboBox5";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 24;
            this.barSubItem1.Name = "barSubItem1";
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
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogIn);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogOut, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangePass, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh Mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnListSupplier);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnListOrder, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // repositoryItemComboBox4
            // 
            this.repositoryItemComboBox4.AutoHeight = false;
            this.repositoryItemComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 501);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "PO Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultStyle;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnLogIn;
        private DevExpress.XtraBars.BarButtonItem btnChangePass;
        private DevExpress.Utils.ImageCollection imageLarge;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnListSupplier;
        private DevExpress.XtraBars.BarButtonItem btnListOrder;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox4;
        private DevExpress.XtraBars.BarEditItem cboThemes;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox5;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraSplashScreen.SplashScreenManager waiting;


    }
}