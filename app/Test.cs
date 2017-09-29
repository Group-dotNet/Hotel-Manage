using app.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            label1.Text = Convert.ToString(Connect.Instance.ExecuteScalar("exec dbo.USP_CountAccount @id_type", new object[]{"1"}));
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }
    }
}
