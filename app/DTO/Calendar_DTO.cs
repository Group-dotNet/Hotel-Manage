using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Calendar_DTO
    {
        private int m_id_calendar;
        private int m_id_reservation;
        private DateTime m_start_date;
        private DateTime m_end_date;
        private DateTime m_created;
        private int m_status;

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

        public int Id_reservation
        {
            get
            {
                return m_id_reservation;
            }

            set
            {
                m_id_reservation = value;
            }
        }
    }
}
