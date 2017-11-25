using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Bill_DTO
    {
        private int m_id_bill;
        private DateTime m_created;
        private double m_total_money;
        private Reservation_DTO m_reservation = new Reservation_DTO();
        private Staff_DTO m_staff = new Staff_DTO();
        private bool m_confirm;
        private string m_note;

        public Bill_DTO() { }

        public int Id_bill
        {
            get
            {
                return m_id_bill;
            }

            set
            {
                m_id_bill = value;
            }
        }

        public DateTime Created
        {
            get
            {
                return m_created;
            }

            set
            {
                m_created = value;
            }
        }

        public double Total_money
        {
            get
            {
                return m_total_money;
            }

            set
            {
                m_total_money = value;
            }
        }

        internal Reservation_DTO Reservation
        {
            get
            {
                return m_reservation;
            }

            set
            {
                m_reservation = value;
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

        public bool Confirm
        {
            get
            {
                return m_confirm;
            }

            set
            {
                m_confirm = value;
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
