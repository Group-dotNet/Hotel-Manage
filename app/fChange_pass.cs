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
    public partial class fChange_pass : Form
    {
        public fChange_pass()
        {
            InitializeComponent();
        }

        #region Method

        private String username;

        public string Username { get => username; set => username = value; }
        #endregion

        private void fChange_pass_Load(object sender, EventArgs e)
        {
            txt_username.Text = this.Username;
        }
    }
}
