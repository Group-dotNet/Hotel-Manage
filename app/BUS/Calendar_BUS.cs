using app.DAO;
using app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.BUS
{
    class Calendar_BUS
    {
        private static Calendar_BUS instance;

        internal static Calendar_BUS Instance
        {
            get
            {
                if (instance == null) instance = new Calendar_BUS(); return Calendar_BUS.instance;
            }

            private set
            {
                instance = value;
            }
        }

        private Calendar_BUS() { }

        public Calendar_DTO GetCalendarReservation(int id_reservation)
        {
            try
            {
                return Calendar_DAO.Instance.GetCalendarReservation(id_reservation);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public List<Calendar_DTO> GetListCalendar()
        {
            try
            {
                return Calendar_DAO.Instance.GetListCalendar();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public Calendar_DTO GetInfoCalendar(int id_calendar)
        {
            try
            {
                return Calendar_DAO.Instance.GetInfoCalendar(id_calendar);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public List<Calendar_DTO> GetListCalendar(int id_reservation)
        {
            try
            {
                return Calendar_DAO.Instance.GetListCalendar(id_reservation);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
