﻿using System;
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
    public partial class frmListMaterial : DevExpress.XtraEditors.XtraForm
    {
        public frmListMaterial()
        {
            InitializeComponent();
        }
        //load Grid view
        void tbMaterial_GetList()
        {
            Class.clsMaterial cls = new Class.clsMaterial();
            DataTable dt = cls.tbMaterial_GetList();
            gridItem.DataSource = dt;

        }

        private void frmListMaterial_Load(object sender, EventArgs e)
        {
            tbMaterial_GetList();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // waiting.ShowWaitForm();
            Forms.frmListMaterial_Update frm = new frmListMaterial_Update();
            //waiting.CloseWaitForm();
            frm.ShowDialog();
            if (frm.save)
            {
                tbMaterial_GetList();
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridItemDetail.FocusedRowHandle > -1)
            {
                //waiting.ShowWaitForm();
                string code = gridItemDetail.GetFocusedRowCellValue(colMaterialCode).ToString();
                Forms.frmListMaterial_Update frm = new frmListMaterial_Update(code);
                // waiting.CloseWaitForm();
                frm.ShowDialog();
                if (frm.save)
                {
                    tbMaterial_GetList();
                }
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //waiting.ShowWaitForm();
            if (gridItemDetail.FocusedRowHandle > -1)//duyệt từ dòng đầu tiên trên lưới
            {
                string code = gridItemDetail.GetFocusedRowCellValue(colMaterialCode).ToString();
                Class.clsMaterial cls = new Class.clsMaterial();
                cls.MaterialCode = code;
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cls.Delete();
                        MessageBox.Show("Xóa thành công");
                        tbMaterial_GetList();
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
            btnAdd_ItemClick(null, null);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            btnEdit_ItemClick(null, null);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            btnDelete_ItemClick(null, null);
        }

        private void gridItemDetail_DoubleClick(object sender, EventArgs e)
        {
            btn_Update_Click(null, null);
        }

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
        private void gridItemDetail_CustomDrawRowIndicator_1(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gridItemDetail_DoubleClick_1(object sender, EventArgs e)
        {
            btn_Update_Click(null,null);
        }

        private void gridItemDetail_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                lblChoose.Text = "Đang chọn:[<b>" + gridItemDetail.GetFocusedRowCellValue(colMaterialName).ToString() + "</b>]";
            }
            catch { }
        }
   
    }
}