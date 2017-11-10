using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Room_DTO
    {
        private int m_id_room;
        private int m_num_floor;
        private int m_num_order;
        private Kind_of_room_DTO m_kind_of_room;
        private bool m_logged;
        private string m_username;

        public int Id_room
        {
            get
            {
                return m_id_room;
            }

            set
            {
                m_id_room = value;
            }
        }

        public int Num_floor
        {
            get
            {
                return m_num_floor;
            }

            set
            {
                m_num_floor = value;
            }
        }

        public int Num_order
        {
            get
            {
                return m_num_order;
            }

            set
            {
                m_num_order = value;
            }
        }

        internal Kind_of_room_DTO Kind_of_room
        {
            get
            {
                return m_kind_of_room;
            }

            set
            {
                m_kind_of_room = value;
            }
        }

        public bool Logged
        {
            get
            {
                return m_logged;
            }

            set
            {
                m_logged = value;
            }
        }

        public string Username
        {
            get
            {
                return m_username;
            }

            set
            {
                m_username = value;
            }
        }
    }
}
