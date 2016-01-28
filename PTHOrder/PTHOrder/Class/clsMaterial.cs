using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PTHOrder.Class
{
    class clsMaterial
    {
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public byte[] Images { get; set; }
        public int Quota { get; set; } 
        public bool Active { get; set; }
        public string Groups { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
     //Store lấy dữ liệu table
        public DataTable tbMaterial_GetList()
        {
            string procname = "tbMaterial_GetList";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }
        //edit du lieu tu ma kho
        public DataTable tbMaterial_GetbyCode()
        {
            string procname = "tbMaterial_GetbyCode";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            db.AddParameter("@MaterialCode", MaterialCode);
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
                db.AddParameter("@MaterialCode", MaterialCode);
                db.AddParameter("@MaterialName", MaterialName);
                if (Images == null)
                {
                    db.AddParameter("@Images", DBNull.Value, "");
                }
                else
                {
                    db.AddParameter("@Images", Images);
                }
                db.AddParameter("@Quota", Quota);
                db.AddParameter("@Groups", Groups);
                db.AddParameter("@Minimum", Minimum);
                db.AddParameter("@Maximum", Maximum);
                db.AddParameter("@Active", Active);
                db.ExecuteNonQueryWithTransaction("tbMaterial_Insert");//thực thi store thêm
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
                db.AddParameter("@MaterialCode", MaterialCode);
                db.AddParameter("@MaterialName", MaterialName);
                if (Images == null)
                {
                    db.AddParameter("@Images", DBNull.Value, "");
                }
                else
                {
                    db.AddParameter("@Images",Images);
                }
                db.AddParameter("@Quota", Quota);
                db.AddParameter("@Groups", Groups);
                db.AddParameter("@Minimum", Minimum);
                db.AddParameter("@Maximum", Maximum);
                db.AddParameter("@Active", Active);
                db.ExecuteNonQueryWithTransaction("tbMaterial_Update");//thực thi store sua
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
                db.AddParameter("@MaterialCode", MaterialCode);// xóa dựa vào trường khóa 
                db.ExecuteNonQueryWithTransaction("tbMaterial_Delete");//thực thi store xóa
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

