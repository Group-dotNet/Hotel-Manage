﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Deposit_DTO
    {
        private int m_id_deposit;
        private Reservation_DTO m_reservation = new Reservation_DTO();
        private double m_deposit;
        private bool m_confirm;
        private DateTime m_created_confirm;
        private bool m_locked;
        private string m_note;

        public Deposit_DTO() { }

        public int Id_deposit
        {
            get
            {
                return m_id_deposit;
            }

            set
            {
                m_id_deposit = value;
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

        public double Deposit
        {
            get
            {
                return m_deposit;
            }

            set
            {
                m_deposit = value;
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

        public DateTime Created_confirm
        {
            get
            {
                return m_created_confirm;
            }

            set
            {
                m_created_confirm = value;
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
