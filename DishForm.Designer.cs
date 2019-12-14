namespace QL_DatTiecNhaHang
{
    partial class DishForm
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
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.qlDatTiecNhaHangDataSet1 = new QL_DatTiecNhaHang.QLDatTiecNhaHangDataSet();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.monanTableAdapter1 = new QL_DatTiecNhaHang.QLDatTiecNhaHangDataSetTableAdapters.MONANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlDatTiecNhaHangDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(705, 119);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(81, 43);
            this.simpleButton3.TabIndex = 38;
            this.simpleButton3.Text = "Sửa";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(498, 119);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(81, 43);
            this.simpleButton4.TabIndex = 37;
            this.simpleButton4.Text = "Xóa";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(307, 119);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(81, 43);
            this.simpleButton2.TabIndex = 36;
            this.simpleButton2.Text = "Thêm";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(105, 119);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(81, 43);
            this.simpleButton1.TabIndex = 35;
            this.simpleButton1.Text = "Tìm kiếm";
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(231, 84);
            this.textEdit5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(486, 20);
            this.textEdit5.TabIndex = 32;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(105, 86);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 13);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "Ghi chú";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(231, 38);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(236, 20);
            this.textEdit1.TabIndex = 22;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(105, 41);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Tên món ăn";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMA,
            this.colTenMA,
            this.colDVT,
            this.colDonGia,
            this.colGhiChu,
            this.colIdLMA});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIdMA
            // 
            this.colIdMA.FieldName = "IdMA";
            this.colIdMA.MinWidth = 21;
            this.colIdMA.Name = "colIdMA";
            this.colIdMA.Visible = true;
            this.colIdMA.VisibleIndex = 0;
            this.colIdMA.Width = 81;
            // 
            // colTenMA
            // 
            this.colTenMA.FieldName = "TenMA";
            this.colTenMA.MinWidth = 21;
            this.colTenMA.Name = "colTenMA";
            this.colTenMA.Visible = true;
            this.colTenMA.VisibleIndex = 1;
            this.colTenMA.Width = 81;
            // 
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 21;
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 81;
            // 
            // colDonGia
            // 
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.MinWidth = 21;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 3;
            this.colDonGia.Width = 81;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.MinWidth = 21;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 4;
            this.colGhiChu.Width = 81;
            // 
            // colIdLMA
            // 
            this.colIdLMA.FieldName = "IdLMA";
            this.colIdLMA.MinWidth = 21;
            this.colIdLMA.Name = "colIdLMA";
            this.colIdLMA.Visible = true;
            this.colIdLMA.VisibleIndex = 5;
            this.colIdLMA.Width = 81;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "MONAN";
            this.gridControl1.DataSource = this.qlDatTiecNhaHangDataSet1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            // 
            // 
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 189);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(891, 347);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // qlDatTiecNhaHangDataSet1
            // 
            this.qlDatTiecNhaHangDataSet1.DataSetName = "QLDatTiecNhaHangDataSet";
            this.qlDatTiecNhaHangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(231, 61);
            this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            // 
            // 
            // 
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(236, 20);
            this.comboBoxEdit1.TabIndex = 39;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(105, 63);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 13);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "Tên danh mục món ăn";
            // 
            // monanTableAdapter1
            // 
            this.monanTableAdapter1.ClearBeforeFill = true;
            // 
            // DishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 536);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DishForm";
            this.Text = "DishForm";
            this.Load += new System.EventHandler(this.DishForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlDatTiecNhaHangDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMA;
        private DevExpress.XtraGrid.Columns.GridColumn colTenMA;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLMA;
        private QLDatTiecNhaHangDataSet qlDatTiecNhaHangDataSet1;
        private QLDatTiecNhaHangDataSetTableAdapters.MONANTableAdapter monanTableAdapter1;
    }
}