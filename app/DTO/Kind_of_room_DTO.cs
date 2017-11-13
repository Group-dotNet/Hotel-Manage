using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    public class Kind_of_room_DTO
    {
        private int m_id;
        private string m_name;
        private decimal m_price;
        private int m_people;

        public Kind_of_room_DTO() { }

        public Kind_of_room_DTO(int id) { this.Id = id; } 

        public Kind_of_room_DTO(DataRow kof)
        {
            this.Id = (int)kof["id"];
            this.Name = kof["name"].ToString();
            this.Price = (decimal)kof["price"];
            this.People = (int)kof["people"];
        }

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

        public decimal Price
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
    }
}
