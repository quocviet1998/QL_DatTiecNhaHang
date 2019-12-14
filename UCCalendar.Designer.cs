namespace QL_DatTiecNhaHang
{
    partial class UCCalendar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.RangeControlRange rangeControlRange1 = new DevExpress.XtraEditors.RangeControlRange();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.rangeControl1 = new DevExpress.XtraEditors.RangeControl();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // rangeControl1
            // 
            this.rangeControl1.Client = this.schedulerControl1;
            this.rangeControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rangeControl1.Location = new System.Drawing.Point(0, 0);
            this.rangeControl1.Name = "rangeControl1";
            rangeControlRange1.Maximum = new System.DateTime(2019, 10, 14, 0, 0, 0, 0);
            rangeControlRange1.Minimum = new System.DateTime(2019, 10, 5, 0, 0, 0, 0);
            rangeControlRange1.Owner = this.rangeControl1;
            this.rangeControl1.SelectedRange = rangeControlRange1;
            this.rangeControl1.SelectionType = DevExpress.XtraEditors.RangeControlSelectionType.Flag;
            this.rangeControl1.Size = new System.Drawing.Size(1146, 107);
            this.rangeControl1.TabIndex = 7;
            this.rangeControl1.Text = "rangeControl1";
            this.rangeControl1.VisibleRangeMaximumScaleFactor = double.PositiveInfinity;
            this.rangeControl1.VisibleRangeScaleFactor = 3.7603305785123968D;
            this.rangeControl1.VisibleRangeStartPosition = 0.29010989010989008D;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 99);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(1146, 714);
            this.schedulerControl1.Start = new System.DateTime(2019, 10, 5, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 6;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.AgendaView.Enabled = false;
            this.schedulerControl1.Views.DayView.DayCount = 9;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.GanttView.Enabled = false;
            this.schedulerControl1.Views.MonthView.Enabled = false;
            this.schedulerControl1.Views.TimelineView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            // 
            // UCCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rangeControl1);
            this.Controls.Add(this.schedulerControl1);
            this.Name = "UCCalendar";
            this.Size = new System.Drawing.Size(1146, 813);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private DevExpress.XtraEditors.RangeControl rangeControl1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
    }
}
