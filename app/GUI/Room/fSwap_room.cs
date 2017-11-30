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
    public partial class fSwap_room : Form
    {
        public fSwap_room()
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

        private void Load_room_old()
        {
            List<Reservation_room_DTO> list_room_using = Reservation_room_BUS.Instance.Get_ListReservation_Using(this.id_reservation);
            foreach(Reservation_room_DTO room_using in list_room_using)
            {
                ComboboxItem item = new ComboboxItem();
                string room = "Room " + ((room_using.Room.Num_floor * 100) + room_using.Room.Num_order).ToString();
                item.Text = room;
                item.Value = room_using.Id_reservation_room;
                cb_list_room_old.Items.Add(item);
            }
        }



        private void fSwap_room_Load(object sender, EventArgs e)
        {
            Load_room_old();
        }

        private void cb_list_room_old_SelectedValueChanged(object sender, EventArgs e)
        {
            cb_list_room_new.Items.Clear();
            ComboboxItem room_old = (ComboboxItem)cb_list_room_old.SelectedItem;
            int id_kind_of_room = Kind_of_room_BUS.Instance.GetIDKindOfRoom((int)room_old.Value);
            List<Room_DTO> list_room_new = Room_BUS.Instance.List_Room_By_Type(id_kind_of_room);
            foreach(Room_DTO room in list_room_new)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = "Room " + ((room.Num_floor * 100) + room.Num_order).ToString();
                item.Value = room.Id_room;
                cb_list_room_new.Items.Add(item);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            ComboboxItem item_old = (ComboboxItem)cb_list_room_old.SelectedItem;
            ComboboxItem item_new = (ComboboxItem)cb_list_room_new.SelectedItem;
            if(Log_swap_room_BUS.Instance.SwapRoom((int)item_old.Value, (int)item_new.Value))
            {
                MessageBox.Show("Swap room is success!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Swap room is fail!");
                this.Close();
            }
            
        }
    }
}
