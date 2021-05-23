using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Calismalar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private DbOgrenciSinavEntities db = new DbOgrenciSinavEntities();
        private void LinqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var values = db.tbl_grades.Where(x => x.Exam1 < 50);
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton2.Checked)
            {
                var values = db.tbl_students.Where(x => x.Name == "ali");
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton3.Checked)
            {
                var values = db.tbl_students.Where(x => x.Name == textBox1.Text || x.Surname == textBox1.Text);
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton4.Checked)
            {
                var values = db.tbl_students.Select(x => new { surname = x.Surname });
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton5.Checked)
            {
                var values = db.tbl_students.Select(x => new
                {
                    name = x.Name.ToUpper(),
                    surlower = x.Surname.ToLower()
                });
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton6.Checked)
            {
                var values = db.tbl_students.Select(x => new
                {
                    nam = x.Name.ToUpper(),
                    surlower = x.Surname.ToLower()
                }).Where(x => x.nam != "ali");
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton7.Checked)
            {
                var values = db.tbl_grades.Select(x => new
                {
                    stdnam = x.tbl_students.Name,
                    stdavg = x.Average,
                    State = x.State == 1 ? "gecti" : "kaldi"
                });
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton8.Checked)
            {
                var values = db.tbl_grades.SelectMany(x => db.tbl_students.Where(y => y.Id == x.StudentId), (x, y) => new
                {
                    y.Name,
                    x.Average,

                    State = x.State == 1 ? "gecti" : "kaldi"
                });
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton9.Checked)
            {
                var values = db.tbl_students.OrderBy(x => x.Id).Take(3);
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton10.Checked)
            {
                var values = db.tbl_students.OrderByDescending(x => x.Id).Take(3);
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton11.Checked)
            {
                var values = db.tbl_students.OrderBy(x => x.Name);
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton12.Checked)
            {
                var values = db.tbl_students.OrderBy(x => x.Name).Skip(5);
                dataGridView1.DataSource = values.ToList();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
