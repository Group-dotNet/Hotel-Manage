using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    class Bill_BUS
    {
        private static Bill_BUS instance;

        internal static Bill_BUS Instance
        {
            get
            {
                if (instance == null) instance = new Bill_BUS(); return Bill_BUS.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Bill_BUS() { }

        public List<Bill_DTO> GetListBill()
        {
            try
            {
                return Bill_DAO.Instance.GetListBill();
            }
            catch (SqlException e)
            {
                System.Console.WriteLine(e.ToString());
                throw new Exception("Error!");
            }
        }

        public Bill_DTO GetInfoBill(int id_bill)
        {
            try
            {
                return Bill_DAO.Instance.GetInfoBill(id_bill);
            }
            catch(SqlException e)
            {
                System.Console.WriteLine(e.ToString());
                throw new Exception("Error!");
            }
        }

        public bool CheckConfirmBill(int id_bill)
        {
            try
            {
                return Bill_DAO.Instance.CheckConfirmBill(id_bill);
            }
            catch (SqlException e)
            {
                System.Console.WriteLine(e.ToString());
                throw new Exception("Error!");
            }
        }

        public int InsertBill(int id_reservation, string username)
        {
            try
            {
                return Bill_DAO.Instance.InsertBill(id_reservation, username);
            }
            catch(SqlException e)
            {
                System.Console.WriteLine(e.ToString());
                throw new Exception("Error!");
            }
        }

        public bool UpdateBill(int id_bill, double money, string username)
        {
            try
            {
                return Bill_DAO.Instance.UpdateBill(id_bill, money, username);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public List<Bill_DTO> SearchBill(int id_type, string keyword)
        {
            try
            {
                return Bill_DAO.Instance.SearchBill(id_type, keyword);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
