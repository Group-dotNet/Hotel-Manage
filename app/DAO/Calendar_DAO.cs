using app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DAO
{
    class Calendar_DAO
    {
        private static Calendar_DAO instance;

        internal static Calendar_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Calendar_DAO(); return Calendar_DAO.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Calendar_DAO() { }

        public List<Calendar_DTO> GetListCalendar()
        {
            string query = "exec USP_GetListCalendar";
            DataTable table = Connect.Instance.ExecuteQuery(query);
            List<Calendar_DTO> list_calendar = new List<Calendar_DTO>();
            foreach(DataRow item in table.Rows)
            {
                Calendar_DTO calendar = new Calendar_DTO(item);
                list_calendar.Add(calendar);
            }
            return list_calendar;
        }

        public Calendar_DTO GetCalendarReservation(int id_reservation)
        {
            string query = "exec USP_GetCalendarReservation @id_reservation";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_reservation });
            Calendar_DTO calendar = null;
            foreach (DataRow item in table.Rows)
            {
                calendar = new Calendar_DTO(item);
            }
            return calendar;
        }

        public Calendar_DTO GetInfoCalendar(int id_calendar)
        {
            string query = "exec USP_GetInfoCalendar @id_calendar";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_calendar });
            Calendar_DTO calendar = null;
            foreach (DataRow item in table.Rows)
            {
                calendar = new Calendar_DTO(item);
            }
            return calendar;
        }

        public List<Calendar_DTO> GetListCalendar(int id_reservation)
        {
            string query = "exec UPS_GetListCalendarReservation @id_reservation";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_reservation });
            List<Calendar_DTO> list_calendar = new List<Calendar_DTO>();
            foreach(DataRow item in table.Rows)
            {
                Calendar_DTO calendar = new Calendar_DTO(item);
                list_calendar.Add(calendar);
            }
            return list_calendar;
        }

    }
}
