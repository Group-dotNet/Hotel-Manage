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

        #endregion

        #region Event

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProfile frm = new fProfile();
            frm.ShowDialog();

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChange_pass frm = new fChange_pass();
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
            
        }


        #endregion
    }
}
