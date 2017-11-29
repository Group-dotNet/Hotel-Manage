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

namespace app.GUI.Room
{
    public partial class fCancel_room : Form
    {
        public fCancel_room()
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
        private void Load_List_Room()
        {
            List<Reservation_room_DTO> list_room = Reservation_room_BUS.Instance.Get_ListReservation_Using(this.id_reservation);
            foreach (Reservation_room_DTO room in list_room)
            {
                ComboboxItem item = new ComboboxItem();
                string name_room = "Room " + ((room.Room.Num_floor * 100) + room.Room.Num_order).ToString();
                item.Text = name_room;
                item.Value = room.Room.Id_room;
                cb_list_room.Items.Add(item);
            }
        }

        private void fCancel_room_Load(object sender, EventArgs e)
        {
            Load_List_Room();
        }
    }
}
