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
    public partial class fHistory_room : Form
    {
        public fHistory_room()
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
            List<Reservation_room_DTO> list_reservation_room = Reservation_room_BUS.Instance.GetListHistoryRoom(this.id_reservation);
            foreach(Reservation_room_DTO reservation_room in list_reservation_room)
            {
                ListViewItem item = new ListViewItem(reservation_room.Room.Id_room.ToString());
                item.SubItems.Add(reservation_room.Room.Num_floor.ToString());
                item.SubItems.Add(reservation_room.Room.Num_order.ToString());
                if (reservation_room.Using == 1)
                {
                    item.SubItems.Add("Using");
                }
                else if (reservation_room.Using == 0) item.SubItems.Add("Cancel");
                else item.SubItems.Add("Swap");
                listView1.Items.Add(item);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void fHistory_room_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
