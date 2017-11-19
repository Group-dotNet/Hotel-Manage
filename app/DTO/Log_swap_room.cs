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
        private Reservation_room_DTO m_reservation_room = new Reservation_room_DTO();
        private int m_id_room_new;
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

        internal Reservation_room_DTO Reservation_room
        {
            get
            {
                return m_reservation_room;
            }

            set
            {
                m_reservation_room = value;
            }
        }

        public int Id_room_new
        {
            get
            {
                return m_id_room_new;
            }

            set
            {
                m_id_room_new = value;
            }
        }
    }
}
