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

        private void Load_Data()
        {
            lb_room.Text = "Room " + this.id_room.ToString();

            List<Service_ticket_DTO> list_service_ticket = Service_ticket_BUS.Instance.Get_ListService(this.id_room);
            foreach (Service_ticket_DTO service_ticket in list_service_ticket)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(service_ticket.Service.Name_service.ToString());
                item.SubItems.Add(service_ticket.Number.ToString());
                item.SubItems.Add(service_ticket.Date_use.ToString());
                lv_service_ticket.Items.Add(item);
            }
        }
        private void fService_ticket_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void lb_room_Click(object sender, EventArgs e)
        {

        }
    }
}
