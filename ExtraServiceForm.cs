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
    public partial class ExtraServiceForm : DevExpress.XtraEditors.XtraForm
    {
        public ExtraServiceForm()
        {
            InitializeComponent();
        }

        

        private void ExtraServiceForm_Load(object sender, EventArgs e)
        {
            loadDB();
        }
        private void loadDB()
        {
            DataSourceDataContext db = new DataSourceDataContext();
            var dsDichVu = db.DICHVUs.ToString();
            gridControl1.DataSource = dsDichVu;
        }

        private void ExtraServiceForm_Click(object sender, DevExpress.XtraBars.ItemCancelEventArgs e)
        {
            
        }
    }
}