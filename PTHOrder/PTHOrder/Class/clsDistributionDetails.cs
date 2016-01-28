using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PTHOrder.Class
{
    class clsDistributionDetails
    {
        public int ID{ get; set;}
        public string DistributionCode { get; set; }
        public DateTime Date_Out { get; set; }
        public int Number_Out { get; set; }
        //Store lay du lieu
        public DataTable tbDistributionDetails_GetList()
        {
            string procname = "tbDistributionDetails_GetList()";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        
        }


    }
}
