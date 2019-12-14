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
        private string idDV;
        private bool isAdd = false;

        public ExtraServiceForm()
        {
            InitializeComponent();
            loadDB();
        }



        private void ExtraServiceForm_Load(object sender, EventArgs e)
        {
            
            loadDB();
        }

        private void loadDB()
        {

            //dichvuTableAdapter1.Fill(qlDatTiecNhaHangDataSet1.DICHVU);
            //btnLuu.Enabled = false;
            DataSourceDataContext db = new DataSourceDataContext();
            var dsservice = db.DICHVUs.ToList();
            gridControl1.DataSource = dsservice;
        }

        private void ExtraServiceForm_Click(object sender, DevExpress.XtraBars.ItemCancelEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e) //xóa
        {
            if (XtraMessageBox.Show(MessageBoxConst.DELETE_CONFIRM, MessageBoxConst.NOTIFICATION,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.No)
                return;

            try
            {
                dichvuTableAdapter1.Delete(int.Parse(idDV));
                XtraMessageBox.Show(MessageBoxConst.DELETED_SUCCESSFULLY, MessageBoxConst.NOTIFICATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDB();
            }
            catch
            {
                XtraMessageBox.Show(MessageBoxConst.ERROR_WHEN_DELETE_VALUE, MessageBoxConst.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)//thêm
        {
            isAdd = true;
            ClearTextBox();
            textEdit1.Focus();

           

            if (XtraMessageBox.Show(MessageBoxConst.INSERT_COMFORM, MessageBoxConst.NOTIFICATION,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.No)
                return;

            //DataSourceDataContext db = new DataSourceDataContext();
            //var _service = db.DICHVUs.Select(t => t).SingleOrDefault();
            //db.DICHVUs.DeleteOnSubmit(_service);
            //db.SubmitChanges();
            //loadDB();
            try
            {
                dichvuTableAdapter1.Insert(int.Parse(idDV));
                XtraMessageBox.Show(MessageBoxConst.INSERT_COMFORM, MessageBoxConst.NOTIFICATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDB();
            }
            catch
            {
                XtraMessageBox.Show(MessageBoxConst.ERROR_WHEN_INSERT_VALUE, MessageBoxConst.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            // do dl len textbox
            textEdit1.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "TenDV").ToString();
            textEdit2.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "DonGiaDV").ToString();
            textEdit5.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "GhiChu").ToString();
        }
    }
}