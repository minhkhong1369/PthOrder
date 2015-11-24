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
    public partial class frmStore_Update : DevExpress.XtraEditors.XtraForm
    {
        string lbstatus;
        public frmStore_Update()
        {
            InitializeComponent();
            statusForm = true;//form o tinh trang them moi
            this.Text = "Thêm mới kho hàng";
            lbstatus = "Thêm mới";
            lblChoose.Text = "Tình trạng đang: <b>[" + lbstatus.ToString() + "]</b>";
        }
        bool statusForm = true;
        public frmStore_Update(string code)
        {  
            InitializeComponent();    
            statusForm = false;
            lbstatus = "Chỉnh sửa";
            lblChoose.Text = "Tình trạng đang: <b>[" + lbstatus.ToString() + "]</b>";
            Class.clsStore cls = new Class.clsStore();
            cls.StoreCode = code;
            DataTable dt = cls.tbStore_GetbyCode();
            if (dt.Rows.Count > 0)
            {
                txtStoreCode.Enabled = false;
                txtStoreCode.Text = dt.Rows[0]["StoreCode"].ToString();
                txtStoreName.Text = dt.Rows[0]["StoreName"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                txtTelephone.Text = dt.Rows[0]["Telephone"].ToString();
                
            }
            this.Text = "Cập nhật kho hàng:  " + dt.Rows[0]["StoreName"].ToString();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            Class.clsStore cls = new Class.clsStore();

            //Ran buoc du lieu form
            if (txtStoreCode.Text.Trim() == "")
            {

                MessageBox.Show("Bạn chưa nhập mã kho hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStoreCode.Focus();
                return;
            }

            if (txtStoreName.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên kho hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStoreName.Focus();
                return;
            }
            if (statusForm)
            {
                DataTable dt = cls.tbStore_GetList();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)

                    if (dt.Rows[i]["StoreCode"].ToString().ToLower() == txtStoreCode.Text.ToLower())
                    {
                        MessageBox.Show("Đã tồn tại kho hàng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtStoreCode.Focus();
                        return;
                    }
                                        
                cls.StoreCode = txtStoreCode.Text;
                cls.StoreName = txtStoreName.Text;
                cls.Address = txtAddress.Text;
                cls.Telephone = txtTelephone.Text;
               
                if (cls.Insert())
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }
            else
            {
                
                cls.StoreCode = txtStoreCode.Text;
                cls.StoreName = txtStoreName.Text;
                cls.Address = txtAddress.Text;
                cls.Telephone = txtTelephone.Text;
              
                if (cls.Update())
                {
                    MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }
            Addnew();

        }
        void Addnew()
        {
            this.Text = "Thêm mới kho hàng";
            lbstatus = "Thêm mới";
            lblChoose.Text = "Tình trạng đang: <b>[" + lbstatus.ToString() + "]</b>";
            txtStoreCode.Enabled = true;
            this.txtStoreCode.Text = "";
            this.txtStoreName.Text = "";
            this.txtAddress.Text = "";
            this.txtTelephone.Text = "";
            
            statusForm = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Class.clsStore cls = new Class.clsStore();

            //Ran buoc du lieu form
            if (txtStoreCode.Text.Trim() == "")
            {

                MessageBox.Show("Bạn chưa nhập mã kho hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStoreCode.Focus();
                return;
            }

            if (txtStoreName.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên kho hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStoreName.Focus();
                return;
            }
            if (statusForm)
            {
                DataTable dt = cls.tbStore_GetList();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)

                    if (dt.Rows[i]["StoreCode"].ToString().ToLower() == txtStoreCode.Text.ToLower())
                    {
                        MessageBox.Show("Đã tồn tại kho hàng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtStoreCode.Focus();
                        return;
                    }

                cls.StoreCode = txtStoreCode.Text;
                cls.StoreName = txtStoreName.Text;
                cls.Address = txtAddress.Text;
                cls.Telephone = txtTelephone.Text;

                if (cls.Insert())
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }
            else
            {

                cls.StoreCode = txtStoreCode.Text;
                cls.StoreName = txtStoreName.Text;
                cls.Address = txtAddress.Text;
                cls.Telephone = txtTelephone.Text;

                if (cls.Update())
                {
                    MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}