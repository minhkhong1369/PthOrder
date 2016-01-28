using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PTHOrder.Class
{
    class clsMaterialDetails
    {
        public string MaterialCode { get; set; }
        public string StoreCode { get; set; }
        public int Years { get; set; }
        public int JanuaryIn { get; set; }
        public int JanuaryOut { get; set; }
        public int FebruaryIn { get; set; }
        public int FebruaryOut { get; set; }
        public int MarchIn { get; set; }
        public int MarchOut { get; set; }
        public int ApriIn { get; set; }
        public int ApriOut { get; set; }
        public int MayIn { get; set; }
        public int MayOut { get; set; }
        public int JuneIn { get; set; }
        public int JuneOut { get; set; }
        public int JulyIn { get; set; }
        public int JulyOut { get; set; }
        public int AugustIn { get; set; }
        public int AugustOut { get; set; }
        public int SeptemberIn { get; set; }
        public int SeptemberOut { get; set; }
        public int OctoberIn { get; set; }
        public int OctoberOut { get; set; }
        public int NovemberIn { get; set; }
        public int NovemberOut { get; set; }
        public int DecemberIn { get; set; }
        public int DecemberOut { get; set; }
        public int InventoryNew { get; set; }
        public int InventoryOld { get; set; }
        //Store lấy dữ liệu table
        public DataTable tbMaterialDetails_GetList()
        {
            string procname = "tbMaterialDetails_GetList";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }
        public DataTable tbMaterialDetails_GetByYear()
        {
            string procname = "tbMaterialDetails_GetByYear";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            db.AddParameter("@Years", Years);
            return db.ExecuteDataTable(procname);
        }
        //store chèn dữ liệu vào table
       


    }
}
