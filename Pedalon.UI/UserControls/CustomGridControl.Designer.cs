namespace Pedalon.UI.UserControls
{
    partial class CustomGridControl<T>
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
            this.itemGrid = new DevExpress.XtraGrid.GridControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.items = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items)).BeginInit();
            this.SuspendLayout();
            // 
            // itemGrid
            // 
            this.itemGrid.DataSource = this.bindingSource;
            this.itemGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemGrid.Location = new System.Drawing.Point(0, 0);
            this.itemGrid.MainView = this.items;
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.Size = new System.Drawing.Size(671, 460);
            this.itemGrid.TabIndex = 1;
            this.itemGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.items});
            // 
            // items
            // 
            this.items.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.items.Appearance.SelectedRow.Options.UseBackColor = true;
            this.items.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.items.GridControl = this.itemGrid;
            this.items.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", null, "")});
            this.items.Name = "items";
            this.items.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.items.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.items.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.items.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.items.OptionsEditForm.EditFormColumnCount = 2;
            this.items.OptionsFind.AlwaysVisible = true;
            this.items.OptionsFind.FindDelay = 100;
            this.items.OptionsFind.SearchInPreview = true;
            this.items.OptionsSelection.InvertSelection = true;
            this.items.OptionsSelection.MultiSelect = true;
            this.items.OptionsView.AllowHtmlDrawHeaders = true;
            this.items.OptionsView.ColumnAutoWidth = false;
            this.items.OptionsView.EnableAppearanceEvenRow = true;
            this.items.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.items.OptionsView.ShowFooter = true;
            this.items.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.items_SelectionChanged);
            this.items.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.items_RowUpdated);
            // 
            // CustomGridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemGrid);
            this.Name = "CustomGridControl";
            this.Size = new System.Drawing.Size(671, 460);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.BindingSource bindingSource;
        public DevExpress.XtraGrid.GridControl itemGrid;
        public DevExpress.XtraGrid.Views.Grid.GridView items;
    }
}
