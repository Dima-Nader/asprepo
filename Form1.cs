using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bookdb
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext("c:\\users\\lenovo\\documents\\visual studio 2010\\Projects\\bookdb\\bookdb\\book.mdf");


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            db.SubmitChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var z = from d in db.authors
                    select d;
            authorDataGridView.DataSource = z;
        }

        private void authorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var s = from y in db.authors
                    where y.fname.Contains(textBox1.Text)
                    select y;
            authorDataGridView.DataSource = s;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 b = new Form2();
            b.Show();
        }
    }
}
