using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Kind_of_room_DTO
    {
        private int m_id;
        private string m_name;
        private double m_price;
        private int m_people;

        public int Id
        {
            get
            {
                return m_id;
            }

            set
            {
                m_id = value;
            }
        }

        public string Name
        {
            get
            {
                return m_name;
            }

            set
            {
                m_name = value;
            }
        }

        public double Price
        {
            get
            {
                return m_price;
            }

            set
            {
                m_price = value;
            }
        }

        public int People
        {
            get
            {
                return m_people;
            }

            set
            {
                m_people = value;
            }
        }
    }
}
