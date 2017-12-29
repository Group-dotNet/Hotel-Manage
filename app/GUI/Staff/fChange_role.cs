using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.GUI.Staff
{
    public partial class fChange_role : Form
    {
        public fChange_role()
        {
            InitializeComponent();
        }

        private string username;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        private void fChange_role_Load(object sender, EventArgs e)
        {
            int role = BUS.System_BUS.Instance.Get_Account(this.username).Id_type;
            comboBox1.SelectedIndex = role;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BUS.System_BUS.Instance.Change_role(this.username, this.comboBox1.SelectedIndex) == true)
            {
                MessageBox.Show("Success!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
