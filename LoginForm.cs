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
        #region Init variables
        private int status, idNV;
        public int Status 
        {
            get { return status;} 
            set { status = value;}
        }

        public int IdNV { get => idNV; set => idNV = value; }

        public LoginForm()
        {
            InitializeComponent();
        }
        #endregion

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

            QLNguoiDung qLNguoiDung = new QLNguoiDung(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            var result = qLNguoiDung.CheckUser();

            if (result == 1)
            {
                IdNV = qLNguoiDung.IdNV;
                XtraMessageBox.Show(MessageBoxConst.LOGIN_SUCCESSFULLY, MessageBoxConst.NOTIFICATION,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status = 1;
                new MainForm(IdNV).ShowDialog();
                this.Close();
            }
            else if (result == 0)
            {
                XtraMessageBox.Show(MessageBoxConst.ACCOUNT_DISABLED, MessageBoxConst.NOTIFICATION,
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Status = 0;
            }
            else
            {
                XtraMessageBox.Show(MessageBoxConst.LOGIN_FAILED, MessageBoxConst.NOTIFICATION,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Status = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openMainForm()
        {
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Show();
        }
    }
}