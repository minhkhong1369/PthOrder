using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraReports.UI;
using Excel = Microsoft.Office.Interop.Excel;
using DevExpress.XtraGrid.Views.Grid;


namespace PTHOrder.Forms
{
    public partial class frmListOrder : DevExpress.XtraEditors.XtraForm
    {
        public frmListOrder()
        {
            InitializeComponent();
        }

      
        //load Grid view
        void tbOrder_GetList()
        {
            Class.clsListOrder cls = new Class.clsListOrder();
            DataTable dt = cls.tbOrder_GetList();
            gridItem.DataSource = dt;

        }
        private void frmListOrder_Load(object sender, EventArgs e)
        {
            tbOrder_GetList();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            waiting.ShowWaitForm();
            Forms.frmListOrder_Update frm = new frmListOrder_Update();
            waiting.CloseWaitForm();
            frm.ShowDialog();
            if (frm.save)
            {
                tbOrder_GetList();
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // waiting.ShowWaitForm();
            if (gridItemDetail.FocusedRowHandle > -1)
            {
                string code = gridItemDetail.GetFocusedRowCellValue(colOrderCode).ToString();//lấy Ordercode từ vị trí trên grid
                Forms.frmListOrder_Update frm = new frmListOrder_Update(code);
                frm.ShowDialog();
                if (frm.save)
                {
                    tbOrder_GetList();
                }                
            }
           // waiting.CloseWaitForm();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (gridItemDetail.FocusedRowHandle > -1)//duyệt từ dòng đầu tiên trên lưới
            {
                string code = gridItemDetail.GetFocusedRowCellValue(colOrderCode).ToString();
                Class.clsListOrder cls = new Class.clsListOrder();
                cls.OrderCode = code;
               

                    if (MessageBox.Show("Bạn có chắc chắn muốn xoá hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            cls.Delete();
                            MessageBox.Show("Xóa thành công");
                            tbOrder_GetList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                
            }
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            btnAdd_ItemClick(null,null);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            btnEdit_ItemClick(null, null);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            btnDelete_ItemClick(null, null);
        }

        private void btnChoDuyet_Click(object sender, EventArgs e)
        {
            string txt = "Chờ duyệt";
            Class.clsListOrder cls = new Class.clsListOrder();
            string code = gridItemDetail.GetFocusedRowCellValue(colOrderCode).ToString();
            //cập nhật chuỗi txt dựa cào OrderCode
            cls.OrderCode = code;
            cls.Status = txt;
            cls.UpdateStatus();
            tbOrder_GetList();
        }

        private void btnDaDuyet_Click(object sender, EventArgs e)
        {
            string txt = "Đã duyệt";
            Class.clsListOrder cls = new Class.clsListOrder();
            string code = gridItemDetail.GetFocusedRowCellValue(colOrderCode).ToString();
            cls.OrderCode = code;
            cls.Status = txt;
            cls.UpdateStatus();
            tbOrder_GetList();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string txt = "Hủy";
            Class.clsListOrder cls = new Class.clsListOrder();
            string code = gridItemDetail.GetFocusedRowCellValue(colOrderCode).ToString();
            cls.OrderCode = code;
            cls.Status = txt;
            cls.UpdateStatus();
            tbOrder_GetList();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            string txt = "Hoàn thành";
            Class.clsListOrder cls = new Class.clsListOrder();
            string code = gridItemDetail.GetFocusedRowCellValue(colOrderCode).ToString();
            cls.OrderCode = code;
            cls.Status = txt;
            cls.UpdateStatus();
            tbOrder_GetList();
        }

        private void gridItemDetail_DoubleClick(object sender, EventArgs e)
        {
            btn_Update_Click(null, null);
        }
        //xuat du lieu tu grid ra table file excel
        private void btnExportFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridItemDetail.SelectedRowsCount > 0)
                {
                    int[] selectedRows = gridItemDetail.GetSelectedRows();

                    object[] result = new object[selectedRows.Length];
                    DataTable dt = new DataTable();
                    dt.Columns.Add("SoHD");
                    dt.Columns.Add("NgayDN");
                    dt.Columns.Add("NhaCC");
                    dt.Columns.Add("MoTa");
                    dt.Columns.Add("SoLuong");
                    dt.Columns.Add("DonVi");
                    dt.Columns.Add("Gia");
                    dt.Columns.Add("ThanhTien");
                    dt.Columns.Add("VAT");

                    for (int i = 0; i < selectedRows.Length; i++)
                    {
                        int rowHandle = selectedRows[i];
                        if (!gridItemDetail.IsGroupRow(rowHandle))
                        {
                            result[i] = gridItemDetail.GetRowCellValue(rowHandle, colOrderCode);
                            DataRow dr = dt.NewRow();
                            dr["SoHD"] = gridItemDetail.GetRowCellValue(rowHandle, colOrderCode);
                            dr["NgayDN"] = "'" + ((DateTime)gridItemDetail.GetRowCellValue(rowHandle, colDateSuggest)).ToString("dd/MM/yyyy");
                            dr["NhaCC"] = gridItemDetail.GetRowCellValue(rowHandle, colSupplierName);
                            Class.clsListOrder cls = new Class.clsListOrder();
                            //xu ly in cac chi tiet hoa don tu vi tri tren luoi dua vao ordercode
                            string code = gridItemDetail.GetRowCellValue(rowHandle, colOrderCode).ToString();
                            cls.OrderCode = code;
                            DataTable dtct = cls.tbOrderDetails_GetByCode();
                           
                            if (dtct.Rows.Count > 0)
                            {
                                dr["MoTa"] = dtct.Rows[0]["Describe"].ToString();
                                dr["SoLuong"] = dtct.Rows[0]["Number"].ToString();
                                dr["DonVi"] = dtct.Rows[0]["Unit"].ToString();
                                dr["Gia"] = dtct.Rows[0]["Price"].ToString();
                                dr["ThanhTien"] = dtct.Rows[0]["Monetize"].ToString();
                            }
                            dr["VAT"] = gridItemDetail.GetRowCellValue(rowHandle, colVAT);
                            dt.Rows.Add(dr);
                            int soct = dtct.Rows.Count;
                            if (soct > 1)
                            {
                                for (int ii = 1; ii < soct; ii++)
                                {
                                    DataRow dr1 = dt.NewRow();
                                    dr1["MoTa"] = dtct.Rows[ii]["Describe"].ToString();
                                    dr1["SoLuong"] = dtct.Rows[ii]["Number"].ToString();
                                    dr1["DonVi"] = dtct.Rows[ii]["Unit"].ToString();
                                    dr1["Gia"] = dtct.Rows[ii]["Price"].ToString();
                                    dr1["ThanhTien"] = dtct.Rows[ii]["Monetize"].ToString();
                                    dt.Rows.Add(dr1);
                                }
                            }
                        }
                    }

                    // xuat excel
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Filter = "Excel File|*.xls";
                    saveFile.Title = "Exprot to Excel File";
                    saveFile.ShowDialog();
                    if (saveFile.FileName != "")
                    {
                        Excel.Application xlApp;

                        Excel.Workbook xlWorkBook;

                        Excel.Worksheet xlWorkSheet;

                        object misValue = System.Reflection.Missing.Value;


                        xlApp = new Excel.Application();

                        xlWorkBook = xlApp.Workbooks.Add(misValue);

                        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                        xlWorkSheet.Cells[1, 1] = "Số HĐ";
                        xlWorkSheet.Cells[1, 2] = "Ngày đề nghị";
                        xlWorkSheet.Cells[1, 3] = "Nhà Cung cấp";
                        xlWorkSheet.Cells[1, 4] = "Mô tả";
                        xlWorkSheet.Cells[1, 5] = "Số lượng";
                        xlWorkSheet.Cells[1, 6] = "Đơn vị tính";
                        xlWorkSheet.Cells[1, 7] = "Đơn Giá";
                        xlWorkSheet.Cells[1, 8] = "Thành tiền";
                        xlWorkSheet.Cells[1, 9] = "VAT";

                        object[,] Array_Record;
                        Array_Record = new object[dt.Rows.Count, dt.Columns.Count];
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            for (int j = 0; j < dt.Columns.Count; j++)
                            {
                                Array_Record[i, j] = dt.Rows[i][j].ToString();
                            }
                        }
                        xlWorkSheet.get_Range("A2", "I" + (dt.Rows.Count + 1)).Value = Array_Record;

                        xlWorkBook.SaveAs(saveFile.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                        xlWorkBook.Close(true, misValue, misValue);

                        xlApp.Quit();

                        releaseObject(xlWorkSheet);
                        releaseObject(xlWorkBook);
                        releaseObject(xlApp);
                        MessageBox.Show("Xuất file thành công !..");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.ToString());
            }
        }    
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }

            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
//In đơn đặt hàng ra report
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (gridItemDetail.FocusedRowHandle > -1)
            {
                string code = gridItemDetail.GetFocusedRowCellValue(colOrderCode).ToString();//lấy Ordercode từ vị trí trên grid
                // Create a report. 
                Reports.rptListOrder report = new Reports.rptListOrder();
                Class.clsListOrder cls = new Class.clsListOrder();
                cls.OrderCode=code;
                DataTable dt = cls.tbOrderReport_GetByCode();
                
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("Chi tiết đơn hàng chưa được nhập. vui lòng nhập chi tiết đơn hàng trước..");
                    return;
                }
                dt.Columns.Add("STT");
                dt.Columns.Add("SubTotal", typeof(Double));
                dt.Columns.Add("SubTotalAll", typeof(Double));
                dt.Columns.Add("SubTotalByWord");
                dt.Columns.Add("SubTotal_VAT", typeof(Double));
                bool tienusd = false;
                string txt = "";
                Double _SubTotal = 0;
                Double _vat = Double.Parse(dt.Rows[0]["VAT"].ToString());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                    _SubTotal = _SubTotal + Double.Parse(dt.Rows[i]["Monetize"].ToString());

                }
                /// kiem tra tien le
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txt = dt.Rows[0]["Monetize"].ToString(); //_TongTienAll.ToString("F");
                    if (txt.EndsWith(".00"))
                    {
                        tienusd = false;
                    }
                    else if (txt.IndexOf('.') < 0)
                    {
                        tienusd = false;
                    }
                    else if (txt == "0.0000")
                    {
                        tienusd = false;
                    }
                    else
                    {
                        tienusd = true;
                        break;
                    }
                }

                Double _SubTotalAll = _SubTotal + (_SubTotal * _vat) / 100;
                string _MoneyByWord = SwitchToNumber(_SubTotalAll.ToString("F0")) + "đồng";
                Double _SubTotal_VAT = (_SubTotal * _vat) / 100;

                if (tienusd)
                    _MoneyByWord = "";
                if (txt == "0.0000")
                    _MoneyByWord = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["SubTotal"] = _SubTotal;
                    dt.Rows[i]["SubTotalAll"] = _SubTotalAll;
                    dt.Rows[i]["SubTotalByWord"] = _MoneyByWord;
                    dt.Rows[i]["SubTotal_VAT"] = _SubTotal_VAT;
                }
                
                if (tienusd)
                    report= new Reports.rptListOrder("usd");
                else
                    report = new Reports.rptListOrder();
                report.DataSource = dt;
                // Show the report's preview.;
                // ReportPrintTool tool = new ReportPrintTool(report);
                // tool.ShowPreview();
                report.ShowPreview();
                 //report.ShowDesigner();
            }
        }
            private string SwitchToNumber(string number)
            {
                try
                {

                    string[] dv = { "", "mươi", "trăm", "ngàn", "triệu", "tỉ" };
                    string[] cs = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                    string doc;
                    int i, j, k, n, len, found, ddv, rd;

                    len = number.Length;
                    number += "ss";
                    doc = "";
                    found = 0;
                    ddv = 0;
                    rd = 0;

                    i = 0;
                    while (i < len)
                    {
                        //So chu so o hang dang duyet
                        n = (len - i + 2) % 3 + 1;

                        //Kiem tra so 0
                        found = 0;
                        for (j = 0; j < n; j++)
                        {
                            if (number[i + j] != '0')
                            {
                                found = 1;
                                break;
                            }
                        }

                        //Duyet n chu so
                        if (found == 1)
                        {
                            rd = 1;
                            for (j = 0; j < n; j++)
                            {
                                ddv = 1;
                                switch (number[i + j])
                                {
                                    case '0':
                                        if (n - j == 3) doc += cs[0] + " ";
                                        if (n - j == 2)
                                        {
                                            if (number[i + j + 1] != '0') doc += "lẻ ";
                                            ddv = 0;
                                        }
                                        break;
                                    case '1':
                                        if (n - j == 3) doc += cs[1] + " ";
                                        if (n - j == 2)
                                        {
                                            doc += "mười ";
                                            ddv = 0;
                                        }
                                        if (n - j == 1)
                                        {
                                            if (i + j == 0) k = 0;
                                            else k = i + j - 1;

                                            if (number[k] != '1' && number[k] != '0')
                                                doc += "mốt ";
                                            else
                                                doc += cs[1] + " ";
                                        }
                                        break;
                                    case '5':
                                        if (i + j == len - 1)
                                            doc += "lăm ";
                                        else
                                            doc += cs[5] + " ";
                                        break;
                                    default:
                                        doc += cs[(int)number[i + j] - 48] + " ";
                                        break;
                                }

                                //Doc don vi nho
                                if (ddv == 1)
                                {
                                    doc += dv[n - j - 1] + " ";
                                }
                            }
                        }


                        //Doc don vi lon
                        if (len - i - n > 0)
                        {
                            if ((len - i - n) % 9 == 0)
                            {
                                if (rd == 1)
                                    for (k = 0; k < (len - i - n) / 9; k++)
                                        doc += "tỉ ";
                                rd = 0;
                            }
                            else
                                if (found != 0) doc += dv[((len - i - n + 1) % 9) / 3 + 2] + " ";
                        }

                        i += n;
                    }

                    if (len == 1)
                        if (number[0] == '0' || number[0] == '5') return cs[(int)number[0] - 48];

                    doc = doc.Replace("  ", " ");
                    doc = doc.Replace("  ", " ");
                    doc = doc.Replace("mươi năm", "mươi lăm");
                    doc = doc.Replace("mười năm", "mười lăm");
                    return doc;
                }
                catch
                {
                    return "";
                }
            }
        //tao cot stt tren grid
            bool indicatorIcon = true;
            private void gridItemDetail_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
            {
                GridView view = (GridView)sender;
                //Check whether the indicator cell belongs to a data row
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    if (!indicatorIcon)
                        e.Info.ImageIndex = -1;
                }
            }

            private void gridItemDetail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {
                lblChoose.Text = "Đang chọn:[<b>" + gridItemDetail.GetFocusedRowCellValue(colOrderCode).ToString() + "</b>]";
            }
          }          
 }

       
    
