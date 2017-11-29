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

        /// <summary>
        ///  Lẩy ra danh sách tất cả các lịch trong hệ thống
        /// </summary>
        /// <returns>Danh sách các lịch trong hệ thống</returns>
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

        /// <summary>
        /// Lấy ra thông tin lịch đăng sử dụng
        /// </summary>
        /// <param name="id_reservation"></param>
        /// <returns></returns>
        public Calendar_DTO GetCalendarReservationUsing(int id_reservation)
        {
            string query = "exec USP_GetCalendarReservationUsing @id_reservation";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_reservation });
            Calendar_DTO calendar = null;
            foreach (DataRow item in table.Rows)
            {
                calendar = new Calendar_DTO(item);
            }
            return calendar;
        }

        /// <summary>
        /// Lấy thông tin của lịch bằng mã lịch
        /// </summary>
        /// <param name="id_calendar"> mẵ lịch cần tìm</param>
        /// <returns>Thông tin của lịch</returns>
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

        /// <summary>
        /// Lấy ra thông tin tất cả các lịch của phiếu đặt (các lịch đã hủy, đã sửa,...)
        /// </summary>
        /// <param name="id_reservation">Mã của phiếu đặt</param>
        /// <returns>Danh sách các Lịch thỏa mãn</returns>
        public List<Calendar_DTO> GetListCalendarReservation(int id_reservation)
        {
            string query = "exec UPS_GetListCalendarReservation @id_reservation";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_reservation });
            List<Calendar_DTO> list_calendar_reservation = new List<Calendar_DTO>();
            foreach(DataRow item in table.Rows)
            {
                Calendar_DTO calendar = new Calendar_DTO(item);
                list_calendar_reservation.Add(calendar);
            }
            return list_calendar_reservation;
        }

        public Calendar_DTO GetInfoCalendarLaster(int id_reservation)
        {
            string query = "exec USP_GetInfoCalendarLaster @id_reservation";
            DataTable table = Connect.Instance.ExecuteQuery(query, new object[] { id_reservation });
            Calendar_DTO calendar = null;
            foreach (DataRow item in table.Rows)
            {
                calendar = new Calendar_DTO(item);
                break;
            }
            return calendar;
        }

        public bool ChangeCalendar(int id_reservation, DateTime end_date_new)
        {
            string query = "exec USP_ChangeCalendar @id_reservation , @end_date";
            int x = (int)Connect.Instance.ExecuteOutPut(query, new object[] { id_reservation, end_date_new });
            return x == 1;
        }
    }
}
