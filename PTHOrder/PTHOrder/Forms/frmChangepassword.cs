using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PTHOrder.Forms
{
    public partial class frmChangepassword : DevExpress.XtraEditors.XtraForm
    {
        public frmChangepassword()
        {
            InitializeComponent();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtPassOld.Text.Trim() == "" || txtPassNew.Text.Trim() == "" || txtPassOld.Text.Trim() == "")
            {

                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            
            }
            if (txtPassNew.Text != txtPassConfirm.Text)
            { 
                MessageBox.Show("Mật khẩu xác thực không đúng, vui lòng nhập lại");
                
                txtPassNew.Focus();
                return;
            }
            try
            {
                Class.clsLogin cls = new Class.clsLogin();
                DataTable dt = new DataTable();
                cls.Username = Class.App.UserLogin;
                cls.Password = txtPassOld.Text;                
                dt = cls.tbLogin_Get();
                
                 int count = dt.Rows.Count;

                    if (count==1)
                    {
                        cls.Username = Class.App.UserLogin;
                        cls.Password = txtPassNew.Text.Trim();
                        if (cls.Update())
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!");
                            this.Close();
                        }else
                            MessageBox.Show("Đổi mật khẩu thất bại!");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu củ không đúng!");                                              
                    }                        
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}