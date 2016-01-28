using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;

namespace PTHOrder
{
    public partial class frmMainPO : DevExpress.XtraEditors.XtraForm
    {
        public frmMainPO()
        {
            InitializeComponent();
        }
        #region KiemTraFormOpen And ReShow

        private bool _checkControl(string frmForm)
        {
            for (int i = 0; i < pControls.Controls.Count; i++)
            {
                if (pControls.Controls[i].Text == frmForm)
                {
                    pControls.Controls[i].Show();
                    return true;
                }
                else
                {
                    pControls.Controls[i].Hide();
                }
            }
            return false;
        }
        #endregion
        private void frmMainPO_Load(object sender, EventArgs e)
        {
            btnLogIn_LinkClicked(null, null);
        }
        private void btnLogIn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Forms.frmLogin frmlogin = new Forms.frmLogin();
           frmlogin.ShowDialog();
            //frmlogin.Show();
            if (Class.App.UserLogin != null)
                btnLogIn.Enabled = false;
           /* Waiting.ShowWaitForm();
            if (!_checkControl("frmLogin"))
            {
                Forms.frmLogin frm = new Forms.frmLogin();
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            if (Class.App.UserLogin != null)
                btnLogIn.Enabled = false;
            Waiting.CloseWaitForm();*/
        }
        private void btnLogOut_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Class.App.UserLogin = null;
            btnLogIn_LinkClicked(null, null);
        }

        private void btnChangePass_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmChangepassword"))
            {
                Forms.frmChangepassword frm = new Forms.frmChangepassword();
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }
        private void btnSupplier_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmListSupplier"))
            {
                 Forms.frmListSupplier frm = new Forms.frmListSupplier();
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.TopLevel = false;                
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void btnMaterial_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmListMaterial"))
            {
                Forms.frmListMaterial frm = new Forms.frmListMaterial();
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmStore"))
            {
                Forms.frmStore frm = new Forms.frmStore();
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

       
        private void btnListOrder_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmListOrder"))
            {
                Forms.frmListOrder frm = new Forms.frmListOrder();
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }


        private void btnMaterialDetails_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Waiting.ShowWaitForm();
            if (!_checkControl("frmMaterialDetails"))
            {
                Forms.frmMaterialDetails frm = new Forms.frmMaterialDetails();
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.TopLevel = false;
                frm.Dock = System.Windows.Forms.DockStyle.Fill;
                pControls.Controls.Add(frm);
                frm.Show();
            }
            Waiting.CloseWaitForm();
        }

       

        

      
       
    }
}