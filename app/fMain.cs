using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace app
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
           
        }

        #region Method

        private String username;

        public string Username { get { return username; } set { username = value; } }


        #endregion

        #region Event

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProfile frm = new fProfile();
            frm.Username = this.Username;
            frm.ShowDialog();


        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChange_pass frm = new fChange_pass();
            frm.Username = this.Username;
            frm.ShowDialog();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Staff.fManage_staff frm = new GUI.Staff.fManage_staff();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fMain_Load(object sender, EventArgs e)
        {
            lb_name.Text = this.Username;
        }


        #endregion

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Customer.fManage_customer frm = new GUI.Customer.fManage_customer();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Room.fManage_room frm = new GUI.Room.fManage_room();
            frm.Choose_floor = 1;
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Reservation.fManage_reservation frm = new GUI.Reservation.fManage_reservation();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Bill.fCheckOut  frm = new GUI.Bill.fCheckOut();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Bill.fManage_Bill frm = new GUI.Bill.fManage_Bill();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
