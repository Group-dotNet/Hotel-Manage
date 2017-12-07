using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Service_DTO
    {

        private int m_id_service;
        private string m_name_service;
        private decimal m_price;
        private string m_unit;

        public Service_DTO() { }

        public Service_DTO(int id_service, string name_service, decimal price, string unit)
        {
            this.Id_service = id_service;
            this.Name_service = name_service;
            this.Price = price;
            this.Unit = unit;
        }


        public Service_DTO(DataRow Service)
        {
            this.Id_service = (int)Service["id_service"];
            this.Name_service = Service["name_service"].ToString();
            this.Price = (decimal)Service["price"];
            this.Unit = Service["unit"].ToString();
        }
        public int Id_service
        {
            get
            {
                return m_id_service;
            }

            set
            {
                m_id_service = value;
            }
        }

        public string Name_service
        {
            get
            {
                return m_name_service;
            }

            set
            {
                m_name_service = value;
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

        public string Unit
        {
            get
            {
                return m_unit;
            }

            set
            {
                m_unit = value;
            }
        }
    }
}
