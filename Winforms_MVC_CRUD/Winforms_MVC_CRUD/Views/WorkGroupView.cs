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
            //foreach (var wkgrp in wrkgrplist)
            //{
            //    var myitem = listView1.Items.Add(wkgrp.WorkGroup.WorkgroupCode);
            //    foreach (var wkgrpline in wkgrp.WorkGroupLines)
            //    {
            //        myitem.SubItems.Add(wkgrpline.WorkcenterCode);
            //    };
                    
            //}
        }
    }
}
