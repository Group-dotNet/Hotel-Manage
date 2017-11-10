using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Log_swap_room
    {
        private int m_id_log;
        private int m_id_reservation;
        private int m_id_room_old;
        private double m_price_difference;
        private bool m_select_record;
        private DateTime created;

        public int Id_log
        {
            get
            {
                return m_id_log;
            }

            set
            {
                m_id_log = value;
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

        public int Id_room_old
        {
            get
            {
                return m_id_room_old;
            }

            set
            {
                m_id_room_old = value;
            }
        }

        public double Price_difference
        {
            get
            {
                return m_price_difference;
            }

            set
            {
                m_price_difference = value;
            }
        }

        public bool Select_record
        {
            get
            {
                return m_select_record;
            }

            set
            {
                m_select_record = value;
            }
        }

        public DateTime Created
        {
            get
            {
                return created;
            }

            set
            {
                created = value;
            }
        }
    }
}
