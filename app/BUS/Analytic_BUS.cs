using app.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    public class Analytic_BUS
    {
        private static Analytic_BUS instance;

        internal static Analytic_BUS Instance
        {
            get { if (instance == null) instance = new Analytic_BUS(); return Analytic_BUS.instance; }
            private set { instance = value; }
        }

        private Analytic_BUS() { }

        public bool CountReservationInDay(DateTime date)
        {
            try
            {
                return Analytic_DAO.Instance.CountReservationInDay(date);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool CountRoomEmty()
        {
            try
            {
                return Analytic_DAO.Instance.CountRoomEmty();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool CountRoomUsing()
        {
            try
            {
                return Analytic_DAO.Instance.CountRoomUsing();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool CountServiceUsingInDay(DateTime date)
        {
            try
            {
                return Analytic_DAO.Instance.CountServiceUsingInDay(date);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool CountRevenueInDay(DateTime date)
        {
            try
            {
                return Analytic_DAO.Instance.CountRevenueInDay(date);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool CountBillInDay(DateTime date)
        {
            try
            {
                return Analytic_DAO.Instance.CountBillInDay(date);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }



    }
}
