﻿using System;
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
    }
}
