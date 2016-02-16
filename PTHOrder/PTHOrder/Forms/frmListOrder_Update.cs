using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PTHOrder.Class;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;


namespace PTHOrder.Forms
{
    public partial class frmListOrder_Update : DevExpress.XtraEditors.XtraForm
    {
        string lbstatus;
       public bool save = false;
        public frmListOrder_Update()
        {
            InitializeComponent();
            statusForm = true;
            this.Text = "Thêm mới đơn đặt hàng";
            lbstatus = "Thêm mới";
            lblChoose.Text = "Tình trạng đang: <b>[" + lbstatus.ToString() + "]</b>";
            LoadListSupplier();
            LoadOrderDetails();
            dateSuggestDate.DateTime = DateTime.Now;
            dateDeliveryDate.DateTime = DateTime.Now;
        }
         bool statusForm= true;
        public frmListOrder_Update(string code)
        {
            InitializeComponent();
            LoadListSupplier();
            statusForm = false;
            lbstatus = "Chỉnh sửa";
            lblChoose.Text = "Tình trạng đang: <b>[" + lbstatus.ToString() + "]</b>";
            Class.clsListOrder cls = new Class.clsListOrder();
            cls.OrderCode = code;
            DataTable dt = cls.tbOrder_Get();
            if (dt.Rows.Count > 0) {
               // txtOrderCode.Enabled = false;
                txtOrderCode.Text = dt.Rows[0]["OrderCode"].ToString();                
                dateSuggestDate.DateTime = (DateTime)dt.Rows[0]["DateSuggest"];
                cboFollowers.Text = dt.Rows[0]["Followers"].ToString();               
                dateDeliveryDate.DateTime = (DateTime)dt.Rows[0]["DeliveryDate"];
                txtPlaceOfDelivery.Text = dt.Rows[0]["PlaceOfDelivery"].ToString();
                txtPaymentConditions.Text = dt.Rows[0]["PaymentConditions"].ToString();
                cboCurrencyUnit.Text = dt.Rows[0]["CurrencyUnit"].ToString();
                cboSupplier.Text = dt.Rows[0]["SupplierCode"].ToString();
                txtVAT.Text = dt.Rows[0]["VAT"].ToString();

                LoadOrderDetails(dt.Rows[0]["OrderCode"].ToString());//load du lieu vao luoi chi tiet ddh dua vao OrderCode
            }
            this.Text = "Cập nhật đơn đặt hàng:  " + dt.Rows[0]["OrderCode"].ToString();
        }
        void LoadListSupplier()
        {
            Class.clsListSupplier cls = new Class.clsListSupplier();
            DataTable dt = cls.tbSupplier_GetList();
            cboSupplier.Properties.DataSource = dt;
            cboSupplier.Properties.DisplayMember = "SupplierName";
            cboSupplier.Properties.ValueMember = "SupplierCode";
            //cboSupplier.EditValue = dt.Rows[0]["SupplierCode"];
        }
        DataTable dtOrderDetail = new DataTable();
        DataTable dtOrderDetailTemp = new DataTable();//bang tam de luu du lieu can xoa tu bang OrderDetails khi chinh sua
        void LoadOrderDetails()
        {
            Class.clsListOrder cls = new Class.clsListOrder();
            cls.OrderCode = "";
            dtOrderDetail = cls.tbOrderDetails_GetByCode();            
            gridItem.DataSource = dtOrderDetail;
            dtOrderDetail.Clear();

        }
        void LoadOrderDetails(string Ordercode)
        {
            Class.clsListOrder cls = new Class.clsListOrder();
            cls.OrderCode = Ordercode;
            dtOrderDetail = cls.tbOrderDetails_GetByCode();
            gridItem.DataSource = dtOrderDetail;
            cls.OrderCode = "";
            dtOrderDetailTemp = cls.tbOrderDetails_GetByCode(); 
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Ran buoc du lieu form
            if (txtOrderCode.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã đơn đặt hàng");
                txtOrderCode.Focus();
                return;
            }
            if (cboSupplier.EditValue == null)
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp");
                cboSupplier.Focus();
                return;
            }
            if (dtOrderDetail.Rows.Count < 1) {
                MessageBox.Show("Vui lòng nhập chi tiết đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (statusForm)
            {
                Class.clsListOrder cls = new Class.clsListOrder();
                cls.OrderCode = txtOrderCode.Text;
                cls.DateSuggest = dateSuggestDate.DateTime;
                DateTime date = Convert.ToDateTime(cls.DateSuggest);
                if (date.Year != DateTime.Now.Year)
                {
                    MessageBox.Show("Xoá không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateSuggestDate.Focus();
                    return;
                }
                
                cls.Followers = cboFollowers.Text;
                cls.SupplierCode = cboSupplier.EditValue.ToString();
                cls.DeliveryDate = dateDeliveryDate.DateTime;
                cls.PlaceOfDelivery = txtPlaceOfDelivery.Text;              
                cls.PaymentConditions = txtPaymentConditions.Text;
                cls.CurrencyUnit = cboCurrencyUnit.Text;
                if (txtVAT.EditValue == null)
                {
                    cls.VAT = 0;
                }
                else
                {
                    try
                    {
                        cls.VAT = int.Parse(txtVAT.EditValue.ToString());
                    }
                    catch { }
                }
                if (cls.Insert(dtOrderDetail))
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
                Class.clsListOrder cls = new Class.clsListOrder();
                cls.OrderCode = txtOrderCode.Text;
                cls.DateSuggest = dateSuggestDate.DateTime;
                cls.Followers = cboFollowers.Text;
                cls.SupplierCode = cboSupplier.EditValue.ToString();
                cls.DeliveryDate = dateDeliveryDate.DateTime;
                cls.PlaceOfDelivery = txtPlaceOfDelivery.Text;
                cls.PaymentConditions = txtPaymentConditions.Text;              
                cls.VAT = int.Parse(txtVAT.EditValue.ToString());
                cls.CurrencyUnit = cboCurrencyUnit.Text;
                if (cls.Update(dtOrderDetail,dtOrderDetailTemp))
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

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            //Ran buoc du lieu form
            if (txtOrderCode.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã đơn đặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOrderCode.Focus();
                return;
            }
            if (cboSupplier.EditValue == null)
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSupplier.Focus();
                return;
            }
            if (dtOrderDetail.Rows.Count < 1)
            {
                MessageBox.Show("Vui lòng nhập chi tiết đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return;
            }
            if (statusForm)
            {               
                   
                    {
                        Class.clsListOrder cls = new Class.clsListOrder();
                        cls.OrderCode = txtOrderCode.Text;
                        cls.DateSuggest = dateSuggestDate.DateTime;
                        DateTime date = Convert.ToDateTime(cls.DateSuggest);
                        if (date.Year != DateTime.Now.Year)
                        {

                            MessageBox.Show("Vui lòng nhập lại năm hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dateSuggestDate.Focus();
                            return;
                        }
                        cls.Followers = cboFollowers.Text;
                        cls.SupplierCode = cboSupplier.EditValue.ToString();
                        cls.DeliveryDate = dateDeliveryDate.DateTime;
                        cls.PlaceOfDelivery = txtPlaceOfDelivery.Text;
                        cls.PaymentConditions = txtPaymentConditions.Text;
                        cls.CurrencyUnit = cboCurrencyUnit.Text;
                        if (txtVAT.EditValue == null)
                        {
                            cls.VAT = 0;
                        }
                        else
                        {
                            cls.VAT = int.Parse(txtVAT.EditValue.ToString());
                        }
                        if (cls.Insert(dtOrderDetail))
                        {
                            MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            save = true;
                            AutoOrderCode();
                            //  this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);   

                        }
                    }
            }
            else
            {
                Class.clsListOrder cls = new Class.clsListOrder();
                cls.OrderCode = txtOrderCode.Text;
                cls.DateSuggest = dateSuggestDate.DateTime;
                cls.Followers = cboFollowers.Text;
                cls.SupplierCode = cboSupplier.EditValue.ToString();
                cls.DeliveryDate = dateDeliveryDate.DateTime;
                cls.PlaceOfDelivery = txtPlaceOfDelivery.Text;
                cls.PaymentConditions = txtPaymentConditions.Text;
                cls.VAT = int.Parse(txtVAT.EditValue.ToString());
                cls.CurrencyUnit = cboCurrencyUnit.Text;
                if (cls.Update(dtOrderDetail,dtOrderDetailTemp))
                {
                    MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                    AutoOrderCode();
                    save = true;
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                }

            }
            Addnew();
        }

        private void gridItemDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (gridItemDetail.FocusedRowHandle > -1)
            {
                if (e.KeyValue == 46)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xoá hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            DataRow dr = dtOrderDetailTemp.NewRow();//tao dong bang tam
                            dr["OrderDetailCode"] = dtOrderDetail.Rows[gridItemDetail.FocusedRowHandle]["OrderDetailCode"].ToString();//
                            dtOrderDetailTemp.Rows.Add(dr); //chen dong tu ban OrderDetail sang ban tam

                            dtOrderDetail.Rows.RemoveAt(gridItemDetail.FocusedRowHandle);//xoa dong tai vi tri tro chuot tren luoi
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

     

        private void gridItemDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colNumber")
                {
                    string number = gridItemDetail.GetRowCellValue(e.RowHandle, colNumber).ToString();
                    string price = gridItemDetail.GetRowCellValue(e.RowHandle, colPrice).ToString();
                    double monetize;
                    monetize = Double.Parse(number) * Double.Parse(price);
                    gridItemDetail.SetRowCellValue(e.RowHandle, colMonetize, monetize);
                }
                if (e.Column.Name == "colPrice")
                {
                    string number = gridItemDetail.GetRowCellValue(e.RowHandle, colNumber).ToString();
                    string price = gridItemDetail.GetRowCellValue(e.RowHandle, colPrice).ToString();
                    double monetize;
                    monetize = Double.Parse(number) * Double.Parse(price);
                    gridItemDetail.SetRowCellValue(e.RowHandle, colMonetize, monetize);
                }

            }
            catch { }
        }

        private void gridItemDetail_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //GridView view = sender as GridView;
            
            if (e.RowHandle < 0)
            {
                if (gridItemDetail.GetRowCellValue(e.RowHandle, colDescribe).ToString().Trim().Length <1)
                {
                   
                        e.ErrorText = "Bạn chưa nhập mô tả ! \n";
                        e.Valid = false;             
                      
                    
                }else
                if (gridItemDetail.GetRowCellValue(e.RowHandle, colNumber).ToString() == "")
                {
                    e.ErrorText = "Bạn chưa nhập Số Lượng \n";
                    e.Valid = false;
                }else
                if (gridItemDetail.GetRowCellValue(e.RowHandle, colPrice).ToString() == "")
                {
                    e.ErrorText = "Bạn chưa nhập Giá \n";
                    e.Valid = false;
                }
                else if (gridItemDetail.GetRowCellValue(e.RowHandle, colNumber).ToString() == "0") {
                    e.ErrorText = "Số lượng không hợp lệ \n";
                    e.Valid = false;
                }
            }
        }

        private void txtVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("VAT là kí tự số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                              
            }
        }
       void Addnew()
        {
            this.Text = "Thêm mới đơn đặt hàng";
            lbstatus = "Thêm mới";
            lblChoose.Text = "Tình trạng đang: <b>[" + lbstatus.ToString() + "]</b>";
            txtOrderCode.Enabled = true;
            dateSuggestDate.DateTime = DateTime.Now;
            this.cboFollowers.Text="";
            this.cboSupplier.EditValue.ToString();
            dateDeliveryDate.DateTime =DateTime.Now;
            this.txtPlaceOfDelivery.Text="";
            this.txtPaymentConditions.Text="";
           // this.cboCurrencyUnit.Text = "";
           // this.txtVAT.EditValue="";
            this.txtOrderCode.Focus();
            dtOrderDetail.Clear();
            statusForm = true;
        }

       private void frmListOrder_Update_Load(object sender, EventArgs e)
       {
           if (statusForm)
           {
               AutoOrderCode();
           }
           
       }
       //tao cot ma don hang tu dong 
       void AutoOrderCode()
       {
           Class.clsListOrder cls = new Class.clsListOrder();
           cls.Year = DateTime.Now.Year;
           DataTable dt = cls.tbOrder_GetAutocode();
           if (dt.Rows.Count < 1)
           {
               
               txtOrderCode.Text =  DateTime.Now.Year.ToString().Substring(2,2) + "-0001";
           }
           else
           {
               string txt = dt.Rows[dt.Rows.Count - 1]["OrderCode"].ToString();
               string codetemp = txt.Substring(5);
               int number = int.Parse(codetemp);
               number++;
               if (number.ToString().Length == 3) {
                   txtOrderCode.Text = DateTime.Now.Year.ToString().Substring(2,2) + "-0" + number.ToString();
               }
               if (number.ToString().Length == 2)
               {
                   txtOrderCode.Text = DateTime.Now.Year.ToString().Substring(2, 2) + "-00" + number.ToString();
               }
               if (number.ToString().Length == 1)
               {
                   txtOrderCode.Text = DateTime.Now.Year.ToString().Substring(2, 2) + "-000" + number.ToString();
               }
               if (number.ToString().Length == 4)
               {
                   txtOrderCode.Text = DateTime.Now.Year.ToString().Substring(2, 2) + "-" + number.ToString();
               }
              
           }
       }

    

       

      
     

     
       
    }
}