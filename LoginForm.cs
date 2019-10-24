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
using QL_DatTiecNhaHang.CustomClasses;

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
            if(string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                XtraMessageBox.Show(MessageBoxConst.USERNAME_REQUIRED, MessageBoxConst.NOTIFICATION,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                XtraMessageBox.Show(MessageBoxConst.PASSWORD_REQUIRED, MessageBoxConst.NOTIFICATION,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            QLNguoiDung qLNguoiDung = new QLNguoiDung();
            var result = qLNguoiDung.CheckUser(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (result == 1)
            {
                XtraMessageBox.Show(MessageBoxConst.LOGIN_SUCCESSFULLY, MessageBoxConst.NOTIFICATION,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                status = 1;
            }
            else if (result == 0)
            {
                XtraMessageBox.Show(MessageBoxConst.ACCOUNT_DISABLED);
                status = 0;
            }
            else
            {
                XtraMessageBox.Show(MessageBoxConst.LOGIN_FAILED, MessageBoxConst.NOTIFICATION,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                status = 1;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}