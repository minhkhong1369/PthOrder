using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PTHOrder.Class
{
    class clsStore
    {
        public string StoreCode { get; set; }
        public string StoreName { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; } 
     //Store lấy dữ liệu table
        public DataTable tbStore_GetList()
        {
            string procname = "tbStore_GetList";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }
        //store chèn dữ liệu vào table
        public bool Insert()
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();

            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@StoreCode", StoreCode);
                db.AddParameter("@StoreName", StoreName);
                db.AddParameter("@Address", Address);
                db.AddParameter("@Telephone", Telephone);
                db.ExecuteNonQueryWithTransaction("tbStore_Insert");//thực thi store thêm
                db.CommitTransaction();
                return true;
            }
            catch
            {
                db.RollbackTransaction();
                return false;
            }
        }
        //Store cập nhật dữ liệu table
        public bool Update()
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();

            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@StoreCode", StoreCode);
                db.AddParameter("@StoreName", StoreName);
                db.AddParameter("@Address", Address);
                db.AddParameter("@Telephone", Telephone);
                db.ExecuteNonQueryWithTransaction("tbStore_Update");//thực thi store sửa
                db.CommitTransaction();
                return true;
            }
            catch
            {
                db.RollbackTransaction();
                return false;
            }
        }
        //Store xóa dữ liệu table
        public bool Delete()
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();
            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@StoreCode", StoreCode);// xóa dựa vào trường khóa 
                db.ExecuteNonQueryWithTransaction("tbStore_Delete");//thực thi store xóa
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
