using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace PTHOrder.Forms
{
    public partial class frmListMaterial_Update : DevExpress.XtraEditors.XtraForm
    {
        string lbstatus;
        public bool save=false;
        public frmListMaterial_Update()
        {
            InitializeComponent();
            statusForm = true;//form o tinh trang them moi
            this.Text = "Thêm mới danh mục vật tư";
            lbstatus = "Thêm mới";
            lblChoose.Text = "Tình trạng đang: <b>["+lbstatus.ToString()+"]</b>";
        }
        bool statusForm = true;
        public frmListMaterial_Update(string code)
        {
            
            InitializeComponent();
            statusForm = false;
            lbstatus = "Chỉnh sửa";
            lblChoose.Text = "Tình trạng đang: <b>[" + lbstatus.ToString() + "]</b>";
            Class.clsMaterial cls = new Class.clsMaterial();
            cls.MaterialCode = code;
            DataTable dt = cls.tbMaterial_GetbyCode();
            if (dt.Rows.Count > 0)
            {
                txtMaterialCode.Enabled = false;
                txtMaterialCode.Text = dt.Rows[0]["MaterialCode"].ToString();
                txtMaterialName.Text = dt.Rows[0]["MaterialName"].ToString();
                txtQuota.Text = dt.Rows[0]["Quota"].ToString();
                cboGroups.Text = dt.Rows[0]["Groups"].ToString();
                txtMinimum.Text = dt.Rows[0]["Minimum"].ToString();
                txtMaximum.Text = dt.Rows[0]["Maximum"].ToString();
                if (dt.Rows[0]["Images"] != DBNull.Value)
                {
                    // xu ly photo            
                    Byte[] imgbyte = (byte[])dt.Rows[0]["Images"];
                    if (imgbyte.Length > 10)
                    {
                        MemoryStream stmPicData = new MemoryStream(imgbyte);
                        editImages.Image = Image.FromStream(stmPicData);
                    }
                    //
                }
               // editImages.Image = (Image)dt.Rows[0]["Images"];
               chkActive.Checked = (bool)dt.Rows[0]["Active"];


            }
            this.Text = "Cập nhật danh mục vật tư:  " + dt.Rows[0]["MaterialName"].ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Class.clsMaterial cls = new Class.clsMaterial();

            //Ran buoc du lieu form
            if (txtMaterialCode.Text.Trim() == "")
            {

                MessageBox.Show("Bạn chưa nhập mã vật tư.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaterialCode.Focus();
                return;
            }

            if (txtMaterialName.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên vật tư.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaterialName.Focus();
                return;
            }
            /*
            if (int.Parse(txtMinimum.EditValue.ToString()) > int.Parse(txtMaximum.EditValue.ToString()))
            {
                MessageBox.Show("Số lượng tối thiểu phải thấp hơn số lượng tối đa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMinimum.Focus();
                return;
            }
            */
            
            if (statusForm)
            {
                DataTable dt = cls.tbMaterial_GetList();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)

                    if (dt.Rows[i]["MaterialCode"].ToString().ToLower() == txtMaterialCode.Text.ToLower())
                    {
                        MessageBox.Show("Đã tồn tại vật tư này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaterialCode.Focus();
                        return;
                    }
                
                cls.MaterialCode = txtMaterialCode.Text;
                cls.MaterialName = txtMaterialName.Text;
                if (txtQuota.EditValue == null)
                {
                    cls.Quota = 0;
                }
                else
                {
                    cls.Quota = int.Parse(txtQuota.EditValue.ToString());
                }
                cls.Groups = cboGroups.Text;
                if (txtMinimum.EditValue == null)
                {
                    cls.Minimum = 0;
                }
                else
                {
                    cls.Minimum = int.Parse(txtMinimum.EditValue.ToString());
                }
                if (txtMaximum.EditValue == null)
                {
                    cls.Maximum = 0;
                }
                else
                {
                    cls.Maximum = int.Parse(txtMaximum.EditValue.ToString());
                }
                if (editImages.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    editImages.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    Byte[] bytImage = new Byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(bytImage, 0, Convert.ToInt32(ms.Length));
                    cls.Images = bytImage;
                }
                else
                {
                    cls.Images = null;
                }
                
                    cls.Active = chkActive.Checked;
              
                if (cls.Insert())
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    save = true;
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

                cls.MaterialCode = txtMaterialCode.Text;
                cls.MaterialName = txtMaterialName.Text;
                cls.Quota =int.Parse(txtQuota.EditValue.ToString());
                cls.Groups = cboGroups.Text;
                if (txtMinimum.EditValue == null)
                {
                    cls.Minimum = 0;
                }
                else
                {
                    cls.Minimum = int.Parse(txtMinimum.EditValue.ToString());
                }
                if (txtMaximum.EditValue == null)
                {
                    cls.Maximum = 0;
                }
                else
                {
                    cls.Maximum = int.Parse(txtMaximum.EditValue.ToString());
                }
                if (editImages.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    editImages.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    Byte[] bytImage = new Byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(bytImage, 0, Convert.ToInt32(ms.Length));
                    cls.Images = bytImage;
                }
                else
                {
                    cls.Images = null;
                }
                cls.Active = chkActive.Checked;
                if (cls.Update())
                {
                    MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    save = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                    return;
                }
            }
        }
        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            Class.clsMaterial cls = new Class.clsMaterial();

            //Ran buoc du lieu form
            if (txtMaterialCode.Text.Trim() == "")
            {

                MessageBox.Show("Bạn chưa nhập mã vật tư.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaterialCode.Focus();
                return;
            }

            if (txtMaterialName.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên vật tư.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaterialName.Focus();
                return;
            }
            if (statusForm)
            {
                DataTable dt = cls.tbMaterial_GetList();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)

                    if (dt.Rows[i]["MaterialCode"].ToString().ToLower() == txtMaterialCode.Text.ToLower())
                    {
                        MessageBox.Show("Đã tồn tại vật tư này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaterialCode.Focus();
                        return;
                    }

                cls.MaterialCode = txtMaterialCode.Text;
                cls.MaterialName = txtMaterialName.Text;
                cls.Groups = cboGroups.Text;
                if (txtMinimum.EditValue == null)
                {
                    cls.Minimum = 0;
                }
                else
                {
                    cls.Minimum = int.Parse(txtMinimum.EditValue.ToString());
                }
                if (txtMaximum.EditValue == null)
                {
                    cls.Maximum = 0;
                }
                else
                {
                    cls.Maximum = int.Parse(txtMaximum.EditValue.ToString());
                }
                if (txtQuota.EditValue == null)
                {
                    cls.Quota = 0;
                }
                else
                {
                    cls.Quota = int.Parse(txtQuota.EditValue.ToString());
                }
                if (editImages.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    editImages.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    Byte[] bytImage = new Byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(bytImage, 0, Convert.ToInt32(ms.Length));
                    cls.Images = bytImage;
                }
                else
                {
                    cls.Images = null;
                }
                cls.Active = chkActive.Checked;

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
                cls.MaterialCode = txtMaterialCode.Text;
                cls.MaterialName = txtMaterialName.Text;
                cls.Groups = cboGroups.Text;
                if (txtMinimum.EditValue == null)
                {
                    cls.Minimum = 0;
                }
                else
                {
                    cls.Minimum = int.Parse(txtMinimum.EditValue.ToString());
                }
                if (txtMaximum.EditValue == null)
                {
                    cls.Maximum = 0;
                }
                else
                {
                    cls.Maximum = int.Parse(txtMaximum.EditValue.ToString());
                }
                if (txtQuota.EditValue == null)
                {
                    cls.Quota = 0;
                }
                else
                {
                    cls.Quota = int.Parse(txtQuota.EditValue.ToString());
                }
                if (editImages.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    editImages.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    Byte[] bytImage = new Byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(bytImage, 0, Convert.ToInt32(ms.Length));
                    cls.Images = bytImage;
                }
                else
                {
                    cls.Images = null;
                }
                cls.Active = chkActive.Checked;
                  


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
        void Addnew()
        {
            this.Text = "Thêm mới vật tư";
            lbstatus = "Thêm mới";
            lblChoose.Text = "Tình trạng đang: <b>[" + lbstatus.ToString() + "]</b>";
            txtMaterialCode.Enabled = true;
            this.txtMaterialCode.Text = "";
            this.txtMaterialName.Text = "";
         
            statusForm = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtMinimum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtMaximum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      
    }
}