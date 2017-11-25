using app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class Bill_DAO
    {
        private static Bill_DAO instance;

        internal static Bill_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Bill_DAO(); return Bill_DAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Bill_DAO() { }

        public List<Bill_DTO> GetListBill()
        {
            string query = "exec USP_GetListBill";
            DataTable table = Connect.Instance.ExecuteQuery(query);
            List<Bill_DTO> list_bill = new List<Bill_DTO>();
            foreach(DataRow item in table.Rows)
            {
                Bill_DTO bill = new Bill_DTO();
                bill.Id_bill = (int)item["id_bill"];
                bill.Reservation.Id_reservation = (int)item["id_reservation"];
                bill.Total_money = (double)((decimal)item["total_money"]);
                bill.Staff.Username = item["username"].ToString();
                bill.Confirm = (bool)item["confirm"]; 
                bill.Note = item["note"].ToString();
                bill.Created = (DateTime)item["created"];
                list_bill.Add(bill);
            }
            return list_bill;
        }


        public Bill_DTO GetInfoBill(int id_bill)
        {
            string query = "exec USP_GetInfoBill @id_bill";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_bill });
            Bill_DTO bill = new Bill_DTO();
            foreach(DataRow item  in table.Rows)
            {
                bill.Id_bill = (int)item["id_bill"];
                bill.Reservation.Id_reservation = (int)item["id_reservation"];
                bill.Total_money = (double)((decimal)item["total_money"]);
                bill.Staff.Username = item["username"].ToString();
                bill.Confirm = (bool)item["confirm"]; 
                bill.Note = item["note"].ToString();
                bill.Created = (DateTime)item["created"];
            }

            return bill;
        }

        public bool CheckConfirmBill(int id_bill)
        {
            string query = "exec USP_CheckConfirm_Bill @id_bill";
            int x = (int)Connect.Instance.ExecuteOutPut(query, new object[] { id_bill });
            return x == 1;
        }

        public int InsertBill(int id_reservation, string username)
        {
            string query = "exec USP_InsertBill @id_reservation , @username";
            int id_bill = (int)Connect.Instance.ExecuteOutPut(query, new object[] { id_reservation, username });
            return id_bill;
        }

        public bool UpdateBill(int id_bill, double money, string username)
        {
            string query = "exec USP_UpdateBill @id_bill , @total_money , @username";
            int x = (int)Connect.Instance.ExecuteOutPut(query, new object[] { id_bill, money, username });
            return x == 1;
        }
    }
}
