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

namespace QliDatTiec
{
    public partial class DrinkForm : DevExpress.XtraEditors.XtraForm
    {

        private string idDU;
        private bool isAdd = false;

        public DrinkForm()
        {
            InitializeComponent();
            
        }

        private void DrinkForm_Load(object sender, EventArgs e)
        {
           
        }

        private void loadDB()
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)//thêm
        {
            isAdd = true;
            ClearTextBox();
            textEdit1.Focus();
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

        

    }
}