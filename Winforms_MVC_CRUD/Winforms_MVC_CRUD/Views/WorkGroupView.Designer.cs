
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
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.gcWorkGroupMaintenance = new DevExpress.XtraGrid.GridControl();
            this.gvWorkGroupMaintenance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciWorkGroupMaintenance = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkGroupMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkGroupMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWorkGroupMaintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.gcWorkGroupMaintenance);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(800, 450);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl2";
            // 
            // gcWorkGroupMaintenance
            // 
            this.gcWorkGroupMaintenance.Location = new System.Drawing.Point(12, 12);
            this.gcWorkGroupMaintenance.MainView = this.gvWorkGroupMaintenance;
            this.gcWorkGroupMaintenance.Name = "gcWorkGroupMaintenance";
            this.gcWorkGroupMaintenance.Size = new System.Drawing.Size(776, 426);
            this.gcWorkGroupMaintenance.TabIndex = 4;
            this.gcWorkGroupMaintenance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWorkGroupMaintenance});
            // 
            // gvWorkGroupMaintenance
            // 
            this.gvWorkGroupMaintenance.GridControl = this.gcWorkGroupMaintenance;
            this.gvWorkGroupMaintenance.Name = "gvWorkGroupMaintenance";
            // 
            // lcgMain
            // 
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciWorkGroupMaintenance});
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Size = new System.Drawing.Size(800, 450);
            this.lcgMain.TextVisible = false;
            // 
            // lciWorkGroupMaintenance
            // 
            this.lciWorkGroupMaintenance.Control = this.gcWorkGroupMaintenance;
            this.lciWorkGroupMaintenance.Location = new System.Drawing.Point(0, 0);
            this.lciWorkGroupMaintenance.Name = "lciWorkGroupMaintenance";
            this.lciWorkGroupMaintenance.Size = new System.Drawing.Size(780, 430);
            this.lciWorkGroupMaintenance.TextSize = new System.Drawing.Size(0, 0);
            this.lciWorkGroupMaintenance.TextVisible = false;
            // 
            // gvWorkGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lcMain);
            this.Name = "gvWorkGroup";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WorkGroupView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkGroupMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkGroupMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWorkGroupMaintenance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl gcWorkGroupMaintenance;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWorkGroupMaintenance;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciWorkGroupMaintenance;
    }
}