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
    public partial class PhanQuyenForm : DevExpress.XtraEditors.XtraForm
    {
        
        public PhanQuyenForm()
        {
            InitializeComponent();
            test();
        }
        public void test()
        {
            UCDanhMuc c = new UCDanhMuc();
            //uC_DM1._Add += UcDanhMuc1__Add;
            //uC_DM1._Load += UC_DM1__Load;
            
        }

        private void UC_DM1__Load(object sender, EventArgs e)
        {
            //uC_DM1.sqlCommandString = "NHANVIEN_GetAll";
        }

        private void UcDanhMuc1__Add(object sender, EventArgs e)
        {
            MessageBox.Show("click btn on form");
        }
    }
}