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
    public partial class fManage_reservation : Form
    {
        public fManage_reservation()
        {
            InitializeComponent();
        }

        private string username = "phuc";

        private void label1_Click(object sender, EventArgs e)
        {

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
            List<Reservation_DTO> list_resevation = Reservation_BUS.Instance.GetListReservation();
            dgv_reservation.DataSource = list_resevation;
        }

        private void fManage_reservation_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void dgv_reservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id_reservation = (int)dgv_reservation.Rows[e.RowIndex].Cells[0].Value;
                this.id_reservation = id_reservation;
                Reservation_DTO reservation = Reservation_BUS.Instance.GetInfoReservation(id_reservation);
                Calendar_DTO calendar = Calendar_BUS.Instance.GetCalendarReservationUsing(id_reservation);

                lb_id.Text = id_reservation.ToString();
                lb_customer.Text = reservation.Customer.Name;
                if(calendar != null)
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
                if(reservation.Status_reservation == 0)
                {
                    lb_status.Text = "Đã hủy";
                }else
                {
                    if(reservation.Status_reservation == 1)
                    {
                        lb_status.Text = "Hoàn tất";
                    }
                    else if(reservation.Status_reservation == 2) {
                        lb_status.Text = "Chưa thanh toán";
                    }
                    else
                    { lb_status.Text = "Chưa Đặt cọc"; }
                }
            }
            catch
            {
                MessageBox.Show("Selected Error!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            if(this.id_reservation != 0)
            {
                fCheck_room frm = new fCheck_room();
                frm.Id_reservation = this.id_reservation;
                frm.ShowDialog();
                this.id_reservation = 0;
            }
            else
            {
                MessageBox.Show("You must select reservation!");
            }
            
        }

        private void btn_service_Click(object sender, EventArgs e)
        {
            if(this.id_reservation != 0)
            {
                fCheck_Service frm = new fCheck_Service();
                frm.Id_reservation = this.id_reservation;
                frm.ShowDialog();
                this.id_reservation = 0;
            }
            else
            {
                MessageBox.Show("You must select reservation!");
            }
        }

        private void btn_calendar_Click(object sender, EventArgs e)
        {
            if (this.id_reservation != 0)
            {
                fCheck_calendar frm = new fCheck_calendar();
                frm.Id_reservation = this.id_reservation;
                frm.ShowDialog();
                this.id_reservation = 0;
            }
            else
            {
                MessageBox.Show("You must select reservation!");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            fAdd_reservation frm = new fAdd_reservation();
            frm.ShowDialog();
            this.Load_Data();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(this.id_reservation != 0)
            {
                int status = Reservation_BUS.Instance.GetInfoReservation(this.id_reservation).Status_reservation;
                if(status != 0 && status != 1)
                {
                    if (Reservation_BUS.Instance.Cancel_Reservation(this.id_reservation))
                    {
                        MessageBox.Show("Canced Reservation!");
                        this.id_reservation = 0;
                        Load_Data();
                    }
                    else
                    {
                        MessageBox.Show("Error! Resevation was cancel!");
                    }
                }
                else
                {
                    MessageBox.Show("Error! Reservation is not cancel!");
                }
            }
            else
            {
                MessageBox.Show("You must select Reservation");
            }

            this.id_reservation = 0;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_chechout_Click(object sender, EventArgs e)
        {
            if (this.id_reservation != 0)
            {
                if (Reservation_BUS.Instance.CheckConfirmBillByReservation(id_reservation) == false)
                {
                    int id_bill = Bill_BUS.Instance.InsertBill(this.id_reservation, this.username);
                    GUI.Bill.fCheckOut frm = new GUI.Bill.fCheckOut();
                    frm.Id_bill = id_bill;
                    this.Close();
                    frm.ShowDialog();
                    this.id_reservation = 0;
                }
                else
                {
                    MessageBox.Show("Reservation has finshed paid!");
                    this.id_reservation = 0;
                }
            }
            else
            {
                MessageBox.Show("You must select reservation");
                this.Id_reservation = 0;
            }
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bool flat = true;
            if(txt_search.Text == "")
            {
                flat = false;
                MessageBox.Show("Error! Key word is not emtyl");
                return;
            }
            if(cb_search.SelectedIndex == -1)
            {
                flat = false;
                MessageBox.Show("Error! You must select option!");
                return;
            }

            if (flat)
            {

            }
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            fReservation_info frm = new fReservation_info();
            frm.ShowDialog();
        }

        private void btn_check_deposit_Click(object sender, EventArgs e)
        {
            if(this.id_reservation != 0)
            {
                fCheck_deposit frm = new fCheck_deposit();
                frm.Id_reservation = this.id_reservation;
                frm.ShowDialog();
                this.id_reservation = 0;
            }
            else
            {
                MessageBox.Show("You must select reservation");
                this.Id_reservation = 0;
            }
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(this.id_reservation != 0)
            {
                int status = Reservation_BUS.Instance.GetInfoReservation(this.id_reservation).Status_reservation;
                if (status != 0 && status != 1)
                {
                    fOption_reservation frm = new fOption_reservation();
                    frm.Id_reservation = this.Id_reservation;
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                    this.id_reservation = 0;
                }
                else
                {
                    MessageBox.Show("Error! Reservation is not edit!");
                }
            }
            else
            {
                MessageBox.Show("You must select reservation!");
            }
        }
    }
}
