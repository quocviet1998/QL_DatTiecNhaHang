using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QL_DatTiecNhaHang
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private int status;
        public int Status { get => status; set => status = value; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "1")
            {
                MessageBox.Show("Đăng nhập thành công!");
                status = 1;
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
                status = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}