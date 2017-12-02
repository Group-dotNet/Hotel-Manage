using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.DTO
{
    class Other_DGV
    {

    }
    
    class Reservation_DGV
    {
        private int id_reservation;
        private string customer;
        private string is_group;
        private int people;
        private string staff;
        private string status;

        public Reservation_DGV(int id_reservation, string customer, bool is_group, int people, string staff, int status)
        {
            this.id_reservation = id_reservation;
            this.customer = customer;
            if (is_group == true) this.is_group = "Yes";
            else this.is_group = "No";
            this.people = people;
            this.staff = staff;
            if(status == 0)
            {
                this.status = "Cancelled";
            }else if(status == 1)
            {
                this.status = "Completed";
            }else if(status == 2)
            {
                this.status = "Unpail bills";
            }
            else
            {
                this.status = "No deposit";
            }
        }

        public int Id_reservation
        {
            get
            {
                return id_reservation;
            }

            set
            {
                id_reservation = value;
            }
        }

        public string Customer
        {
            get
            {
                return customer;
            }

            set
            {
                customer = value;
            }
        }

        public string Is_group
        {
            get
            {
                return is_group;
            }

            set
            {
                is_group = value;
            }
        }

        public int People
        {
            get
            {
                return people;
            }

            set
            {
                people = value;
            }
        }

        public string Staff
        {
            get
            {
                return staff;
            }

            set
            {
                staff = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }

     class Bill_DGV
    {
        private int id_bill;
        private double total;
        private string username;
        private string confirm;
        private DateTime created;

        public Bill_DGV(int id_bill, double total, string username, bool confirm, DateTime created)
        {
            this.id_bill = id_bill;
            this.total = total;
            this.username = username;
            if (confirm == true) this.confirm = "Received";
            else this.confirm = "Not received";
            this.created = created;
        }

        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Confirm
        {
            get
            {
                return confirm;
            }

            set
            {
                confirm = value;
            }
        }

        public DateTime Created
        {
            get
            {
                return created;
            }

            set
            {
                created = value;
            }
        }

        public int Id_bill
        {
            get
            {
                return id_bill;
            }

            set
            {
                id_bill = value;
            }
        }
    }

    class Customer_DGV
    {
        private int id_customer;
        private string name_customer;
        private string sex;
        private string phone;
        private string history;

        public Customer_DGV(int id_customer, string name_customer, bool sex, string phone, int history)
        {
            this.id_customer = id_customer;
            this.name_customer = name_customer;
            if (sex == true) this.sex = "Men";
            else this.sex = "Women";
            this.phone = phone;
            if (history == 0) this.history = "Good";
            else this.history = "Bad";
        }

        public int Id_customer
        {
            get
            {
                return id_customer;
            }

            set
            {
                id_customer = value;
            }
        }

        public string Name_customer
        {
            get
            {
                return name_customer;
            }

            set
            {
                name_customer = value;
            }
        }

        public string Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string History
        {
            get
            {
                return history;
            }

            set
            {
                history = value;
            }
        }
    }

    class Staff_DGV
    {

    }
}
