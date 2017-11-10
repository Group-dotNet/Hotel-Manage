using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class History_customer_DTO
    {
        private int m_id_history;
        private String m_name_history;
        private bool m_logged;

        public int Id_history
        {
            get
            {
                return m_id_history;
            }

            set
            {
                m_id_history = value;
            }
        }

        public string Name_history
        {
            get
            {
                return m_name_history;
            }

            set
            {
                m_name_history = value;
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
    }
}
