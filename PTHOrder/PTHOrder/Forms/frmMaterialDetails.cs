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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
namespace PTHOrder.Forms
{
    public partial class frmMaterialDetails : DevExpress.XtraEditors.XtraForm
    {
        
        public frmMaterialDetails()
        {
            InitializeComponent();
        }
        //void tbMaterialDetails_Getlist()
        //{
        //    Class.clsMaterialDetails cls = new Class.clsMaterialDetails();
        //    DataTable dt = cls.tbMaterialDetails_GetList();
        //    gridItem.DataSource = dt;
            
        //}
        void LoadLookupPlan_Getlist()
        {
            Class.clsPlancs cls = new Class.clsPlancs();
            DataTable dt = cls.tbPlan_GetList();
            cboYears.Properties.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboYears.Properties.Items.Add(dt.Rows[i]["Years"].ToString());
            }        
           
            
        
            // lookupYears.Properties.GetDataSourceRowIndex(lookupYears.Properties.Columns["OPER_ID"], _dtInfo.Rows[0]["TREATMAN"].ToString());
            // lookupYears.Properties.GetDataSourceRowIndex
        }
        private void frmMaterialDetails_Load(object sender, EventArgs e)
        {
            LoadLookupPlan_Getlist();
          
        }

     
      

        private void btnFind_Click(object sender, EventArgs e)
        {
            Class.clsMaterialDetails cls = new Class.clsMaterialDetails();
            DataTable dt = new DataTable();

            cls.Years=int.Parse(cboYears.EditValue.ToString());
            dt = cls.tbMaterialDetails_GetByYear();
            gridItem.DataSource = dt;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            Class.clsDistributionDetails cls = new Class.clsDistributionDetails();
            DataTable dt = new DataTable();
            dt = cls.tbDistributionDetails_GetList();
            
        }

     

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
       
    


    }
}