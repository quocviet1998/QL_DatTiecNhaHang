namespace QL_DatTiecNhaHang
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.qlDatTiecNhaHangDataSet1 = new QL_DatTiecNhaHang.QLDatTiecNhaHangDataSet();
            this.nhanvienTableAdapter1 = new QL_DatTiecNhaHang.QLDatTiecNhaHangDataSetTableAdapters.NHANVIENTableAdapter();
            this.colIdNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinhNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinhNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChiNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoaiNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChuNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlDatTiecNhaHangDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "NHANVIEN";
            this.gridControl1.DataSource = this.qlDatTiecNhaHangDataSet1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 305);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1170, 479);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdNV,
            this.colHoTenNV,
            this.colNgaySinhNV,
            this.colGioiTinhNV,
            this.colDiaChiNV,
            this.colDienThoaiNV,
            this.colGhiChuNV,
            this.colIdBP});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Họ tên";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(122, 30);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(275, 22);
            this.textEdit1.TabIndex = 2;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(122, 58);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Mask.EditMask = "d";
            this.textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.textEdit2.Size = new System.Drawing.Size(275, 22);
            this.textEdit2.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(41, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ngày sinh";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(642, 58);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(275, 22);
            this.textEdit3.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(561, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "SDT";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(642, 30);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(275, 22);
            this.textEdit4.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(561, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 16);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Địa chỉ";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(642, 86);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(139, 22);
            this.comboBoxEdit1.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(561, 89);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Giới tính";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(41, 117);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 16);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Ghi chú";
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(122, 114);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(795, 22);
            this.textEdit5.TabIndex = 12;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(122, 86);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(275, 22);
            this.comboBoxEdit2.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(41, 89);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 16);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Bộ phận";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(122, 162);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 53);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "Tìm kiếm";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(358, 162);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 53);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "Thêm";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(823, 162);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(94, 53);
            this.simpleButton3.TabIndex = 19;
            this.simpleButton3.Text = "Sửa";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(581, 162);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(94, 53);
            this.simpleButton4.TabIndex = 18;
            this.simpleButton4.Text = "Xóa";
            // 
            // qlDatTiecNhaHangDataSet1
            // 
            this.qlDatTiecNhaHangDataSet1.DataSetName = "QLDatTiecNhaHangDataSet";
            this.qlDatTiecNhaHangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanvienTableAdapter1
            // 
            this.nhanvienTableAdapter1.ClearBeforeFill = true;
            // 
            // colIdNV
            // 
            this.colIdNV.FieldName = "IdNV";
            this.colIdNV.MinWidth = 25;
            this.colIdNV.Name = "colIdNV";
            this.colIdNV.Visible = true;
            this.colIdNV.VisibleIndex = 0;
            this.colIdNV.Width = 94;
            // 
            // colHoTenNV
            // 
            this.colHoTenNV.FieldName = "HoTenNV";
            this.colHoTenNV.MinWidth = 25;
            this.colHoTenNV.Name = "colHoTenNV";
            this.colHoTenNV.Visible = true;
            this.colHoTenNV.VisibleIndex = 1;
            this.colHoTenNV.Width = 94;
            // 
            // colNgaySinhNV
            // 
            this.colNgaySinhNV.FieldName = "NgaySinhNV";
            this.colNgaySinhNV.MinWidth = 25;
            this.colNgaySinhNV.Name = "colNgaySinhNV";
            this.colNgaySinhNV.Visible = true;
            this.colNgaySinhNV.VisibleIndex = 2;
            this.colNgaySinhNV.Width = 94;
            // 
            // colGioiTinhNV
            // 
            this.colGioiTinhNV.FieldName = "GioiTinhNV";
            this.colGioiTinhNV.MinWidth = 25;
            this.colGioiTinhNV.Name = "colGioiTinhNV";
            this.colGioiTinhNV.Visible = true;
            this.colGioiTinhNV.VisibleIndex = 3;
            this.colGioiTinhNV.Width = 94;
            // 
            // colDiaChiNV
            // 
            this.colDiaChiNV.FieldName = "DiaChiNV";
            this.colDiaChiNV.MinWidth = 25;
            this.colDiaChiNV.Name = "colDiaChiNV";
            this.colDiaChiNV.Visible = true;
            this.colDiaChiNV.VisibleIndex = 4;
            this.colDiaChiNV.Width = 94;
            // 
            // colDienThoaiNV
            // 
            this.colDienThoaiNV.FieldName = "DienThoaiNV";
            this.colDienThoaiNV.MinWidth = 25;
            this.colDienThoaiNV.Name = "colDienThoaiNV";
            this.colDienThoaiNV.Visible = true;
            this.colDienThoaiNV.VisibleIndex = 5;
            this.colDienThoaiNV.Width = 94;
            // 
            // colGhiChuNV
            // 
            this.colGhiChuNV.FieldName = "GhiChuNV";
            this.colGhiChuNV.MinWidth = 25;
            this.colGhiChuNV.Name = "colGhiChuNV";
            this.colGhiChuNV.Visible = true;
            this.colGhiChuNV.VisibleIndex = 6;
            this.colGhiChuNV.Width = 94;
            // 
            // colIdBP
            // 
            this.colIdBP.FieldName = "IdBP";
            this.colIdBP.MinWidth = 25;
            this.colIdBP.Name = "colIdBP";
            this.colIdBP.Visible = true;
            this.colIdBP.VisibleIndex = 7;
            this.colIdBP.Width = 94;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 784);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.comboBoxEdit2);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlDatTiecNhaHangDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private QLDatTiecNhaHangDataSet qlDatTiecNhaHangDataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinhNV;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinhNV;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChiNV;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoaiNV;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChuNV;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBP;
        private QLDatTiecNhaHangDataSetTableAdapters.NHANVIENTableAdapter nhanvienTableAdapter1;
    }
}