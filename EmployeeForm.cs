﻿using System;
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
    public partial class EmployeeForm : DevExpress.XtraEditors.XtraForm
    {
        public EmployeeForm()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            nhanvienTableAdapter1.Fill(qlDatTiecNhaHangDataSet1.NHANVIEN);
        }
    }
}