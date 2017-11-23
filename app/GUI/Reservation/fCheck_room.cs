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
    public partial class fCheck_room : Form
    {
        public fCheck_room()
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
            List<Reservation_room_DTO> list_reservation_room = Reservation_room_BUS.Instance.Get_ListReservation_Using(this.id_reservation);
            foreach(Reservation_room_DTO reservation_room in list_reservation_room)
            {
                ListViewItem item = new ListViewItem(reservation_room.Id_reservation_room.ToString());
                item.SubItems.Add(reservation_room.Room.Id_room.ToString());
                item.SubItems.Add(reservation_room.Room.Kind_of_room.Name.ToString());
                item.SubItems.Add(reservation_room.Room.Kind_of_room.People.ToString());
                item.SubItems.Add(((int)reservation_room.Room.Kind_of_room.Price).ToString());
                listView1.Items.Add(item);
            }
            
        }

        private void fCheck_room_Load(object sender, EventArgs e)
        {
            lb_reservation.Text = "Resevation: " + this.id_reservation.ToString();
            Load_Data();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_history_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fHistory_room frm = new fHistory_room();
            frm.Id_reservation = this.Id_reservation;
            frm.ShowDialog();
        }
    }
}
