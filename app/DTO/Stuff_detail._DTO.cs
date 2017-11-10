using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Stuff_detail
    {

        private Stuff_DTO m_stuff;
        private Kind_of_room_DTO m_kind_of_room;
        private int M_number;

        internal Stuff_DTO Stuff
        {
            get
            {
                return m_stuff;
            }

            set
            {
                m_stuff = value;
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

        public int M_number1
        {
            get
            {
                return M_number;
            }

            set
            {
                M_number = value;
            }
        }
    }
}
