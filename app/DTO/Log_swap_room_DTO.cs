using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Log_swap_room_DTO
    {
        private int m_id_log;
        private Reservation_room_DTO m_reservation_room = new Reservation_room_DTO();
        private Room_DTO m_id_room_new = new Room_DTO();
        private bool select_record;
        private DateTime created;

        public Log_swap_room_DTO() { }

        internal Room_DTO Id_room_new
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

        public bool Select_record
        {
            get
            {
                return select_record;
            }

            set
            {
                select_record = value;
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
    }
}
