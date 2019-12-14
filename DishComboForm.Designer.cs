namespace QL_DatTiecNhaHang
{
    partial class DishComboForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCBMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.qlDatTiecNhaHangDataSet1 = new QL_DatTiecNhaHang.QLDatTiecNhaHangDataSet();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.combO_MONANTableAdapter1 = new QL_DatTiecNhaHang.QLDatTiecNhaHangDataSetTableAdapters.COMBO_MONANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlDatTiecNhaHangDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(705, 100);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(81, 43);
            this.simpleButton3.TabIndex = 49;
            this.simpleButton3.Text = "Sửa";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(498, 100);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(81, 43);
            this.simpleButton4.TabIndex = 48;
            this.simpleButton4.Text = "Xóa";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(307, 100);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(81, 43);
            this.simpleButton2.TabIndex = 47;
            this.simpleButton2.Text = "Thêm";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(105, 100);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(81, 43);
            this.simpleButton1.TabIndex = 46;
            this.simpleButton1.Text = "Tìm kiếm";
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(231, 64);
            this.textEdit5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(486, 20);
            this.textEdit5.TabIndex = 45;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(105, 67);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 13);
            this.labelControl6.TabIndex = 44;
            this.labelControl6.Text = "Ghi chú";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(105, 21);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "Tên combo";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCBMA,
            this.colGhiChu});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIdCBMA
            // 
            this.colIdCBMA.FieldName = "IdCBMA";
            this.colIdCBMA.MinWidth = 21;
            this.colIdCBMA.Name = "colIdCBMA";
            this.colIdCBMA.Visible = true;
            this.colIdCBMA.VisibleIndex = 0;
            this.colIdCBMA.Width = 81;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.MinWidth = 21;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 1;
            this.colGhiChu.Width = 81;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "COMBO_MONAN";
            this.gridControl1.DataSource = this.qlDatTiecNhaHangDataSet1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            // 
            // 
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 170);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(955, 435);
            this.gridControl1.TabIndex = 41;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // qlDatTiecNhaHangDataSet1
            // 
            this.qlDatTiecNhaHangDataSet1.DataSetName = "QLDatTiecNhaHangDataSet";
            this.qlDatTiecNhaHangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(105, 44);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 51;
            this.labelControl2.Text = "Giá combo";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(231, 41);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(183, 20);
            this.textEdit2.TabIndex = 52;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(231, 19);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(183, 20);
            this.textEdit1.TabIndex = 53;
            // 
            // combO_MONANTableAdapter1
            // 
            this.combO_MONANTableAdapter1.ClearBeforeFill = true;
            // 
            // DishComboForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 605);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DishComboForm";
            this.Text = "DishComboForm";
            this.Load += new System.EventHandler(this.DishComboForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlDatTiecNhaHangDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCBMA;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private QLDatTiecNhaHangDataSet qlDatTiecNhaHangDataSet1;
        private QLDatTiecNhaHangDataSetTableAdapters.COMBO_MONANTableAdapter combO_MONANTableAdapter1;
    }
}