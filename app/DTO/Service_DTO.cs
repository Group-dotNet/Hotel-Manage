using System;
using System.Collections.Generic;
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
