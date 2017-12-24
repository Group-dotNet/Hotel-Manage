using app.BUS;
using app.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.GUI.Reservation
{
    public partial class fReservation_info : Form
    {
        public fReservation_info()
        {
            InitializeComponent();
        }
        private int id_reservation;

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

        private void Load_Data()
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");

            Reservation_DTO reservation = Reservation_BUS.Instance.GetInfoReservation(id_reservation);
            Calendar_DTO calendar = Calendar_BUS.Instance.GetCalendarReservationUsing(id_reservation);

            lb_id.Text = id_reservation.ToString();
            lb_customer.Text = reservation.Customer.Name;
            if (calendar != null)
            {
                lb_start_date.Text = calendar.Start_date.ToString();
                lb_end_date.Text = calendar.End_date.ToString();
            }
            else
            {
                Calendar_DTO calendar_laster = Calendar_BUS.Instance.GetInfoCalendarLaster(id_reservation);
                lb_start_date.Text = calendar_laster.Start_date.ToString();
                lb_end_date.Text = calendar_laster.End_date.ToString();
            }

            if (reservation.Is_group == true)
                lb_group.Text = "Yes";
            else
                lb_group.Text = "No";

            lb_people.Text = reservation.People.ToString();
            if (reservation.Status_reservation == 0)
            {
                lb_status.Text = "Đã hủy";
            }
            else
            {
                if (reservation.Status_reservation == 1)
                {
                    lb_status.Text = "Hoàn tất";
                }
                else if (reservation.Status_reservation == 2)
                {
                    lb_status.Text = "Chưa thanh toán";
                }
                else
                { lb_status.Text = "Chưa Đặt cọc"; }
            }


            List<Calendar_DTO> list_calendar = Calendar_BUS.Instance.GetListCalendarReservation(this.id_reservation);
            foreach (Calendar_DTO calendar1 in list_calendar)
            {
                ListViewItem item = new ListViewItem(calendar1.Id_calendar.ToString());
                item.SubItems.Add(calendar1.Start_date.ToString());
                item.SubItems.Add(calendar1.End_date.ToString());
                item.SubItems.Add(calendar1.Created.ToString());
                if (calendar1.Status == 2)
                {
                    item.SubItems.Add("Change");
                }
                else
                {
                    if (calendar1.Status == 1)
                    {
                        item.SubItems.Add("Active");
                    }
                    else
                    {
                        item.SubItems.Add("Cancel");
                    }
                }

                listView2.Items.Add(item);
            }


            List<Reservation_room_DTO> list_reservation_room = Reservation_room_BUS.Instance.Get_ListReservation_Using(this.id_reservation);
            foreach (Reservation_room_DTO reservation_room in list_reservation_room)
            {
                ListViewItem item = new ListViewItem(reservation_room.Id_reservation_room.ToString());
                item.SubItems.Add(reservation_room.Room.Id_room.ToString());
                item.SubItems.Add(reservation_room.Room.Kind_of_room.Name.ToString());
                item.SubItems.Add(reservation_room.Room.Kind_of_room.People.ToString());
                item.SubItems.Add(((int)reservation_room.Room.Kind_of_room.Price).ToString());
                listView1.Items.Add(item);
            }

            List<Service_ticket_DTO> list_service_reservation = Service_ticket_BUS.Instance.Get_ListServiceReservation(this.id_reservation);
            foreach (Service_ticket_DTO service in list_service_reservation)
            {
                ListViewItem item = new ListViewItem(service.Reservation_room.Room.Id_room.ToString());
                item.SubItems.Add(service.Service.Id_service.ToString());
                item.SubItems.Add(service.Service.Name_service.ToString());
                item.SubItems.Add(((int)service.Service.Price).ToString());
                item.SubItems.Add(service.Number.ToString());
                item.SubItems.Add(service.Date_use.ToString());
                listView4.Items.Add(item);
            }


            List<Deposit_DTO> list_deposit = Deposit_BUS.Instance.GetListDepositReservation(id_reservation);
            foreach (Deposit_DTO deposit in list_deposit)
            {
                ListViewItem item = new ListViewItem(deposit.Id_deposit.ToString());
                item.SubItems.Add(deposit.Deposit.ToString("c", culture));
                item.SubItems.Add(deposit.Confirm.ToString());
                item.SubItems.Add(deposit.Created_confirm.ToString());
                item.SubItems.Add(deposit.Locked.ToString());
                item.SubItems.Add(deposit.Note.ToString());
                listView3.Items.Add(item);
            }

            this.lb_total.Text = BUS.Bill_BUS.Instance.GetListBillByReservation(id_reservation).Total_money.ToString("c", culture);
            this.lb_checkout.Text = BUS.Bill_BUS.Instance.GetListBillByReservation(id_reservation).Created.ToString();
        }
        

        private void fReservation_info_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
