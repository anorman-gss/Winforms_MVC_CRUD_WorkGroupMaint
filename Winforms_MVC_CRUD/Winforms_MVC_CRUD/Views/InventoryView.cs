using System;
using GSSEO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSSEO.DataAccess.Managers;
using Winforms_MVC_CRUD.Controllers;
using Winforms_MVC_CRUD.Services;


namespace Winforms_MVC_CRUD.Views
{
    public partial class InventoryView : Form
    {
        private InventoryRepository _controller;

        public InventoryView(InventoryRepository controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void GetAll_Click(object sender, EventArgs e)
        {
            Inventory.Parts parts = _controller.GetAll().Result;

            foreach (var part in parts)
            {
                listView1.Items.Add(part.PartNumber + " " + part.PartNumberRevision + " " + part.Description);
            }
        }

        private void GetRange_Click(object sender, EventArgs e)
        {
            Inventory.Parts parts = _controller.GetPartsFromPartNumberRange(txtBegin.Text, txtEnd.Text).Result;
            
            foreach (var part in parts)
            {
                listView1.Items.Add(part.PartNumber + " " + part.PartNumberRevision + " " + part.Description);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
