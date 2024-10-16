using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchDinnerBookingEntry
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataColumn dc1 = new DataColumn("Student Id", typeof(int));
            DataColumn dc2 = new DataColumn("Student Name", typeof(string));
            DataColumn dc3 = new DataColumn("Course", typeof(string));
            DataColumn dc4 = new DataColumn("Course Code", typeof(int));
            DataColumn dc5 = new DataColumn("Grade", typeof(string));
            DataColumn dc6 = new DataColumn("status", typeof(string));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            dataGridView1.DataSource = dt;
        }
        public void createnewrow()
        {
            if (string.IsNullOrEmpty(txt_personalNo.Text) || string.IsNullOrEmpty(txt_name.Text) ||
                   string.IsNullOrEmpty(txt_date.Text) || string.IsNullOrEmpty(txt_quantity.Text) ||
                   cmb_type.SelectedItem == null|| cmb_type1.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields before adding the entry.");
                return;
            }
            // Add a new row to the existing DataTable
            dt.Rows.Add(Convert.ToInt32(txt_personalNo.Text), txt_name.Text, txt_date.Text,
                        Convert.ToInt32(txt_quantity.Text), cmb_type.SelectedItem.ToString(), 
                        cmb_type1.SelectedItem.ToString());
            // Refresh DataGridView to display the new data
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
               createnewrow();
        }
    }
}
