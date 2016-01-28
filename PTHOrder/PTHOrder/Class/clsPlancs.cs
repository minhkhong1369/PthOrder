using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace PTHOrder.Class
{
    class clsPlancs
    {
        //Store lấy dữ liệu table
        public DataTable tbPlan_GetList()
        {
            string procname = "tbPlan_GetList";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }
    }
}
