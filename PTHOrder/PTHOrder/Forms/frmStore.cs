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
    public partial class frmStore : DevExpress.XtraEditors.XtraForm
    {
        public frmStore()
        {
            InitializeComponent();
        }
        //load Grid view
        void tbStore_Get()
        {
            Class.clsStore cls = new Class.clsStore();
            DataTable dt = cls.tbStore_GetList();
            gridItem.DataSource = dt;

        }
        private void frmStore_Load(object sender, EventArgs e)
        {
            tbStore_Get();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // waiting.ShowWaitForm();
            Forms.frmStore_Update frm = new frmStore_Update();
            //waiting.CloseWaitForm();
            frm.ShowDialog();
            tbStore_Get();
        }

        
    }
}