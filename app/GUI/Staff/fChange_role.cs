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

        }
    }
}
