using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Reservation_DTO
    {
        private int m_id_reservation;
        private Customer_DTO m_customer = new Customer_DTO();
        private int m_status_reservation;
        private bool m_is_group;
        private int m_people;
        private Staff_DTO m_staff = new Staff_DTO();
        private bool m_locked;
        private string m_note;

        public Reservation_DTO() { }

        public Reservation_DTO(int id_reservation, int id_customer, int status_reservation, bool is_group, int people, string username, bool locked, string note)
        {
            this.Id_reservation = id_reservation;
            this.Customer.Id_customer = id_customer;
            this.Status_reservation = status_reservation;
            this.Is_group = is_group;
            this.People = people;
            this.Staff.Username = username;
            this.Locked = locked;
            this.Note = note;
        }

        public Reservation_DTO(DataRow reservation)
        {
            this.Id_reservation = (int)reservation["id_reservation"];
            this.Customer.Id_customer = (int)reservation["id_customer"];
            this.Customer.Name = reservation["name"].ToString();
            this.Status_reservation = (int)reservation["status_reservation"];
            this.Is_group = (bool)reservation["is_group"];
            this.People = (int)reservation["people"];
            this.Staff.Username = reservation["username"].ToString();
            this.Locked = (bool)reservation["locked"];
            this.Note = reservation["note"].ToString();
        }

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

        public bool Locked
        {
            get
            {
                return m_locked;
            }

            set
            {
                m_locked = value;
            }
        }
    }
}
