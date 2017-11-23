using app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class Deposit_DAO
    {
        private static Deposit_DAO instance;

        internal static Deposit_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Deposit_DAO(); return Deposit_DAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Deposit_DAO() { }


        public int CountDepositReservation(int id_reservation)
        {
            String query = "exec UPS_CountDeposit @id_reservation";
            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] { id_reservation });
            return x;
        }

        public bool InsertDeposit(int id_reservation , double deposit , bool confirm)
        {
            string query = "exec USP_InsertDeposit @id_reservation , @deposit , @confirm";
            Connect.Instance.ExecuteNonQuery(query, new object[] { id_reservation, deposit, confirm });
            return true;
        }

        public double Check_Deposit_Old(int id_reservation)
        {
            string query = "exec USP_CheckDepositPrev @id_reservation";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_reservation });
            Deposit_DTO deposit = new Deposit_DTO();
            foreach(DataRow item in table.Rows)
            {
                deposit.Deposit = (double)item["deposit"];
                break;
            }
            return deposit.Deposit;
        }

        public bool Check_Confirm(int id_reservation)
        {
            string query = "exec USP_CheckConfirm @id_reservation";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_reservation });
            Deposit_DTO deposit = new Deposit_DTO();
            foreach (DataRow item in table.Rows)
            {
                deposit.Confirm = (bool)item["confirm"];
                break;
            }
            return deposit.Confirm;
        }

        public List<Deposit_DTO> GetListDepositReservation(int id_reservation)
        {
            string query = "exec USP_GetListDeposit @id_reservation";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_reservation });
            List<Deposit_DTO> list_deposit = new List<Deposit_DTO>();
            foreach (DataRow item in table.Rows)
            {
                Deposit_DTO deposit = new Deposit_DTO();
                deposit.Id_deposit = (int)item["id_deposit"];
                deposit.Reservation.Id_reservation = (int)item["id_reservation"];
                deposit.Deposit = (double)((decimal)item["deposit"]);
                deposit.Confirm = (bool)item["confirm"];
                deposit.Created_confirm = (DateTime)item["created_confirm"];
                deposit.Locked = (bool)item["locked"];
                deposit.Note = item["note"].ToString();

                list_deposit.Add(deposit);
            }
            return list_deposit;
        }

        public Deposit_DTO GetInfoDepositUsing(int id_reservation)
        {
            string query = "exec USP_CheckConfirm @id_reservation";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_reservation });
            Deposit_DTO deposit = new Deposit_DTO();
            foreach(DataRow item in table.Rows)
            {
                deposit.Id_deposit = (int)item["id_deposit"];
                deposit.Reservation.Id_reservation = (int)item["id_reservation"];
                deposit.Deposit = (double)((decimal)item["deposit"]);
                deposit.Confirm = (bool)item["confirm"];
                deposit.Created_confirm = (DateTime)item["created_confirm"];
                deposit.Locked = (bool)item["locked"];
                deposit.Note = item["note"].ToString();
            }
            return deposit;
        }
    }
}
