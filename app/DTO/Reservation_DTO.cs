using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Reservation_DTO
    {
        private int m_id_reservation;
        private Customer_DTO m_customer;
        private int m_status_reservation;
        private bool m_is_group;
        private int m_people;
        private Staff_DTO m_staff;
        private bool m_logged;
        private string m_note;

        public int Id_reservation
        {
            get
            {
                return m_id_reservation;
            }

            set
            {
                m_id_reservation = value;
            }
        }

        internal Customer_DTO Customer
        {
            get
            {
                return m_customer;
            }

            set
            {
                m_customer = value;
            }
        }

        public int Status_reservation
        {
            get
            {
                return m_status_reservation;
            }

            set
            {
                m_status_reservation = value;
            }
        }

        public bool Is_group
        {
            get
            {
                return m_is_group;
            }

            set
            {
                m_is_group = value;
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

        public Staff_DTO Staff
        {
            get
            {
                return m_staff;
            }

            set
            {
                m_staff = value;
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

        public string Note
        {
            get
            {
                return m_note;
            }

            set
            {
                m_note = value;
            }
        }
    }
}
