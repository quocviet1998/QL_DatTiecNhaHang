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
using DevExpress.XtraGrid.Views.Grid;
using System.Text.RegularExpressions;

namespace QL_DatTiecNhaHang
{
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm
    {
        private string idKH;
        private bool isAdd = false;

        public CustomerForm()
        {
            InitializeComponent();
            loadDB();

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
        }

        private void loadDB()
        {
            khachhangTableAdapter1.Fill(qlDatTiecNhaHangDataSet1.KHACHHANG);
            //btnLuu.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e) // button them
        {
            isAdd = true;
            ClearTextBox();
            txtHoTen.Focus();
        }

        private void simpleButton2_Click(object sender, EventArgs e) // button xoa
        {
            if (XtraMessageBox.Show(MessageBoxConst.DELETE_CONFIRM, MessageBoxConst.NOTIFICATION,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.No)
                return;

            try
            {
                khachhangTableAdapter1.Delete(int.Parse(idKH));
                XtraMessageBox.Show(MessageBoxConst.DELETED_SUCCESSFULLY, MessageBoxConst.NOTIFICATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDB();
            }
            catch
            {
                XtraMessageBox.Show(MessageBoxConst.ERROR_WHEN_DELETE_VALUE, MessageBoxConst.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void simpleButton3_Click(object sender, EventArgs e) // button luu
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                XtraMessageBox.Show(MessageBoxConst.HOTEN_REQUIRED, MessageBoxConst.ALERT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNgaySinh.Text))
            {
                XtraMessageBox.Show(MessageBoxConst.NGAYSINH_REQUIRED, MessageBoxConst.ALERT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgaySinh.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                XtraMessageBox.Show(MessageBoxConst.HOTEN_REQUIRED, MessageBoxConst.ALERT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDienThoai.Text))
            {
                XtraMessageBox.Show(MessageBoxConst.DIENTHOAI_REQUIRED, MessageBoxConst.ALERT, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienThoai.Focus();
                return;
            }

            if (XtraMessageBox.Show(MessageBoxConst.SAVE_CONFIRM, MessageBoxConst.NOTIFICATION,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
               == DialogResult.No)
                return;


            try
            {
                var tenKh = txtHoTen.Text.Trim();
                var ngaySinhKH = txtNgaySinh.Text;
                var sdt = txtDienThoai.Text.Trim();
                var diaChi = txtDiaChi.Text.Trim();
                var email = txtEmail.Text.Trim();
                var ghiChu = txtGhiChu.Text.Trim();
                var gioiTinh = rdoNam.Checked;
                if (isAdd == true)
                {
                    khachhangTableAdapter1.Insert(tenKh, DateTime.Parse(ngaySinhKH), gioiTinh, diaChi, sdt, email, ghiChu);
                    isAdd = false;
                }
                else
                {
                    khachhangTableAdapter1.Update(int.Parse(idKH), tenKh, DateTime.Parse(ngaySinhKH), gioiTinh, diaChi, sdt, email, ghiChu);
                }
                XtraMessageBox.Show(MessageBoxConst.SAVED_SUCCESSFULLY, MessageBoxConst.NOTIFICATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDB();
            }
            catch
            {
                XtraMessageBox.Show(MessageBoxConst.ERROR_WHEN_INSERT_VALUE, MessageBoxConst.ERROR, MessageBoxButtons.OK);
            }
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            // do dl len textbox
            txtHoTen.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "HoTenKH").ToString();
            txtNgaySinh.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "NgaySinhKH").ToString();
            txtDienThoai.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "DienThoaiKH").ToString();
            txtEmail.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "EmailKH").ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "DiaChiKH").ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "GhiChu").ToString();
            idKH = gridView1.GetRowCellValue(e.FocusedRowHandle, "IdKH").ToString();
            if (bool.Parse(gridView1.GetRowCellValue(e.FocusedRowHandle, "GioiTinhKH").ToString()) == true)
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {

        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
        }

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
        }

    }
}