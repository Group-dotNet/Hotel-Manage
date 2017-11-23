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
    public partial class fCheck_Service : Form
    {
        public fCheck_Service()
        {
            InitializeComponent();
        }

        private int id_reservation;

        private int total_money;

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

        public int Total_money
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

        private void Load_Data()
        {
            List<Service_ticket_DTO> list_service_reservation = Service_ticket_BUS.Instance.Get_ListServiceReservation(this.id_reservation);
            int total = 0;
            foreach (Service_ticket_DTO service in list_service_reservation)
            {
                ListViewItem item = new ListViewItem(service.Reservation_room.Room.Id_room.ToString());
                item.SubItems.Add(service.Service.Id_service.ToString());
                item.SubItems.Add(service.Service.Name_service.ToString());
                total = total + ((int)service.Service.Price * service.Number);
                item.SubItems.Add(((int)service.Service.Price).ToString());
                item.SubItems.Add(service.Number.ToString());
                item.SubItems.Add(service.Date_use.ToString());
                lv_check_service.Items.Add(item);
            }
            this.total_money = total;
            lb_money.Text = this.total_money.ToString() + " VND";
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fCheck_Service_Load(object sender, EventArgs e)
        {
            lb_reservation.Text = "Reservation: " + this.id_reservation.ToString();
            lb_money.Text = this.total_money.ToString();
            Load_Data();
        }
    }
}
