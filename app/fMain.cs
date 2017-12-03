using app.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void Load_Data()
        {
            lb_name.Text = Staff_BUS.Instance.Get_Info(this.Username).Name;
            MemoryStream stream = new MemoryStream(Staff_BUS.Instance.Get_Info(this.Username).Image);
            pictureBox1.Image = Image.FromStream(stream);
            DateTime now = DateTime.Now;
            lb_time.Text = now.Hour + ":" + now.Minute + ":" + now.Second;
        }

        #endregion

        #region Event

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProfile frm = new fProfile();
            frm.Username = this.Username;
            frm.ShowDialog();
            Load_Data();

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChange_pass frm = new fChange_pass();
            frm.Username = this.Username;
            frm.ShowDialog();
            Load_Data();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.username = null;
            this.Hide();
            this.Close();
            fLogin frm = new fLogin();
            frm.ShowDialog();
            Load_Data();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Staff.fManage_staff frm = new GUI.Staff.fManage_staff();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Load_Data();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fMain_Load(object sender, EventArgs e)
        {
            Load_Data();
        }


        #endregion

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Customer.fManage_customer frm = new GUI.Customer.fManage_customer();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Load_Data();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Room.fManage_room frm = new GUI.Room.fManage_room();
            frm.Choose_floor = 1;
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Load_Data();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Reservation.fManage_reservation frm = new GUI.Reservation.fManage_reservation();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Load_Data();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Bill.fCheckOut  frm = new GUI.Bill.fCheckOut();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Load_Data();
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Bill.fManage_Bill frm = new GUI.Bill.fManage_Bill();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Load_Data();
        }

        private void stuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Stuff.fManage_Stuff frm = new GUI.Stuff.fManage_Stuff();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Load_Data();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Service.fManage_service frm = new GUI.Service.fManage_service();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Load_Data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(System_BUS.Instance.Get_Account(this.username).Id_type == 1)
            {
                GUI.Analytic.fAnalytic frm = new GUI.Analytic.fAnalytic();
                this.Hide();
                frm.ShowDialog();
                this.ShowDialog();
                Load_Data();
            }
            else
            {
                MessageBox.Show("You don't have permission to view details!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fGuide frm = new fGuide();
            frm.ShowDialog();
            Load_Data();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = (DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + ":" + (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString()) + ":" + (DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void analyticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Analytic.fAnalytic frm = new GUI.Analytic.fAnalytic();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Load_Data();
        }

        private void guideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGuide frm = new fGuide();
            frm.ShowDialog();
            Load_Data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fProfile frm = new fProfile();
            frm.Username = this.Username;
            frm.ShowDialog();
            Load_Data();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
