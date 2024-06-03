using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Winforms_MVC_CRUD.Controllers;
using Winforms_MVC_CRUD.Models;

namespace Winforms_MVC_CRUD.Views
{
    internal partial class PersonView : Form
    {
        private PersonController _controller;

        public PersonView(PersonController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void Update_Click(object sender, System.EventArgs e)
        {
               // Create a new student from the input fields
               Person updatedPerson = new Person()
               {
                   Id = Convert.ToInt32(txtid.Text),
                   Name = txtName.Text,
                   Age = Convert.ToInt32(txtAge.Text)
               };
            
               // Update the existing student
               _controller.UpdatePerson(updatedPerson);
            
               // Update the DataGridView
               txtid.Clear();
               txtName.Clear();
               txtAge.Clear();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Person AddPerson = new Person()
            {
                Id = Convert.ToInt32(txtid.Text),
                Name = txtName.Text,
                Age = Convert.ToInt32(txtAge.Text)
            };

            // add the existing student
            _controller.AddPerson(AddPerson);

            // Update the DataGridView
            txtid.Clear();
            txtName.Clear();
            txtAge.Clear();
        }

        private void GetById_Click(object sender, EventArgs e)
        {
            //Person GetPerson = new Person();
            int Id = Convert.ToInt32(txtid.Text);
            // add the existing student
            Person GetPerson = _controller.GetPersonById(Id);

            // Update the DataGridView
            txtid.Text = Convert.ToString(GetPerson.Id);
            txtName.Text = Convert.ToString(GetPerson.Name);
            txtAge.Text = Convert.ToString(GetPerson.Age);
        }

        private void GetAll_Click(object sender, EventArgs e)
        {
            List<Person> PeepsList = _controller.GetAllPersons();
            foreach (Person p in PeepsList) 
            {
                lstBox.Items.Add(p.Name);
            }
            
        }



        //Example button click event
        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    // Create a new student from the input fields
        //    Person updatedPerson = new Person()
        //    {
        //        Id = Convert.ToInt32(txtId.Text),
        //        Name = txtName.Text,
        //        Age = Convert.ToInt32(txtAge.Text)
        //    };

        //    // Update the existing student
        //    _controller.UpdatePerson(updatedPerson);

        //    // Update the DataGridView
        //    txtId.Clear();
        //    txtName.Clear();
        //    txtAge.Clear();
        //}
    }
}
