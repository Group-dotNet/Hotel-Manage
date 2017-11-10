using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Reservation_room_DTO
    {
        private Reservation_DTO m_reservation;
        private Room_DTO m_room;
        private bool m_using;

        public bool Using
        {
            get
            {
                return m_using;
            }

            set
            {
                m_using = value;
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

        internal Room_DTO Room
        {
            get
            {
                return m_room;
            }

            set
            {
                m_room = value;
            }
        }
    }
}
