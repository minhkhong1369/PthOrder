using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;

namespace PTHOrder.Forms
{
    public partial class frmListSupplier : DevExpress.XtraEditors.XtraForm
    {
        public frmListSupplier()
        {
            InitializeComponent();
        }
        //load Grid view
        void tbSupplier_GetList()
        {
            Class.clsListSupplier cls = new Class.clsListSupplier();
            DataTable dt = cls.tbSupplier_GetList();
            gridItem.DataSource = dt;
        }
        private void frmListSupplier_Load(object sender, EventArgs e)
        {
            tbSupplier_GetList();
        }
         //Xử lý nút thêm
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            waiting.ShowWaitForm();
            Forms.frmListSupplier_Update frm = new frmListSupplier_Update();
            waiting.CloseWaitForm();
            frm.ShowDialog();
            tbSupplier_GetList();
           
        }
        //Xử lý nút xóa
        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (gridItemDetail.FocusedRowHandle > -1)
            {
                waiting.ShowWaitForm();
                string code = gridItemDetail.GetFocusedRowCellValue(colSupplierCode).ToString();
                Class.clsListSupplier cls = new Class.clsListSupplier();
                cls.SupplierCode = code;
                Class.clsListOrder clsorder = new Class.clsListOrder();
                DataTable dt = new DataTable();
                dt = clsorder.tbOrder_GetList();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["SupplierCode"].ToString() == cls.SupplierCode)
                    {
                        MessageBox.Show("Nhà cung cấp này đang còn đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                   
                     if (MessageBox.Show("Bạn có chắc chắn muốn xoá hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                cls.Delete();
                                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                tbSupplier_GetList();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                }
            }
            waiting.CloseWaitForm();
        }
      
        //Xử lý nút sửa
        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (gridItemDetail.FocusedRowHandle > -1)
            {
                waiting.ShowWaitForm(); 
                string code = gridItemDetail.GetFocusedRowCellValue(colSupplierCode).ToString();
                Forms.frmListSupplier_Update frm = new frmListSupplier_Update(code);
                waiting.CloseWaitForm();
                frm.ShowDialog();
                tbSupplier_GetList();
            }
            
        }
        //goi lai cac doi tuong them, xoa, sua, update
        private void btn_Add_Click(object sender, EventArgs e)
        {
            btnAdd_ItemClick(null, null);
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            btnEdit_ItemClick(null, null);
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            btnDelete_ItemClick(null,null);
        }
        private void gridItemDetail_DoubleClick(object sender, EventArgs e)
        {
            btn_Update_Click(null,null);
        }
        //xuat grid ra excel dang bang 
        private void btnExportFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridItem.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridItem.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridItem.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridItem.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridItem.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridItem.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }
                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
        }    
}

    