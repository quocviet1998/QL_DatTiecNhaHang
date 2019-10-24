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
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            loadDB();
        }

        private void loadDB()
        {
            DataSourceDataContext db = new DataSourceDataContext();
            var dsNhanVien = db.NHANVIENs.ToString();
            gridControl1.DataSource = dsNhanVien;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }
    }
}