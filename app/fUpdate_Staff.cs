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
    public partial class fUpdate_Staff : Form
    {
        public fUpdate_Staff()
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

        private void fUpdate_Staff_Load(object sender, EventArgs e)
        {

        }
    }
}
