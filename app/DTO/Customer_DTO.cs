using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Customer_DTO
    {

        public Customer_DTO() { }


        private int m_id_customer;
        private string m_name;
        private bool m_sex;
        private string m_identity_card;
        private string m_address;
        private string m_email;
        private string m_phone;
        private string m_company;
        private int m_id_history;

        public int Id_customer
        {
            get
            {
                return m_id_customer;
            }

            set
            {
                m_id_customer = value;
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

        public bool Sex
        {
            get
            {
                return m_sex;
            }

            set
            {
                m_sex = value;
            }
        }

        public string Identity_card
        {
            get
            {
                return m_identity_card;
            }

            set
            {
                m_identity_card = value;
            }
        }

        public string Address
        {
            get
            {
                return m_address;
            }

            set
            {
                m_address = value;
            }
        }

        public string Email
        {
            get
            {
                return m_email;
            }

            set
            {
                m_email = value;
            }
        }

        public string Phone
        {
            get
            {
                return m_phone;
            }

            set
            {
                m_phone = value;
            }
        }

        public string Company
        {
            get
            {
                return m_company;
            }

            set
            {
                m_company = value;
            }
        }

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
    }
}
