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
            List<Calendar_DTO> list_calendar = Calendar_BUS.Instance.GetListCalendar(this.id_reservation);
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

        }
    }
}
