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

        public Calendar_DTO GetCalendarReservationUsing(int id_reservation)
        {
            try
            {
                return Calendar_DAO.Instance.GetCalendarReservationUsing(id_reservation);
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

        public List<Calendar_DTO> GetListCalendarReservation(int id_reservation)
        {
            try
            {
                return Calendar_DAO.Instance.GetListCalendarReservation(id_reservation);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public Calendar_DTO GetInfoCalendarLaster(int id_reservation)
        {
            try
            {
                return Calendar_DAO.Instance.GetInfoCalendarLaster(id_reservation);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public bool ChangeCalendar(int id_reservation, DateTime end_date_new)
        {
            try
            {
                return Calendar_DAO.Instance.ChangeCalendar(id_reservation, end_date_new);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }
    }
}
