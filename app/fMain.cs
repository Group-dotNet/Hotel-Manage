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
using Tulpep.NotificationWindow;


namespace app
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
           
        }

        private DateTime choose_date = DateTime.Now;

        public DateTime Choose_date
        {
            get
            {
                return choose_date;
            }

            set
            {
                choose_date = value;
            }
        }


        private bool Check_Admin()
        {
            if (BUS.System_BUS.Instance.Get_Account(DTO.Session.username).Id_type == 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("You don't have permission to view details!");
                return false;
            }
        }

        #region Method
        private void Load_Data()
        {
            lb_name.Text = Staff_BUS.Instance.Get_Info(DTO.Session.username).Name;
            MemoryStream stream = new MemoryStream(Staff_BUS.Instance.Get_Info(DTO.Session.username).Image);
            pictureBox1.Image = Image.FromStream(stream);
            DateTime now = DateTime.Now;
            lb_time.Text = now.Hour + ":" + now.Minute + ":" + now.Second;

            
        }

        private void Load_Analytic(DateTime date)
        {
            if(BUS.System_BUS.Instance.Get_Account(DTO.Session.username).Id_type == 1)
            {
                number_reservation.Text = BUS.Analytic_BUS.Instance.CountReservationInDay(date).ToString();
                number_room_emty.Text = BUS.Analytic_BUS.Instance.CountRoomEmtyInDay().ToString();
                number_room_using.Text = BUS.Analytic_BUS.Instance.CountRoomUsingInDay().ToString();
                number_service.Text = BUS.Analytic_BUS.Instance.CountServiceUsingInDay(date).ToString();
                number_checkout.Text = BUS.Analytic_BUS.Instance.CountBillInDay(date).ToString();
                number_turnover.Text = BUS.Analytic_BUS.Instance.CountRevenueInDay(date).ToString();
            }
            else
            {
                number_reservation.Text = "Locked";
                number_room_emty.Text = BUS.Analytic_BUS.Instance.CountRoomEmtyInDay().ToString();
                number_room_using.Text = BUS.Analytic_BUS.Instance.CountRoomUsingInDay().ToString();
                number_service.Text = "Locked";
                number_checkout.Text = "Locked";
                number_turnover.Text = "Locked";
            }
        }

        private void Load_Message_And_History(DateTime date)
        {
            BUS.Message_BUS.Instance.Check_Reservation();
            int x = BUS.Message_BUS.Instance.GetNotifire();
            if (x > 0)
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.if_megaphone_1296371;
                popup.TitleText = "Reservation is about to expire";
                popup.ContentText = "You have " + x.ToString() + " new message";
                popup.Popup();
            }
            

            List<DTO.History_DTO> list_history = History_BUS.Instance.Get_List_History(date);
            List<DTO.Message_DTO> list_message = Message_BUS.Instance.Get_List_Message(date);
            listView1.Items.Clear();
            listView2.Items.Clear();
            if(BUS.System_BUS.Instance.Get_Account(DTO.Session.username).Id_type == 1)
            {
                foreach (DTO.History_DTO history in list_history)
                {
                    ListViewItem item = new ListViewItem(history.Id_history.ToString());
                    item.SubItems.Add(history.Username);
                    item.SubItems.Add(history.Content);
                    item.SubItems.Add(history.Created.ToString());
                    listView2.Items.Add(item);
                }
            }
            else
            {
                listView2.Visible = false;
            }
            

            foreach(DTO.Message_DTO message in list_message)
            {
                ListViewItem item = new ListViewItem(message.Id_message.ToString());
                if(message.Checked == false)
                    item.ForeColor = Color.Orange;
                item.SubItems.Add(message.Id_reservation.ToString());
                item.SubItems.Add(message.Content);
                item.SubItems.Add(message.Created.ToString());
                listView1.Items.Add(item);
            }
        }
        #endregion

        #region Event

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProfile frm = new fProfile();
            frm.Username = DTO.Session.username;
            frm.ShowDialog();
            Load_Data();

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChange_pass frm = new fChange_pass();
            frm.Username = DTO.Session.username;
            frm.ShowDialog();
            Load_Data();
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
            Load_Data();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fMain_Load(object sender, EventArgs e)
        {
            Load_Data();
            DateTime date = new DateTime(this.dateTimePicker1.Value.Year, this.dateTimePicker1.Value.Month, this.dateTimePicker1.Value.Day);
            Load_Analytic(date);
            Load_Message_And_History(date);
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
            fTablePriceService frm = new fTablePriceService();
            frm.ShowDialog();
            Load_Data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fTablePriceRoom frm = new fTablePriceRoom();
            frm.ShowDialog();
            Load_Data();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string content = DTO.Session.username + " has been logged out of the system!";
            BUS.History_BUS.Instance.Insert_History(DTO.Session.username, content);
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = (DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + ":" + (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString()) + ":" + (DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
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
            if(this.Check_Admin() == true)
            {
                GUI.Analytic.fAnalytic frm = new GUI.Analytic.fAnalytic();
                this.Hide();
                frm.ShowDialog();
                this.Show();
                Load_Data();
            }
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
            frm.Username = DTO.Session.username;
            frm.ShowDialog();
            Load_Data();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            string content = DTO.Session.username + " has been logged out of the system!";
            BUS.History_BUS.Instance.Insert_History(DTO.Session.username, content);
            DTO.Session.username = null;
        }

        private void lb_time_Click(object sender, EventArgs e)
        {

        }

        private void request_analytic_Tick(object sender, EventArgs e)
        {
            Load_Analytic(this.choose_date);
            Load_Message_And_History(this.Choose_date);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.choose_date = new DateTime(this.dateTimePicker1.Value.Year, this.dateTimePicker1.Value.Month, this.dateTimePicker1.Value.Day);
            Load_Analytic(this.choose_date);
            Load_Message_And_History(this.choose_date);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (Check_Admin() == true)
            {
                GUI.Analytic.fAnalytic frm = new GUI.Analytic.fAnalytic();
                frm.Choose = 3;
                frm.Input_date = dateTimePicker1.Value;
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Check_Admin() == true)
            {
                GUI.Analytic.fAnalytic frm = new GUI.Analytic.fAnalytic();
                frm.Choose = 4;
                frm.Input_date = dateTimePicker1.Value;
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (Check_Admin() == true)
            {
                GUI.Analytic.fAnalytic frm = new GUI.Analytic.fAnalytic();
                frm.Choose = 5;
                frm.Input_date = dateTimePicker1.Value;
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void number_reservation_Click(object sender, EventArgs e)
        {
            if (Check_Admin() == true)
            {
                GUI.Analytic.fAnalytic frm = new GUI.Analytic.fAnalytic();
                frm.Choose = 1;
                frm.Input_date = dateTimePicker1.Value;
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void v_Click(object sender, EventArgs e)
        {
            if (Check_Admin() == true)
            {
                GUI.Analytic.fAnalytic frm = new GUI.Analytic.fAnalytic();
                frm.Choose = 2;
                frm.Input_date = dateTimePicker1.Value;
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void number_turnover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry! We are buldding!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(BUS.Message_BUS.Instance.Checked_Message() == true)
            {
                MessageBox.Show("Update is success!");
                Load_Data();
                DateTime date = new DateTime(this.dateTimePicker1.Value.Year, this.dateTimePicker1.Value.Month, this.dateTimePicker1.Value.Day);
                Load_Analytic(date);
                Load_Message_And_History(date);
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
