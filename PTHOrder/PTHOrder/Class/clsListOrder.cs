using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PTHOrder.Class
{
    class clsListOrder
    {
        //khai báo biến các Feild của table tbOrder
        public string OrderCode { get; set; }
        public DateTime DateSuggest { get; set; }
        public string Followers { get; set; }
        public string SupplierCode { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string PlaceOfDelivery { get; set; }
        public string PaymentConditions { get; set; }
        public string CurrencyUnit { get; set; }
        public int VAT { get; set; }
        public string Status { get; set; }
        //khai báo biến các Feild của table tbOrderDetails
        public int OrderDetailCode { get; set; }
        public string Describe { get; set; }
        public int Number { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public double Monetize { get; set; }
        public string SupplierSuggest { get; set; }
        public int Year { get; set; }

        //Store lấy dữ liệu table
        public DataTable tbOrder_GetList()
        {
            string procname = "tbOrder_GetList";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }
        public DataTable tbOrderDetails_GetList()
        {
            string procname = "tbOrderDetails_GetList";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }
        
        //Store lấy dữ liệu table 
        public DataTable tbOrderDetails_GetByCode()
        {
            string procname = "tbOrderDetails_GetByCode";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            db.AddParameter("@OrderCode", OrderCode);
            return db.ExecuteDataTable(procname);
        }
        public DataTable tbOrderReport_GetByCode()
        {
            string procname = "tbOrderReport_GetByCode";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            db.AddParameter("@OrderCode", OrderCode);
            return db.ExecuteDataTable(procname);
        }
        public DataTable tbOrder_GetAutocode()
        {
            string procname = "tbOrder_GetAutocode";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            db.AddParameter("@Year", Year);
            return db.ExecuteDataTable(procname);
        }
       
        public DataTable tbOrder_Get()
        {
            string procname = "tbOrder_Get";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            db.AddParameter("@OrderCode", OrderCode);
            return db.ExecuteDataTable(procname);
        }
        //store chèn dữ liệu vào table
        public bool Insert(DataTable dtOrderDetail)
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();

            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@OrderCode", OrderCode);
                db.AddParameter("@DateSuggest", DateSuggest);
                db.AddParameter("@Followers", Followers);
                db.AddParameter("@SupplierCode", SupplierCode);
                db.AddParameter("@DeliveryDate", DeliveryDate);
                db.AddParameter("@PlaceOfDelivery", PlaceOfDelivery);
                db.AddParameter("@PaymentConditions", PaymentConditions);
                db.AddParameter("@VAT", VAT);
                db.AddParameter("@CurrencyUnit", CurrencyUnit);
                db.ExecuteNonQueryWithTransaction("tbOrder_Insert");//thực thi store chèn
                for (int i = 0; i < dtOrderDetail.Rows.Count; i++)
                {                   
                    Describe = dtOrderDetail.Rows[i]["Describe"].ToString();
                    Number = int.Parse(dtOrderDetail.Rows[i]["Number"].ToString());
                    Unit = dtOrderDetail.Rows[i]["Unit"].ToString();
                    Price = double.Parse(dtOrderDetail.Rows[i]["Price"].ToString());
                    if (dtOrderDetail.Rows[i]["Monetize"] == DBNull.Value)
                    {
                        Monetize = 0;
                    }else
                    {
                        Monetize = double.Parse(dtOrderDetail.Rows[i]["Monetize"].ToString());
                    }
                    SupplierSuggest = dtOrderDetail.Rows[i]["SupplierSuggest"].ToString();
                    db.CreateNewSqlCommand();
                    db.AddParameter("@OrderCode", OrderCode);
                    db.AddParameter("@Describe", Describe);
                    db.AddParameter("@Number", Number);
                    db.AddParameter("@Unit", Unit);
                    db.AddParameter("@Price", Price);
                    db.AddParameter("@Monetize", Monetize);
                    db.AddParameter("@SupplierSuggest", SupplierSuggest);
                    db.ExecuteNonQueryWithTransaction("tbOrderDetail_Insert");

                } 

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
    
        //update 2

        public bool Update(DataTable dtOrderDetail, DataTable dtOrderDetailTemp)
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();

            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@OrderCode", OrderCode);
                db.AddParameter("@DateSuggest", DateSuggest);
                db.AddParameter("@Followers", Followers);
                db.AddParameter("@SupplierCode", SupplierCode);
                db.AddParameter("@DeliveryDate", DeliveryDate);
                db.AddParameter("@PlaceOfDelivery", PlaceOfDelivery);
                db.AddParameter("@PaymentConditions", PaymentConditions);
                db.AddParameter("@VAT", VAT);
                db.AddParameter("@CurrencyUnit", CurrencyUnit);
                db.ExecuteNonQueryWithTransaction("tbOrder_Update");//begin thực thi store cập nhật dữ liệu 
                for (int i = 0; i < dtOrderDetail.Rows.Count; i++)
                {
                    if (dtOrderDetail.Rows[i]["OrderDetailCode"] == DBNull.Value)//dua vao OrderDetailCode de them or sua
                    {
                        Describe = dtOrderDetail.Rows[i]["Describe"].ToString();
                        Number = int.Parse(dtOrderDetail.Rows[i]["Number"].ToString());
                        Unit = dtOrderDetail.Rows[i]["Unit"].ToString();
                        Price = double.Parse(dtOrderDetail.Rows[i]["Price"].ToString());
                        if (dtOrderDetail.Rows[i]["Monetize"] == DBNull.Value)
                        {
                            Monetize = 0;
                        }
                        else
                        {
                            Monetize = double.Parse(dtOrderDetail.Rows[i]["Monetize"].ToString());
                        }
                        SupplierSuggest = dtOrderDetail.Rows[i]["SupplierSuggest"].ToString();
                        db.CreateNewSqlCommand();
                        db.AddParameter("@OrderCode", OrderCode);
                        db.AddParameter("@Describe", Describe);
                        db.AddParameter("@Number", Number);
                        db.AddParameter("@Unit", Unit);
                        db.AddParameter("@Price", Price);
                        db.AddParameter("@Monetize", Monetize);
                        db.AddParameter("@SupplierSuggest", SupplierSuggest);
                        db.ExecuteNonQueryWithTransaction("tbOrderDetail_Insert");
                    }
                    else
                    {
                        OrderDetailCode =int.Parse(dtOrderDetail.Rows[i]["OrderDetailCode"].ToString());
                        Describe = dtOrderDetail.Rows[i]["Describe"].ToString();
                        Number = int.Parse(dtOrderDetail.Rows[i]["Number"].ToString());
                        Unit = dtOrderDetail.Rows[i]["Unit"].ToString();
                        Price = double.Parse(dtOrderDetail.Rows[i]["Price"].ToString());
                        if (dtOrderDetail.Rows[i]["Monetize"] == DBNull.Value)
                        {
                            Monetize = 0;
                        }
                        else
                        {
                            Monetize = double.Parse(dtOrderDetail.Rows[i]["Monetize"].ToString());
                        }
                        SupplierSuggest = dtOrderDetail.Rows[i]["SupplierSuggest"].ToString();
                        db.CreateNewSqlCommand();
                        db.AddParameter("@OrderDetailCode", OrderDetailCode);
                        db.AddParameter("@Describe", Describe);
                        db.AddParameter("@Number", Number);
                        db.AddParameter("@Unit", Unit);
                        db.AddParameter("@Price", Price);
                        db.AddParameter("@Monetize", Monetize);
                        db.AddParameter("@SupplierSuggest", SupplierSuggest);
                        db.ExecuteNonQueryWithTransaction("tbOrderDetail_Update");
                    }                    
                }
                //xoa het du lieu bang OrderDetails truyen tu OrderDetailCode bang tam, chi chinh sua moi xoa
                for (int i = 0; i < dtOrderDetailTemp.Rows.Count; i++)
                {
                    OrderDetailCode = int.Parse(dtOrderDetailTemp.Rows[i]["OrderDetailCode"].ToString());
                    db.CreateNewSqlCommand();
                    db.AddParameter("@OrderDetailCode", OrderDetailCode);
                    db.ExecuteNonQueryWithTransaction("tbOrderDetail_Delete");
                }
                db.CommitTransaction();//end 
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
                db.AddParameter("@OrderCode", OrderCode);// xóa dựa vào trường khóa 
                db.ExecuteNonQueryWithTransaction("tbOrder_Delete");//thực thi store xóa dữ liệu
                db.CommitTransaction();
                return true;
            }
            catch
            {
                db.RollbackTransaction();
                return false;
            }
        }

        //Store cập nhật trạng thái
        public bool UpdateStatus()
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();

            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@OrderCode", OrderCode);
                db.AddParameter("@Status", Status);
                
                db.ExecuteNonQueryWithTransaction("tbOrder_Status");//thực thi store 
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
