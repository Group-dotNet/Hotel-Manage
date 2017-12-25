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
    
    public class Reservation_DGV
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

        public Reservation_DGV() { }

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

    public class Bill_DGV
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

    public class Customer_DGV
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

    public class Staff_DGV
    {
        private string username;
        private string name;
        private string sex;
        private string phone;

        public Staff_DGV(string username, string name, bool sex, string phone)
        {
            this.username = username;
            this.name = name;
            if (sex == true) this.sex = "Men";
            else this.sex = "Woman";
            this.phone = phone;
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
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
    }

    public class Room_DGV
    {
        private int id_room;
        private string name;
        private int num_floor;
        private int num_order;
        private string kind_of_room;
        private string staff;

        public Room_DGV() { }

        public Room_DGV(int id_room, int num_floor, int num_order, string kind_of_room, string staff)
        {
            this.id_room = id_room;
            this.name = ((num_floor * 100) + num_order).ToString();
            this.num_floor = num_floor;
            this.num_order = num_order;
            this.kind_of_room = kind_of_room;
            this.staff = staff;
        }

        public int Id_room
        {
            get
            {
                return id_room;
            }

            set
            {
                id_room = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Num_floor
        {
            get
            {
                return num_floor;
            }

            set
            {
                num_floor = value;
            }
        }

        public int Num_order
        {
            get
            {
                return num_order;
            }

            set
            {
                num_order = value;
            }
        }

        public string Kind_of_room
        {
            get
            {
                return kind_of_room;
            }

            set
            {
                kind_of_room = value;
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
    }

    public class Service_DGV
    {

        private int id_service;
        private string name_service;
        private int price;
        private int number;
        private DateTime date_use;
        private string room;

        public Service_DGV() { }

        public Service_DGV(int id_service, int number, DateTime date_use, string name_service, int price, int num_floor, int num_order)
        {
            this.id_service = id_service;
            this.number = number;
            this.date_use = date_use;
            this.price = price;
            this.name_service = name_service;
            this.room = ((num_floor * 100) + num_order).ToString();
        }

        public int Id_service
        {
            get
            {
                return id_service;
            }

            set
            {
                id_service = value;
            }
        }

        public string Name_service
        {
            get
            {
                return name_service;
            }

            set
            {
                name_service = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public DateTime Date_use
        {
            get
            {
                return date_use;
            }

            set
            {
                date_use = value;
            }
        }

        public string Room
        {
            get
            {
                return room;
            }

            set
            {
                room = value;
            }
        }
    }

    public class Stuff_Detail_DGV
    {
        private int id_stuff;
        private string name_stuff;
        private int number;

        public Stuff_Detail_DGV() { }

        public Stuff_Detail_DGV(int stuff, string name_stuff, int number)
        {
            this.id_stuff = stuff;
            this.name_stuff = name_stuff;
            this.number = number;
        }

        public int Id_stuff
        {
            get
            {
                return id_stuff;
            }

            set
            {
                id_stuff = value;
            }
        }

        public string Name_stuff
        {
            get
            {
                return name_stuff;
            }

            set
            {
                name_stuff = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }
    }
}
