using app.BUS;
using app.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.GUI.Room
{
    public partial class fRoom_info : Form
    {
        public fRoom_info()
        {
            InitializeComponent();
        }

        private int id_room;

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

        private void LoadData()
        {
            Room_DTO room = Room_BUS.Instance.Get_Info_Room(this.id_room);
            if (room.Locked == true)
            {
                Reservation_room_DTO reservation_room = Reservation_room_BUS.Instance.GetInfoReservationRoom(this.id_room);
                Calendar_DTO calendar = Calendar_BUS.Instance.GetInfoCalendarLaster(reservation_room.Reservation.Id_reservation);
                Reservation_DTO reservation = Reservation_BUS.Instance.GetInfoReservation(reservation_room.Reservation.Id_reservation);

                lb_id_reservation.Text = reservation.Id_reservation.ToString();
                lb_customer.Text = reservation.Customer.Name.ToString();
                lb_group.Text = reservation.Is_group.ToString();
                lb_people_reservation.Text = reservation.People.ToString();
                lb_start_date.Text = calendar.Start_date.ToString();
                lb_end_date.Text = calendar.End_date.ToString();
                if (reservation.Status_reservation == 0)
                {
                    lb_status_reservation.Text = "Cancel";
                }
                else
                {
                    if (reservation.Status_reservation == 1)
                    {
                        lb_status_reservation.Text = "Success";
                    }
                    else if (reservation.Status_reservation == 2)
                    {
                        lb_status_reservation.Text = "Not paid";
                    }
                    else
                    { lb_status_reservation.Text = "Not deposit"; }
                }

                lb_floor.Text = room.Num_floor.ToString();
                lb_order.Text = room.Num_order.ToString();
                lb_type_room.Text = room.Kind_of_room.Name.ToString();
                lb_people.Text = room.Kind_of_room.People.ToString();
                CultureInfo cul = new CultureInfo("vi-VN");
                lb_price.Text = room.Kind_of_room.Price.ToString("c", cul);
                lb_staff.Text = room.Username.ToString();
                if (room.Locked == true) lb_status.Text = "Active";
                else lb_status.Text = "Empty";
            }
            else
            {
                lb_id_reservation.Text = "Nope";
                lb_customer.Text = "Nope";
                lb_group.Text = "Nope";
                lb_people_reservation.Text = "Nope";
                lb_start_date.Text = "Nope";
                lb_end_date.Text = "Nope";
                lb_status_reservation.Text = "Nope";

                lb_floor.Text = room.Num_floor.ToString();
                lb_order.Text = room.Num_order.ToString();
                lb_type_room.Text = room.Kind_of_room.Name.ToString();
                lb_people.Text = room.Kind_of_room.People.ToString();
                CultureInfo cul = new CultureInfo("vi-VN");
                lb_price.Text = room.Kind_of_room.Price.ToString("c", cul);
                lb_staff.Text = room.Username.ToString();
                if (room.Locked == true) lb_status.Text = "Active";
                else lb_status.Text = "Empty";
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fRoom_info_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
