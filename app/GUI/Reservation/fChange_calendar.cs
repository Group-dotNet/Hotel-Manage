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
        private void LoadData()
        {
            Calendar_DTO calendar = Calendar_BUS.Instance.GetCalendarReservationUsing(this.id_reservation);
            lb_reservation.Text = calendar.Reservation.Id_reservation.ToString();
            lb_start_date.Text = calendar.Start_date.ToString();
            lb_end_date.Text = calendar.End_date.ToString();
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

        }

        private void cb_select_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cb_select.SelectedIndex == 1)
            {
                dpt_date_end.Enabled = true;
            }
            else
            {
                dpt_date_end.Enabled = false;
            }
        }
    }
}
