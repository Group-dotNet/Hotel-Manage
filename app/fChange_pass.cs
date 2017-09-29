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

namespace app
{
    public partial class fChange_pass : Form
    {
        public fChange_pass()
        {
            InitializeComponent();
        }

        #region Method

        private System_DTO account;
        private String username;

        public string Username { get => username; set => username = value; }


        // clear error when run event on-click "edit"
        private void Clear_error()
        {
            lb_error_pass_old.ResetText();
            lb_error_pass_new.ResetText();
            lb_error_check_match.ResetText();
        }


        #endregion

        #region Event

        private void fChange_pass_Load(object sender, EventArgs e)
        {
            txt_username.Text = this.Username;
            txt_pass_old.Focus();

            this.account = System_BUS.Instance.Get_Account(this.Username);

        }


        private void btn_change_Click(object sender, EventArgs e)
        {
            this.Clear_error();
            bool flat = true;

            // Check not empty
            if (txt_pass_old.Text == "")
            {
                lb_error_pass_old.Text = "The \"Password old\" is not empty";
                flat = false;
            }

            // Check not empty
            if (txt_pass_new.Text == "")
            {
                lb_error_pass_new.Text = "The \"Password new\" is not empty";
                flat = false;
            }

            // Check not empty
            if (txt_check_match.Text == "")
            {
                lb_error_check_match.Text = "The \"Check match\" is not empty";
                flat = false;
            }

            // when textboxs are not empty 
            if (flat == true)
            {
                // check pass new is match ?
                if(txt_pass_new.Text == txt_check_match.Text)
                {
                    //Check pass old different pass new ?
                    if (txt_pass_old.Text != txt_pass_new.Text)
                    {
                        //check pass old is right?
                        if (System_BUS.Instance.Check_pass_old(this.Username, txt_pass_old.Text))
                        {
                            if(System_BUS.Instance.Change_password(username, txt_pass_new.Text))
                                MessageBox.Show("Change password is success!");
                            else
                                MessageBox.Show("Cannot change password!");
                        }
                        else
                            MessageBox.Show("The \"Password old\" is wrong!");
                    }
                    else
                        MessageBox.Show("The \"Password new\" must different the \"Password old\"!");
                }
                else
                    MessageBox.Show("The \"Password new\" is not match!");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion
    }
}
