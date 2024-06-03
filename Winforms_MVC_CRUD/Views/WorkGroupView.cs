using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winforms_MVC_CRUD.Controllers;
using Winforms_MVC_CRUD.Models;
using Winforms_MVC_CRUD.Services;

namespace Winforms_MVC_CRUD.Views
{
    public partial class gvWorkGroup : Form
    {
        private WorkGroupRepository _controller;

        public gvWorkGroup(WorkGroupRepository controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void WorkGroupView_Load(object sender, EventArgs e)
        {
            List<WorkGroupModel> wrkgrplist = _controller.GetAll();
            gcWorkGroupMaintenance.DataSource = wrkgrplist;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Put Save Logic here");
        }

       
    }
}
