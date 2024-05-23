using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Week4_Class1.Program;

namespace Demo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Book temp = new Book();
            //MessageBox.Show(txtTitle.Text);
            temp.Title = txtTitle.Text;
            //MessageBox.Show(temp.Title);
            //I run your programming function
            // temp.Title += "with Poopy";
            //MessageBox.Show(temp.Title);
            temp.AuthorFirst = txtAuthorFirst.Text;
            temp.AuthorLast = txtAuthorLast.Text;
            //Output or sore to DB
            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = temp.Title + "Written By " + temp.AuthorFirst +
                " " + temp.AuthorLast;
            }

            lblFeedback.Text = "Book Added: " + txtTitle.Text + "($ " + txtPrice.Text + ") - Published: " + dtpDatePublished.Value.ToString();
        }
    }
}
