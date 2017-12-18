using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    public class Analytic_DAO
    {
        private static Analytic_DAO instance;

        internal static Analytic_DAO Instance
        {
            get { if (instance == null) instance = new Analytic_DAO(); return Analytic_DAO.instance; }
            private set { instance = value; }
        }

        private Analytic_DAO() { }

        public bool CountReservationInDay(DateTime date)
        {
            string query = "exec USP_CountReservationInDay_ @date";

            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] { date });
            return x == 1;

        }

        public bool CountRoomEmty()
        {
            string query = "exec USP_CountRoomEmty";

            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] {  });
            return x == 1;

        }

        public bool CountRoomUsing()
        {
            string query = "exec USP_CountRoomUsing";

            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] { });
            return x == 1;
        }

        public bool CountServiceUsingInDay(DateTime date)
        {
            string query = "exec USP_CountServiceUsingInDay_@date";

            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] { date });
            return x== 1;
        }

        public bool CountRevenueInDay(DateTime date)
        {
            string query = "exec USP_CountRevenueInDay_@date";

            int x = (int)Connect.Instance.ExecuteOutPut(query, new object[] { date });
            return x == 1;
        }

        public bool CountBillInDay(DateTime date)
        {
            string query = "exec USP_CountBillInDay_@date";

            int x = (int)Connect.Instance.ExecuteScalar(query, new object[] { });
            return x == 1;
        }

    }
}
