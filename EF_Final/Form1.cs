using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DbOgrenciSinavEntities db = new DbOgrenciSinavEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var values = db.tbl_students.OrderBy(x => x.City).GroupBy(y => y.City).Select(z => new
            {
                sehir = z.Key, count = z.Count()
            });
            dataGridView1.DataSource = values.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var values = db.tbl_students.OrderBy(x => x.City).GroupBy(y => y.City).Select(z => new
            {
                sehir = z.Key,
                count = z.Count()
            }).OrderByDescending(z => z.count);
            dataGridView1.DataSource = values.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = db.tbl_grades.Max(x => x.Average).ToString();
            label2.Text = db.tbl_grades.Min(x => x.Average).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var values = db.tbl_grades.Where(x => x.State == 0).OrderByDescending(x=>x.Average).Take(1);
            dataGridView1.DataSource = values.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = db.Products.Count().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = db.Products.Sum(x=>x.Stock).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            label3.Text = db.Products.Count(x => x.Name=="BUZDOLABI").ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Text = db.Products.Where(x => x.Name == "BUZDOLABI").Average(x=>x.Price).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Text = db.Products.Average(x => x.Price).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label3.Text = (from x in db.Products
                    orderby x.Stock descending
                         select x.Name).First();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label3.Text = (from x in db.Products
                orderby x.Stock ascending 
                select x.Name).First();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.clubs().ToList();
        }
    }
}
