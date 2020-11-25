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
    public partial class Form2 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext("c:\\users\\lenovo\\documents\\visual studio 2010\\Projects\\bookdb\\bookdb\\book.mdf");
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = from h in db.titles
                    select h;
            titleDataGridView.DataSource = a;
        }

        private void titleBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            title w = new title();
          
            w.isbn = int.Parse(textBox1.Text);
            w.title1 = textBox2.Text;
            w.edition_num = int.Parse(textBox3.Text);
            w.copyright = int.Parse(textBox4.Text);
            db.titles.InsertOnSubmit(w);
            db.SubmitChanges();

        }
    }
}
