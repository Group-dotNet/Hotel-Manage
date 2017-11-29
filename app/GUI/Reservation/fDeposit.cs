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
    public partial class fDeposit : Form
    {
        public fDeposit()
        {
            InitializeComponent();
        }
        private int id_reservation;

        private double deposit_new;


        private double deposit_old;

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

        public double Deposit_new
        {
            get
            {
                return deposit_new;
            }

            set
            {
                deposit_new = value;
            }
        }

        public double Deposit_old
        {
            get
            {
                return deposit_old;
            }

            set
            {
                deposit_old = value;
            }
        }

        private double check_deposit_new()
        {
            Calendar_DTO calendar = Calendar_BUS.Instance.GetCalendarReservationUsing(this.id_reservation);
            List<Reservation_room_DTO> list_reservation_room = Reservation_room_BUS.Instance.Get_ListReservation_Using(this.id_reservation);

            
            double xmod = 0;
            if (calendar.End_date != null) // neu không hen lich se coi nhu 3 ngay
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

            double total = 0;
            foreach(Reservation_room_DTO reservation_room in list_reservation_room)
            {
                
                total = total + ((double)reservation_room.Room.Kind_of_room.Price * xmod);
            }

            List<Log_swap_room_DTO> list_log = Log_swap_room_BUS.Instance.ListRoomCancel(this.id_reservation);
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

            total = total + total_room_cancel;
            return  (total * 0.3);

        }

        private double check_deposit_old()
        {
            return Deposit_BUS.Instance.Check_Deposit_Old(this.id_reservation);

        }



        private bool Check_Confirm()
        {
            return true;
        }

        private void fDeposit_Load(object sender, EventArgs e)
        {
            this.deposit_new = check_deposit_new();
            this.deposit_old = check_deposit_old();


            cb_confirm.SelectedIndex = 0;
            lb_resevation.Text = this.id_reservation.ToString();
            lb_desposit_new.Text = this.Deposit_new.ToString();
            lb_deposit_old.Text = this.Deposit_old.ToString();
            lb_rest.Text = (this.deposit_new - this.deposit_old).ToString();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI.Other.Calculator frm = new Other.Calculator();
            frm.ShowDialog();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(cb_confirm.SelectedIndex != 0)
            {
                if (Deposit_BUS.Instance.InsertDeposit(id_reservation, this.deposit_new, true ))
                {
                    MessageBox.Show("Success!");
                    this.Close();
                }
                else
                    MessageBox.Show("Error!");
            }
            else
            {
                if (MessageBox.Show("Are you sure \" Not paid\" ?", "Notifile", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    Reservation_BUS.Instance.Cancel_Reservation(id_reservation);
                    MessageBox.Show("Cancelled Reservation!");
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }
    }
}
