using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PTHOrder.Class
{
    class clsLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public DataTable tbLogin_Get()
        {
            string procname = "tbLogin_Get";
            DbAccess db = new DbAccess();       
            db.CreateNewSqlCommand();
            db.AddParameter("@Username", Username);
            db.AddParameter("@Password", Password);
            return db.ExecuteDataTable(procname);
        }
        //Store cập nhật dữ liệu table
        public bool Update()
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();

            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@Username", Username);
                db.AddParameter("@Password", Password);
               
                db.ExecuteNonQueryWithTransaction("tbLogin_UpdatePass");//thực thi store sửa
                db.CommitTransaction();
                return true;
            }
            catch
            {
                db.RollbackTransaction();
                return false;
            }
        }
    }
}
