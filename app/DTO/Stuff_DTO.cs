using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Stuff_DTO
    {
        private int m_id_stuff;
        private string m_name_stuff;

        public Stuff_DTO()
        {
        }

        public Stuff_DTO(int id_stuff, string name_stuff) // Sử dụng hàn này
        {
            this.m_id_stuff = id_stuff;
            this.m_name_stuff = name_stuff;
        }
        public int Id_stuff
        {
            get
            {
                return m_id_stuff;
            }

            set
            {
                m_id_stuff = value;
            }
        }

        public string Name_stuff
        {
            get
            {
                return m_name_stuff;
            }

            set
            {
                m_name_stuff = value;
            }
        }
    }
}
