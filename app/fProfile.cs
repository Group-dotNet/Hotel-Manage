using app.DAO;
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

namespace app
{
    public partial class fProfile : Form
    {
        public fProfile()
        {
            InitializeComponent();
        }

        #region Method 

        private String username;

        public string Username { get => username; set => username = value; }

        #endregion

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }


        private void fProfile_Load(object sender, EventArgs e)
        {
            txt_username.Text = this.username;
            Staff_DTO staff_info = Staff_DAO.Instance.Get_Info(this.username);
            
        }
    }
}
