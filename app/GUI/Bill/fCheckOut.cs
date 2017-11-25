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
        private string username = "phuc";

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

        private double Get_Money_Room(List<Reservation_room_DTO> list_reservation_room, Calendar_DTO calendar)
        {
            double xmod = 0;
            if (calendar.End_date != null)
            {
                TimeSpan interval = calendar.End_date.Subtract(calendar.Start_date);
                if (interval.Days < 1)
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
                }
            }
            else
                xmod = 3;

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
            double total_room = Get_Money_Room(list_reservation_room, calendar);
            lb_total_room.Text = total_room.ToString("c", cul);

            double total_service = Get_Money_Service(list_service_ticket);
            lb_total_service.Text = total_service.ToString("c", cul);

            this.total_money = total_room + total_service;
            lb_total_money.Text = this.total_money.ToString("c", cul);


            lb_deposit.Text = deposit.Deposit.ToString("c", cul);
            this.deposit = deposit.Deposit;

            lb_staff.Text = bill.Staff.Username.ToString();

            lb_rest.Text = (this.total_money - this.deposit).ToString("c", cul);
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
                if(Bill_BUS.Instance.UpdateBill(this.id_bill, this.total_money, this.username))
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
