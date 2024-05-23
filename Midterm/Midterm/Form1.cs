using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonClass person = new PersonClass();

            person.FirstName = txtFirst.Text;
            person.MiddleName = txtMid.Text;
            person.LastName = txtLast.Text;
            person.Street1 = txtAdd1.Text;
            person.Street2 = txtAdd2.Text;
            person.City = txtState.Text;
            person.State = txtCity.Text;
            person.Zip = txtZip.Text;
            person.Phone = txtPhone.Text;
            person.Email = txtEmail.Text;

            if (person.Feedback.Contains("ERROR:"))
            {
                lblFeed.Text = person.Feedback;
            }
            else
            {
                lblFeed.Text = ($" First: {person.FirstName} \n Middle: {person.MiddleName} \n Last: {person.LastName} \n Street 1:  {person.Street1} \n Street 2: {person.Street2} \n City: {person.City} \n State: {person.State} \n Zip: {person.Zip} \n Phone: {person.Phone} \n Email: {person.Email}");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
