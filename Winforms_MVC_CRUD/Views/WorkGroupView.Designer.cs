namespace Winforms_MVC_CRUD.Views
{
    partial class gvWorkGroup
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gvWorkGroupMaintLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridWorkcenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPriorityCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcWorkGroupMaintenance = new DevExpress.XtraGrid.GridControl();
            this.gvWorkGroupMaintenance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnWorkGroupCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPrototypeWC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHasNestingInterface = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciWorkGroupMaintenance = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkGroupMaintLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkGroupMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkGroupMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWorkGroupMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvWorkGroupMaintLines
            // 
            this.gvWorkGroupMaintLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridWorkcenter,
            this.gridPriorityCode});
            this.gvWorkGroupMaintLines.GridControl = this.gcWorkGroupMaintenance;
            this.gvWorkGroupMaintLines.Name = "gvWorkGroupMaintLines";
            this.gvWorkGroupMaintLines.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvWorkGroupMaintLines.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvWorkGroupMaintLines.OptionsDetail.AllowZoomDetail = false;
            this.gvWorkGroupMaintLines.OptionsDetail.EnableMasterViewMode = false;
            this.gvWorkGroupMaintLines.OptionsDetail.ShowDetailTabs = false;
            this.gvWorkGroupMaintLines.OptionsSelection.MultiSelect = true;
            this.gvWorkGroupMaintLines.OptionsView.ShowGroupPanel = false;
            this.gvWorkGroupMaintLines.OptionsView.ShowIndicator = false;
            // 
            // gridWorkcenter
            // 
            this.gridWorkcenter.Caption = "Workcenter Code";
            this.gridWorkcenter.FieldName = "WorkcenterCode";
            this.gridWorkcenter.Name = "gridWorkcenter";
            this.gridWorkcenter.Visible = true;
            this.gridWorkcenter.VisibleIndex = 0;
            // 
            // gridPriorityCode
            // 
            this.gridPriorityCode.Caption = "Priority Code";
            this.gridPriorityCode.FieldName = "Information.PriorityCode";
            this.gridPriorityCode.Name = "gridPriorityCode";
            this.gridPriorityCode.Visible = true;
            this.gridPriorityCode.VisibleIndex = 1;

            //
            DevExpress.XtraGrid.Columns.GridColumn unboundColumn = this.gvWorkGroupMaintLines.Columns.AddField("Description");
            unboundColumn.VisibleIndex = this.gvWorkGroupMaintLines.Columns.Count;
            unboundColumn.UnboundDataType = typeof(string);
            gvWorkGroupMaintLines.CustomUnboundColumnData += (sender, e) =>
            {
                if (e.Column.FieldName == "Description")
                {
                    // Populates columns.
                    if (e.IsGetData)
                    {
                        DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                        e.Value = _controller.GetWorkCenterDescription((string)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "WorkcenterCode"));
                     }
                }
            };
            // Specify format settings.
            //unboundColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.None;
            // gcWorkGroupMaintenance
            // 
            gridLevelNode1.LevelTemplate = this.gvWorkGroupMaintLines;
            gridLevelNode1.RelationName = "WorkGroupLines";
            this.gcWorkGroupMaintenance.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcWorkGroupMaintenance.Location = new System.Drawing.Point(12, 12);
            this.gcWorkGroupMaintenance.MainView = this.gvWorkGroupMaintenance;
            this.gcWorkGroupMaintenance.Name = "gcWorkGroupMaintenance";
            this.gcWorkGroupMaintenance.Size = new System.Drawing.Size(776, 406);
            this.gcWorkGroupMaintenance.TabIndex = 4;
            this.gcWorkGroupMaintenance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWorkGroupMaintenance,
            this.gvWorkGroupMaintLines});
            // 
            // gvWorkGroupMaintenance
            // 
            this.gvWorkGroupMaintenance.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnWorkGroupCode,
            this.gridDescription,
            this.gridPrototypeWC,
            this.gridType,
            this.gridHasNestingInterface});
            this.gvWorkGroupMaintenance.GridControl = this.gcWorkGroupMaintenance;
            this.gvWorkGroupMaintenance.Name = "gvWorkGroupMaintenance";
            this.gvWorkGroupMaintenance.OptionsDetail.ShowDetailTabs = false;
            this.gvWorkGroupMaintenance.OptionsSelection.MultiSelect = true;
            this.gvWorkGroupMaintenance.OptionsView.ShowGroupPanel = false;
            this.gvWorkGroupMaintenance.OptionsView.ShowIndicator = false;
            // 
            // gridColumnWorkGroupCode
            // 
            this.gridColumnWorkGroupCode.Caption = "Workgroup Code";
            this.gridColumnWorkGroupCode.FieldName = "WorkGroup.WorkgroupCode";
            this.gridColumnWorkGroupCode.Name = "gridColumnWorkGroupCode";
            this.gridColumnWorkGroupCode.OptionsColumn.ReadOnly = true;
            this.gridColumnWorkGroupCode.Visible = true;
            this.gridColumnWorkGroupCode.VisibleIndex = 0;
            // 
            // gridDescription
            // 
            this.gridDescription.Caption = "Description";
            this.gridDescription.FieldName = "WorkGroup.Information.Description";
            this.gridDescription.Name = "gridDescription";
            this.gridDescription.Visible = true;
            this.gridDescription.VisibleIndex = 1;
            // 
            // gridPrototypeWC
            // 
            this.gridPrototypeWC.Caption = "Protype Workcenter";
            this.gridPrototypeWC.FieldName = "WorkGroup.Prototype.Workcenter.WorkcenterCode";
            this.gridPrototypeWC.Name = "gridPrototypeWC";
            this.gridPrototypeWC.Visible = true;
            this.gridPrototypeWC.VisibleIndex = 4;
            // 
            // gridType
            // 
            this.gridType.Caption = "Type";
            this.gridType.FieldName = "WorkGroup.Information.Type";
            this.gridType.Name = "gridType";
            this.gridType.Visible = true;
            this.gridType.VisibleIndex = 2;
            // 
            // gridHasNestingInterface
            // 
            this.gridHasNestingInterface.Caption = "Has Nesting Interface?";
            this.gridHasNestingInterface.FieldName = "WorkGroup.Information.HasNestingInterface";
            this.gridHasNestingInterface.Name = "gridHasNestingInterface";
            this.gridHasNestingInterface.Visible = true;
            this.gridHasNestingInterface.VisibleIndex = 3;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.gcWorkGroupMaintenance);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 20);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(800, 430);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl2";
            // 
            // lcgMain
            // 
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciWorkGroupMaintenance});
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Size = new System.Drawing.Size(800, 430);
            this.lcgMain.TextVisible = false;
            // 
            // lciWorkGroupMaintenance
            // 
            this.lciWorkGroupMaintenance.Control = this.gcWorkGroupMaintenance;
            this.lciWorkGroupMaintenance.Location = new System.Drawing.Point(0, 0);
            this.lciWorkGroupMaintenance.Name = "lciWorkGroupMaintenance";
            this.lciWorkGroupMaintenance.Size = new System.Drawing.Size(780, 410);
            this.lciWorkGroupMaintenance.TextSize = new System.Drawing.Size(0, 0);
            this.lciWorkGroupMaintenance.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSave});
            this.barManager1.MaxItemId = 1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave)});
            this.bar1.Text = "Tools";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 0;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 430);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 430);
            // 
            // gvWorkGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "gvWorkGroup";
            this.Text = "Workgroup Maintenance";
            this.Load += new System.EventHandler(this.WorkGroupView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkGroupMaintLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkGroupMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkGroupMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWorkGroupMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl gcWorkGroupMaintenance;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWorkGroupMaintenance;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciWorkGroupMaintenance;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnWorkGroupCode;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn gridDescription;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWorkGroupMaintLines;
        private DevExpress.XtraGrid.Columns.GridColumn gridWorkcenter;
        private DevExpress.XtraGrid.Columns.GridColumn gridType;
        private DevExpress.XtraGrid.Columns.GridColumn gridHasNestingInterface;
        private DevExpress.XtraGrid.Columns.GridColumn gridPrototypeWC;
        private DevExpress.XtraGrid.Columns.GridColumn gridPriorityCode;
    }
}