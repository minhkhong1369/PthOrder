using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PTHOrder.Class
{
    class clsListSupplier
    {
        //khai báo biến các Feild của table
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public string Group { get; set; }
        public string Contact { get; set; }
        public string Note { get; set; }
        //Store lấy dữ liệu table
        public DataTable tbSupplier_GetList()
        {
            string procname = "tbSupplier_GetList";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }
        
        public DataTable tbSupplier_Get()
        {
            string procname = "tbSupplier_Get";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            db.AddParameter("@SupplierCode", SupplierCode);
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
                db.AddParameter("@SupplierCode", SupplierCode);
                db.AddParameter("@SupplierName", SupplierName);
                db.AddParameter("@Address", Address);
                db.AddParameter("@Telephone", Telephone);
                db.AddParameter("@Mail", Mail);
                db.AddParameter("@Group", Group);
                db.AddParameter("@Contact", Contact);
                db.AddParameter("@Note", Note);
                db.ExecuteNonQueryWithTransaction("tbSupplier_Insert");//thực thi store thêm
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
                db.AddParameter("@SupplierCode", SupplierCode);
                db.AddParameter("@SupplierName", SupplierName);
                db.AddParameter("@Address", Address);
                db.AddParameter("@Telephone", Telephone);
                db.AddParameter("@Mail", Mail);
                db.AddParameter("@Group", Group);
                db.AddParameter("@Contact", Contact);
                db.AddParameter("@Note", Note);
                db.ExecuteNonQueryWithTransaction("tbSupplier_Update");//thực thi store sửa
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
                db.AddParameter("@SupplierCode", SupplierCode);// xóa dựa vào trường khóa 
                db.ExecuteNonQueryWithTransaction("tbSupplier_Delete");//thực thi store xóa
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
