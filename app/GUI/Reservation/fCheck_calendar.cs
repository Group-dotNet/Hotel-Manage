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
    public partial class fCheck_calendar : Form
    {
        public fCheck_calendar()
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
            List<Calendar_DTO> list_calendar = Calendar_BUS.Instance.GetListCalendarReservation(this.id_reservation);
            foreach(Calendar_DTO calendar in list_calendar)
            {
                ListViewItem item = new ListViewItem(calendar.Id_calendar.ToString());
                item.SubItems.Add(calendar.Start_date.ToString());
                item.SubItems.Add(calendar.End_date.ToString());
                item.SubItems.Add(calendar.Created.ToString());
                if(calendar.Status == 2)
                {
                    item.SubItems.Add("Swap");
                }
                else
                {
                    if (calendar.Status == 1)
                    {
                        item.SubItems.Add("Active");
                    }
                    else
                    {
                        item.SubItems.Add("Cancel");
                    }
                }
                
                listView1.Items.Add(item);
            }

            Calendar_DTO calendar_info = Calendar_BUS.Instance.GetCalendarReservationUsing(this.Id_reservation);
            lb_id_calendar.Text = calendar_info.Id_calendar.ToString();
            lb_start_date.Text = calendar_info.Start_date.ToString();
            lb_end_date.Text = calendar_info.End_date.ToString();
            lb_created.Text = calendar_info.Created.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fCheck_calendar_Load(object sender, EventArgs e)
        {
            lb_reservation.Text = "Reservation " + this.Id_reservation.ToString();
            LoadData();
        }
    }
}
