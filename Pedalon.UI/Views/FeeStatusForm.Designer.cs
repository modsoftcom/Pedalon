namespace Pedalon.UI.Views
{
    partial class FeeStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeeStatusForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridMonth = new DevExpress.XtraGrid.GridControl();
            this.gridViewMonth = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridEntrance = new DevExpress.XtraGrid.GridControl();
            this.gridViewEntrance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridMonth);
            this.layoutControl1.Controls.Add(this.gridEntrance);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(649, 448);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridMonth
            // 
            this.gridMonth.Location = new System.Drawing.Point(86, 211);
            this.gridMonth.MainView = this.gridViewMonth;
            this.gridMonth.Name = "gridMonth";
            this.gridMonth.Size = new System.Drawing.Size(551, 225);
            this.gridMonth.TabIndex = 5;
            this.gridMonth.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMonth});
            // 
            // gridViewMonth
            // 
            this.gridViewMonth.GridControl = this.gridMonth;
            this.gridViewMonth.Name = "gridViewMonth";
            this.gridViewMonth.OptionsView.ShowFooter = true;
            this.gridViewMonth.OptionsView.ShowGroupPanel = false;
            // 
            // gridEntrance
            // 
            this.gridEntrance.Location = new System.Drawing.Point(86, 12);
            this.gridEntrance.MainView = this.gridViewEntrance;
            this.gridEntrance.Name = "gridEntrance";
            this.gridEntrance.Size = new System.Drawing.Size(551, 195);
            this.gridEntrance.TabIndex = 4;
            this.gridEntrance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEntrance});
            // 
            // gridViewEntrance
            // 
            this.gridViewEntrance.GridControl = this.gridEntrance;
            this.gridViewEntrance.Name = "gridViewEntrance";
            this.gridViewEntrance.OptionsView.ShowFooter = true;
            this.gridViewEntrance.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(649, 448);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridEntrance;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(629, 199);
            this.layoutControlItem1.Text = "Giriş Aidatları";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridMonth;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 199);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(629, 229);
            this.layoutControlItem2.Text = "Aylık Ödemeler";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(71, 13);
            // 
            // FeeStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 448);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FeeStatusForm";
            this.Text = "Aidat Son Durum";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridMonth;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMonth;
        private DevExpress.XtraGrid.GridControl gridEntrance;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEntrance;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}