using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraEditors;
using QL_DatTiecNhaHang.CustomClasses;
using QliDatTiec;
using DevExpress.XtraTabbedMdi;

namespace QL_DatTiecNhaHang
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        #region Init variables
        private int? idNV;

        public int? IdNV { get => idNV; set => idNV = value; }

        public MainForm()
        {
            IdNV = 1; // set cứng để vào trực tiếp main form
            InitializeComponent();
        }
        public MainForm(int? idNV)
        {
            IdNV = idNV;
            InitializeComponent();
        }
        #endregion

        #region Private functions
        private void initSkin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel customSkin = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            customSkin.LookAndFeel.SkinName = "Metropolis";
        }

        private void getNhanVienInfo()
        {
            if (IdNV == null)
            {
                XtraMessageBox.Show(MessageBoxConst.FAILED_TO_GET_NV, MessageBoxConst.ERROR, MessageBoxButtons.OK);
                Close();
                return;
            }
            QLNguoiDung user = new QLNguoiDung();
            var info = user.getNhanVienById((int)IdNV);
            MessageBox.Show(info.HoTenNV);
        }

        private void createChildForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private bool isFormActive(Form form)
        {
            bool isOpen = false;
            if(MdiChildren.Count() > 0)
            {
                foreach(var childForm in MdiChildren)
                    if(form.Name == childForm.Name)
                    {
                        xTabMdiManager.Pages[childForm].MdiChild.Activate();
                        isOpen = true;
                    }
            }
            return isOpen;
        }
        #endregion

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            getNhanVienInfo();
            initSkin();

            DrinkForm f = new DrinkForm();
            f.MdiParent = this;
            f.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show(MessageBoxConst.EXIT_CONFIRM,
                    MessageBoxConst.NOTIFICATION, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        private void bbtnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
            Dispose();
        }

        private void bbtnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Application.Run(new LoginForm());
            //Close();
            Hide();
            new LoginForm().Show();
            //Application.Run(new LoginForm());
            //Close();
        }
        #endregion

        private void bbtnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!isFormActive(new CustomerForm()))
                createChildForm(new CustomerForm());
        }

        private void bbtnDichVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!isFormActive(new ExtraServiceForm()))
                createChildForm(new ExtraServiceForm());
        }

        private void bbtnDoDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if (!isFormActive(new ExtraServiceForm()))
            //    createChildForm(new ExtraServiceForm());
        }

        private void bbtnDMDoUong_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!isFormActive(new DrinkForm()))
                createChildForm(new DrinkForm());
        }

        private void bbtnDMMonAn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!isFormActive(new DishForm()))
                createChildForm(new DishForm());
        }

        private void bbtnDatTiec_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!isFormActive(new BookingDetailForm()))
                createChildForm(new BookingDetailForm());
        }
    }
}
