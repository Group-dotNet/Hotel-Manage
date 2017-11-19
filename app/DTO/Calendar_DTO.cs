using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Calendar_DTO
    {
        private int m_id_calendar;
        private Reservation_DTO m_reservation = new Reservation_DTO();
        private DateTime m_start_date;
        private DateTime m_end_date;
        private DateTime m_created;
        private int m_status;

        public Calendar_DTO() { }

        public Calendar_DTO(DataRow calendar)
        {
            this.Id_calendar = (int)calendar["id_calendar"];
            this.Reservation.Id_reservation = (int)calendar["id_reservation"];
            this.Start_date = (DateTime)calendar["start_date"];
            this.End_date = (DateTime)calendar["end_date"];
            this.Created = (DateTime)calendar["created"];
            this.Status = (int)calendar["status"];
        }

        public int Id_calendar
        {
            get
            {
                return m_id_calendar;
            }

            set
            {
                m_id_calendar = value;
            }
        }

        public DateTime Start_date
        {
            get
            {
                return m_start_date;
            }

            set
            {
                m_start_date = value;
            }
        }

        public DateTime End_date
        {
            get
            {
                return m_end_date;
            }

            set
            {
                m_end_date = value;
            }
        }

        public DateTime Created
        {
            get
            {
                return m_created;
            }

            set
            {
                m_created = value;
            }
        }

        public int Status
        {
            get
            {
                return m_status;
            }

            set
            {
                m_status = value;
            }
        }


        internal Reservation_DTO Reservation
        {
            get
            {
                return m_reservation;
            }

            set
            {
                m_reservation = value;
            }
        }
    }
}
