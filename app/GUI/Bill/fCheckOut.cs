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

namespace app.GUI.Bill
{
    public partial class fCheckOut : Form
    {
        public fCheckOut()
        {
            InitializeComponent();
        }

        private int id_bill;
        private double total_money;
        private double deposit;
        private double rest;
        private double xmod_room;
        

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

        public double Total_money
        {
            get
            {
                return total_money;
            }

            set
            {
                total_money = value;
            }
        }

        public double Deposit
        {
            get
            {
                return deposit;
            }

            set
            {
                deposit = value;
            }
        }

        public double Rest
        {
            get
            {
                return rest;
            }

            set
            {
                rest = value;
            }
        }

        public double Xmod_room
        {
            get
            {
                return xmod_room;
            }

            set
            {
                xmod_room = value;
            }
        }

        private double Get_Money_Cancel_Room(int id_reservation)
        {
            Calendar_DTO calendar = Calendar_BUS.Instance.GetCalendarReservationUsing(id_reservation);
            List<Log_swap_room_DTO> list_log = Log_swap_room_BUS.Instance.ListRoomCancel(id_reservation);
            double total_room_cancel = 0;
            foreach (Log_swap_room_DTO item in list_log)
            {
                double xmod2 = 0;

                TimeSpan interval = item.Created.Subtract(calendar.Start_date);
                if (interval.Days < 1)
                {
                    if (interval.Hours < 2)
                    {
                        xmod2 = 0.25;
                    }
                    else if (interval.Hours < 6)
                    {
                        xmod2 = 0.5;
                    }
                    else
                    {
                        xmod2 = 1;
                    }
                }
                else
                {
                    if (interval.Hours > 6)
                        xmod2 = interval.Days + 0.5;
                }

                Room_DTO room = Room_BUS.Instance.Get_Info_Room(item.Reservation_room.Room.Id_room);
                total_room_cancel = total_room_cancel + ((double)room.Kind_of_room.Price * xmod2);

            }

            return total_room_cancel;
        }

        private double Get_Money_Room(List<Reservation_room_DTO> list_reservation_room, Calendar_DTO calendar)
        {

            double xmod = 0;
             if (calendar.End_date != null)
            {
                TimeSpan interval = calendar.End_date.Subtract(calendar.Start_date);
                 if  (interval.Days < 1)
                {
                    if (interval.Hours < 2)
                    {
                        xmod = 0.25;
                    }
                    else if (interval.Hours < 6)
                    {
                        xmod = 0.5;
                    }
                    else
                    {
                        xmod = 1;
                    }
                }
                else
                {
                    if (interval.Hours > 6)
                        xmod = interval.Days + 0.5;
                    else
                        xmod = interval.Days;
                    
                }
            }
            else
                xmod = 3;

            this.xmod_room = xmod;
            double total_room = 0;

            foreach (Reservation_room_DTO reservation_room in list_reservation_room)
            {

                total_room = total_room + ((double)reservation_room.Room.Kind_of_room.Price * xmod);
            }

            return total_room;
        }

        private double Get_Money_Service(List<Service_ticket_DTO> list_service_ticket)
        {
            double total_service = 0;
            foreach (Service_ticket_DTO service_ticket in list_service_ticket)
            {

                total_service = total_service + ((double)service_ticket.Service.Price * service_ticket.Number);
            }
            return total_service;
        }

        private void Load_Room_Using()
        {
            Bill_DTO bill = Bill_BUS.Instance.GetInfoBill(this.id_bill);
            List<Reservation_room_DTO> list_room = Reservation_room_BUS.Instance.Get_ListReservation_Using(bill.Reservation.Id_reservation);
            foreach(Reservation_room_DTO reservation_room in list_room)
            {
                ListViewItem item = new ListViewItem(((reservation_room.Room.Num_floor * 100) + reservation_room.Room.Num_order).ToString());
                item.SubItems.Add(((double)reservation_room.Room.Kind_of_room.Price * xmod_room).ToString());
                item.SubItems.Add("Using");
                lv_room.Items.Add(item);
            }

            List<Log_swap_room_DTO> list_room_cancel = Log_swap_room_BUS.Instance.ListRoomCancel(bill.Reservation.Id_reservation);
            foreach (Log_swap_room_DTO reservation_room in list_room_cancel)
            {
                Calendar_DTO calendar = Calendar_BUS.Instance.GetCalendarReservationUsing(bill.Reservation.Id_reservation);
                Room_DTO room = Room_BUS.Instance.Get_Info_Room(reservation_room.Reservation_room.Room.Id_room);

                double xmod_room_cancel = 0;

                TimeSpan interval = calendar.Start_date.Subtract(reservation_room.Created);
                if (interval.Days < 1)
                {
                    if (interval.Hours < 2)
                    {
                        xmod_room_cancel = 0.25;
                    }
                    else if (interval.Hours < 6)
                    {
                        xmod_room_cancel = 0.5;
                    }
                    else
                    {
                        xmod_room_cancel = 1;
                    }
                }
                else
                {
                    if (interval.Hours > 6)
                        xmod_room_cancel = interval.Days + 0.5;
                }

                ListViewItem item = new ListViewItem(((room.Num_floor * 100) + room.Num_order).ToString());
                item.SubItems.Add(((double)room.Kind_of_room.Price * xmod_room_cancel).ToString());
                item.SubItems.Add("Cancel");
                lv_room.Items.Add(item);
            }
        }

