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

namespace app.GUI.Service
{
    public partial class fService_ticket : Form
    {
        public fService_ticket()
        {
            InitializeComponent();
        }

        private int id_room;

        public int Id_room
        {
            get
            {
                return id_room;
            }

            set
            {
                id_room = value;
            }
        }

        private void Load_CB_Service()
        {
            List<Service_DTO> list_service = Service_BUS.Instance.Get_List();
            foreach(Service_DTO service in list_service)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = service.Name_service;
                item.Value = service.Id_service;
                cb_service.Items.Add(item);
            }
        }
        private void Load_Data()
        {
            lv_service_ticket.Items.Clear();
            List<Service_ticket_DTO> list_service_ticket = Service_ticket_BUS.Instance.Get_ListService(this.id_room);
            foreach (Service_ticket_DTO service_ticket in list_service_ticket)
            {
                ListViewItem item = new ListViewItem(service_ticket.Reservation_room.Reservation.Id_reservation.ToString());
                item.SubItems.Add(service_ticket.Reservation_room.Room.Id_room.ToString());
                item.SubItems.Add(service_ticket.Service.Name_service.ToString());
                item.SubItems.Add(service_ticket.Service.Price.ToString());
                item.SubItems.Add(service_ticket.Number.ToString());
                item.SubItems.Add(service_ticket.Date_use.ToString());
                lv_service_ticket.Items.Add(item);
            }
        }
        private void fService_ticket_Load(object sender, EventArgs e)
        {
            Load_CB_Service();
            Load_Data();
            Room_DTO room = Room_BUS.Instance.Get_Info_Room(this.id_room);
            lb_room.Text = "Room " + ((room.Num_floor * 100) + room.Num_order).ToString(); 
        }

        private void lb_room_Click(object sender, EventArgs e)
        {

        }

        private void nud_number_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            ComboboxItem item_service = (ComboboxItem)cb_service.SelectedItem;
            if (Service_ticket_BUS.Instance.Change_Service(this.id_room, (int)item_service.Value, (int)nud_number.Value, DateTime.Now)){
                MessageBox.Show("Commit is success!");
                Load_Data();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
