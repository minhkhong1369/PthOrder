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
    public partial class frmListSupplier_Update : DevExpress.XtraEditors.XtraForm
    {
        string lbstatus;
        public bool save = false;
        public frmListSupplier_Update()
        {
            InitializeComponent();
            statusForm = true;//form o tinh trang them moi
            this.Text = "Thêm mới nhà cung cấp";
            lbstatus = "Thêm mới";
            lblChoose.Text = "Tình trạng đang: <b>[" + lbstatus.ToString() + "]</b>";
        }
        bool statusForm= true;
        public frmListSupplier_Update(string code)
        {
            InitializeComponent();
            statusForm = false;//form o tinh trang update
            lbstatus = "Chỉnh sửa";
            lblChoose.Text = "Tình trạng đang: <b>[" + lbstatus.ToString() + "]</b>";
            Class.clsListSupplier cls = new Class.clsListSupplier();
            cls.SupplierCode = code;
            DataTable dt = cls.tbSupplier_Get();
            if (dt.Rows.Count > 0) {
                txtSupplierCode.Enabled = false;
                txtSupplierCode.Text = dt.Rows[0]["SupplierCode"].ToString();               
                txtSupplierName.Text = dt.Rows[0]["SupplierName"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                txtTelephone.Text = dt.Rows[0]["Telephone"].ToString();
                txtMail.Text = dt.Rows[0]["Mail"].ToString();
                txtGroup.Text = dt.Rows[0]["Group"].ToString();
                txtContact.Text = dt.Rows[0]["Contact"].ToString();
                txtNote.Text = dt.Rows[0]["Note"].ToString();
            }
            this.Text = "Cập nhật nhà cung cấp:  "+ dt.Rows[0]["SupplierName"].ToString();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            Class.clsListSupplier cls = new Class.clsListSupplier();                              
            
            //Ran buoc du lieu form
            if (txtSupplierCode.Text.Trim() == "")
            {
               
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSupplierCode.Focus();
                return;
            }
            
            if (txtSupplierName.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSupplierName.Focus();
                return;
            }
            if (statusForm)
            {
                DataTable dt = cls.tbSupplier_GetList();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)

                    if (dt.Rows[i]["SupplierCode"].ToString() == txtSupplierCode.Text)
                    {
                        MessageBox.Show("Đã tồn tại nhà cung cấp này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSupplierCode.Focus();
                        return;
                    }
                //Class.clsListSupplier cls = new Class.clsListSupplier();                              
                cls.SupplierCode = txtSupplierCode.Text;
                cls.SupplierName = txtSupplierName.Text;
                cls.Address = txtAddress.Text;
                cls.Telephone = txtTelephone.Text;
                cls.Mail = txtMail.Text;
                cls.Group = txtGroup.Text;
                cls.Contact = txtContact.Text;
                cls.Note = txtNote.Text;
                if (cls.Insert())
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    save = true;
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
                //Class.clsListSupplier cls = new Class.clsListSupplier();
                cls.SupplierCode = txtSupplierCode.Text;
                cls.SupplierName = txtSupplierName.Text;
                cls.Address = txtAddress.Text;
                cls.Telephone = txtTelephone.Text;
                cls.Mail = txtMail.Text;
                cls.Group = txtGroup.Text;
                cls.Contact = txtContact.Text;
                cls.Note = txtNote.Text;
                if (cls.Update())
                {
                    MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    save = true;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
                 Class.clsListSupplier cls = new Class.clsListSupplier();
                //Ran buoc du lieu form
                if (txtSupplierCode.Text.Trim() == "")
                {  
                    MessageBox.Show("Bạn chưa nhập mã nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSupplierCode.Focus();
                    return;
                } 
                if (txtSupplierName.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSupplierName.Focus();
                    return;
                }           
                        if (statusForm)
                        {
                            DataTable dt = cls.tbSupplier_GetList();
                            for (int i = 0; i <= dt.Rows.Count - 1; i++)

                                if (dt.Rows[i]["SupplierCode"].ToString() == txtSupplierCode.Text)
                                {
                                    MessageBox.Show("Đã tồn tại nhà cung cấp này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtSupplierCode.Focus();
                                    return;
                                }
                            //Class.clsListSupplier cls = new Class.clsListSupplier();
                            cls.SupplierCode = txtSupplierCode.Text;
                            cls.SupplierName = txtSupplierName.Text;
                            cls.Address = txtAddress.Text;
                            cls.Telephone = txtTelephone.Text;
                            cls.Mail = txtMail.Text;
                            cls.Group = txtGroup.Text;
                            cls.Contact = txtContact.Text;
                            cls.Note = txtNote.Text;
                            if (cls.Insert())
                            {
                                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                save = true;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                            }
                        }
                        else
                        {
                            // Class.clsListSupplier cls = new Class.clsListSupplier();
                            cls.SupplierCode = txtSupplierCode.Text;
                            cls.SupplierName = txtSupplierName.Text;
                            cls.Address = txtAddress.Text;
                            cls.Telephone = txtTelephone.Text;
                            cls.Mail = txtMail.Text;
                            cls.Group = txtGroup.Text;
                            cls.Contact = txtContact.Text;
                            cls.Note = txtNote.Text;
                            if (cls.Update())
                            {
                                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                save = true;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Sửa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                            }

                        }                  
        }
        void Addnew()
        {
            this.Text = "Thêm mới nhà cung cấp";
            lbstatus = "Thêm mới";
            lblChoose.Text = "Tình trạng đang: <b>[" + lbstatus.ToString() + "]</b>";
            txtSupplierCode.Enabled = true;
            this.txtSupplierCode.Text = "";
            this.txtSupplierName.Text = "";
            this.txtAddress.Text = "";
            this.txtTelephone.Text = "";
            this.txtMail.Text = "";
            this.txtGroup.Text = "";
            this.txtContact.Text = "";
            this.txtNote.Text = "";
            this.txtSupplierCode.Focus();
            statusForm = true;
        }         
         
    }
}