        private void Load_Service_Using()
        {
            Bill_DTO bill = Bill_BUS.Instance.GetInfoBill(this.id_bill);
            List<Service_ticket_DTO> list_service_by_reservation = Service_ticket_BUS.Instance.Get_ListServiceReservation(bill.Reservation.Id_reservation);
            foreach (Service_ticket_DTO service_by_reservation in list_service_by_reservation)
            {
                ListViewItem item = new ListViewItem(service_by_reservation.Service.Id_service.ToString());
                item.SubItems.Add(service_by_reservation.Service.Name_service.ToString());
                item.SubItems.Add(service_by_reservation.Service.Price.ToString());
                item.SubItems.Add(service_by_reservation.Number.ToString());
                Room_DTO room = Room_BUS.Instance.Get_Info_Room(service_by_reservation.Reservation_room.Room.Id_room);
                item.SubItems.Add(((room.Num_floor * 100) + room.Num_order).ToString());
                lv_service.Items.Add(item);
            }
        }

        private void LoadData()
        {
            Bill_DTO bill = Bill_BUS.Instance.GetInfoBill(this.id_bill);
            Reservation_DTO reservation = Reservation_BUS.Instance.GetInfoReservation(bill.Reservation.Id_reservation);
            Calendar_DTO calendar = Calendar_BUS.Instance.GetCalendarReservationUsing(bill.Reservation.Id_reservation);
            Deposit_DTO deposit = Deposit_BUS.Instance.GetInfoDepositUsing(bill.Reservation.Id_reservation);
            List<Reservation_room_DTO> list_reservation_room = Reservation_room_BUS.Instance.Get_ListReservation_Using(bill.Reservation.Id_reservation);
            List<Service_ticket_DTO> list_service_ticket = Service_ticket_BUS.Instance.Get_ListServiceReservation(bill.Reservation.Id_reservation);

            lb_reservation.Text = bill.Reservation.Id_reservation.ToString();
            lb_customer.Text = reservation.Customer.Name.ToString();
            lb_group.Text = reservation.Is_group.ToString();
            lb_peopel.Text = reservation.People.ToString();
            lb_start_date.Text = calendar.Start_date.ToString();
            lb_end_date.Text = calendar.End_date.ToString();

            System.Globalization.CultureInfo cul = new System.Globalization.CultureInfo("vi-VN");
            double total_room = Get_Money_Room(list_reservation_room, calendar) + this.Get_Money_Cancel_Room(bill.Reservation.Id_reservation);
            lb_total_room.Text = total_room.ToString("c", cul);

            double total_service = Get_Money_Service(list_service_ticket);
            lb_total_service.Text = total_service.ToString("c", cul);

            this.total_money = total_room + total_service;
            lb_total_money.Text = this.total_money.ToString("c", cul);


            lb_deposit.Text = deposit.Deposit.ToString("c", cul);
            this.deposit = deposit.Deposit;

            lb_staff.Text = bill.Staff.Username.ToString();

            lb_rest.Text = (this.total_money - this.deposit).ToString("c", cul);

            Load_Room_Using();
            Load_Service_Using();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_confirm_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cb_confirm.SelectedIndex == 1)
            {
                btn_ok.Enabled = true;
            }
            else
            {
                btn_ok.Enabled = false;
            }
        }

        private void fCheckOut_Load(object sender, EventArgs e)
        {
            LoadData();
            cb_confirm.SelectedIndex = 0;
            btn_ok.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI.Other.Calculator frm = new Other.Calculator();
            frm.ShowDialog();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(cb_confirm.SelectedIndex == 1)
            {
                if(Bill_BUS.Instance.UpdateBill(this.id_bill, this.total_money, DTO.Session.username))
                {
                    MessageBox.Show("Finsh Reservation!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Check confirm !");
                return;
            }
        }
    }
}
