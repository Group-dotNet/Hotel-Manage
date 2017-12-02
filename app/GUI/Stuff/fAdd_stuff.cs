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

namespace app.GUI.Stuff
{
    public partial class fAdd_Stuff : Form
    {
        public fAdd_Stuff()
        {
            InitializeComponent();
        }

        private void fAdd_Stuff_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Stuff_DTO stuff = new Stuff_DTO();
            stuff.Name_stuff = txt_stuff.Text;
            if (Stuff_BUS.Instance.Add_Stuff(stuff))
            {
                MessageBox.Show("Add Successful");
                this.Close();
            }
            else
                MessageBox.Show("False");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

