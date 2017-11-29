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
    public partial class fChange_calendar : Form
    {
        public fChange_calendar()
        {
            InitializeComponent();
        }

        private string username = "phuc";
        private int id_reservation;
        private DateTime start_date;
        private DateTime end_date;

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

        public DateTime End_date
        {
            get
            {
                return end_date;
            }

            set
            {
                end_date = value;
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

        private void LoadData()
        {
            Calendar_DTO calendar = Calendar_BUS.Instance.GetCalendarReservationUsing(this.id_reservation);
            lb_reservation.Text = calendar.Reservation.Id_reservation.ToString();
            lb_start_date.Text = calendar.Start_date.ToString();
            lb_end_date.Text = calendar.End_date.ToString();
            this.end_date = calendar.End_date;
            this.start_date = calendar.Start_date;
        }

        private void fChange_calendar_Load(object sender, EventArgs e)
        {
            LoadData();
            this.cb_select.SelectedIndex = 0;
            this.dpt_date_end.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flat = true;

            if (cb_select.SelectedIndex == 1)
            {
                if (DateTime.Compare(dpt_date_end.Value, this.end_date) > 0 && DateTime.Compare(dpt_date_end.Value, DateTime.Now) < 0)
                {
                    flat = false;
                    MessageBox.Show("Date time not Invalid!");
                    return;
                }
            }
            if (cb_select.SelectedIndex == 2)
            {
                if (DateTime.Compare(dpt_date_end.Value, this.end_date) < 0 || DateTime.Compare(dpt_date_end.Value, DateTime.Now) < 0)
                {
                    flat = false;
                    MessageBox.Show("Date time not Invalid!");
                    return;
                }
            }
            if (flat)
            {
                if(cb_select.SelectedIndex == 0)
                {
                    if(Calendar_BUS.Instance.ChangeCalendar(this.id_reservation, DateTime.Now))
                    {
                        int id_bill = Bill_BUS.Instance.InsertBill(this.id_reservation, this.Username);
                        GUI.Bill.fCheckOut frm = new GUI.Bill.fCheckOut();
                        frm.Id_bill = id_bill;
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    if (Calendar_BUS.Instance.ChangeCalendar(this.id_reservation, dpt_date_end.Value) && cb_select.SelectedIndex == 1)
                    {
                        MessageBox.Show("Change calendar is success!");
                        this.Close();
                    }

                    if (Calendar_BUS.Instance.ChangeCalendar(this.id_reservation, dpt_date_end.Value) && cb_select.SelectedIndex == 2)
                    {
                        GUI.Reservation.fDeposit frm = new fDeposit();
                        frm.Id_reservation = this.id_reservation;
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                    }

                }
            }
        }

        private void cb_select_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cb_select.SelectedIndex != 0)
            {
                dpt_date_end.Enabled = true;
            }
            else
            {
                dpt_date_end.Enabled = false;
            }
        }

        private void dpt_date_end_ValueChanged(object sender, EventArgs e)
        {
            if(cb_select.SelectedIndex == 1)
            {
                if(DateTime.Compare(dpt_date_end.Value, this.end_date) > 0 && DateTime.Compare(dpt_date_end.Value, DateTime.Now) < 0)
                {
                    MessageBox.Show("Date time not Invalid!");
                }
            }
            if (cb_select.SelectedIndex == 2)
            {
                if (DateTime.Compare(dpt_date_end.Value, this.end_date) < 0 || DateTime.Compare(dpt_date_end.Value, DateTime.Now) < 0)
                {
                    MessageBox.Show("Date time not Invalid!");

                }
            }
        }
    }
}
