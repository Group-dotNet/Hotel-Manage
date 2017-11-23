using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    class Deposit_BUS
    {
        private static Deposit_BUS instance;

        internal static Deposit_BUS Instance
        {
            get
            {
                if (instance == null) instance = new Deposit_BUS();  return Deposit_BUS.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Deposit_BUS() { }

        public int CountDepositReservation(int id_reservation)
        {
            try
            {
                return Deposit_DAO.Instance.CountDepositReservation(id_reservation);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public double Check_Deposit_Old(int id_reservation)
        {
            try
            {
                return Deposit_DAO.Instance.Check_Deposit_Old(id_reservation);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool InsertDeposit(int id_reservation, double deposit, bool confirm)
        {
            try
            {
                return Deposit_DAO.Instance.InsertDeposit(id_reservation, deposit, confirm);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public Deposit_DTO GetInfoDepositUsing(int id_reservation)
        {
            try
            {
                return Deposit_DAO.Instance.GetInfoDepositUsing(id_reservation);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public List<Deposit_DTO> GetListDepositReservation(int id_reservation)
        {
            try
            {
                return Deposit_DAO.Instance.GetListDepositReservation(id_reservation);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
