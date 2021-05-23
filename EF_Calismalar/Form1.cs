using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace EF_Calismalar
{
    public partial class Form1 : Form
    {
        internal DbOgrenciSinavEntities db = new DbOgrenciSinavEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDersListele_Click(object sender, EventArgs e)
        {
            //Eski yolla
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbOgrenciSinav;Integrated Security=True");
            SqlCommand command = new SqlCommand("Select * from tbl_lessons", con);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //dataGridView1.DataSource = dt;

            dataGridView1.DataSource = db.tbl_lessons.ToList();
        }

        private void BtnOgrenciListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_students.ToList();
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }
        private void BtnNotListele_Click(object sender, EventArgs e)
        {
            var query = from item in db.tbl_grades
                        select new
                        {
                            item.Id,
                            item.tbl_students.Name,
                            item.tbl_students.Surname,
                            item.tbl_lessons.LessonName,
                            item.Exam1,
                            item.Exam2,
                            item.Exam3,
                            item.Average
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            tbl_students t = new tbl_students();
            t.Name = TxtAD.Text;
            t.Surname = TxtSOYAD.Text;
            db.tbl_students.Add(t);
            db.SaveChanges();
        }

        private void BtnDersKaydet_Click(object sender, EventArgs e)
        {
            tbl_lessons t = new tbl_lessons();
            t.LessonName = TxtDersAdi.Text;
            db.tbl_lessons.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ogrenci sisteme kaydedildi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtOgrenciID.Text);
            var x = db.tbl_students.Find(id);
            db.tbl_students.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Ogrenci sistemden silindi");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(TxtOgrenciID.Text);
            var x = db.tbl_students.Find(id);
            x.Name = TxtAD.Text;
            x.Surname = TxtSOYAD.Text;
            x.Photo = TxtFOTO.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme başarılı");
        }

        private void BtnProcedure_Click(object sender, EventArgs e)
        {
            //proc calistirmak
            dataGridView1.DataSource = db.notlistesi();
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_students.Where(x => x.Name == TxtAD.Text
            | x.Surname == TxtSOYAD.Text
            ).ToList();
        }

        private void TxtAD_TextChanged(object sender, EventArgs e)
        {
            string aranan = TxtAD.Text;
            var values = from item in db.tbl_students where item.Name.Contains(aranan) select item;
            dataGridView1.DataSource = values.ToList();
        }

        private void TxtSOYAD_TextChanged(object sender, EventArgs e)
        {
            string aranan = TxtSOYAD.Text;
            var values = from item in db.tbl_students where item.Surname.Contains(aranan) select item;
            dataGridView1.DataSource = values.ToList();
        }

        private void LinqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dataGridView1.DataSource = db.tbl_students.OrderBy(p => p.Name).ToList();
            }
            if (radioButton2.Checked)
            {
                dataGridView1.DataSource = db.tbl_students.OrderByDescending(p => p.Name).ToList();
            }
            if (radioButton3.Checked)
            {
                dataGridView1.DataSource = db.tbl_students.OrderBy(p => p.Name).Take(3).ToList();
            }
            if (radioButton4.Checked)
            {
                int id = Convert.ToInt32(TxtOgrenciID.Text);
                dataGridView1.DataSource = db.tbl_students
                    .Where(p => p.Id == id).ToList();
            }
            if (radioButton5.Checked)
            {
                dataGridView1.DataSource = db.tbl_students
                    .Where(p => p.Name.StartsWith(TxtAD.Text)).ToList();
            }
            if (radioButton6.Checked)
            {
                dataGridView1.DataSource = db.tbl_students
                    .Where(p => p.Name.EndsWith(TxtAD.Text)).ToList();
            }
            if (radioButton7.Checked)
            {
                bool deger = db.tbl_students.Any();
                MessageBox.Show(deger.ToString());
            }
            if (radioButton8.Checked)
            {
                int count = db.tbl_students.Count();
                MessageBox.Show(count.ToString());
            }
            if (radioButton9.Checked)
            {
                var sum = db.tbl_grades.Sum(x => x.Exam1);
                MessageBox.Show(sum.ToString());
            }
            if (radioButton10.Checked)
            {
                var avg = db.tbl_grades.Average(x => x.Exam1);
                MessageBox.Show(avg.ToString());
            }
            if (radioButtonA.Checked)
            {
                var avg = Math.Round((double)db.tbl_grades.Average(x => x.Exam1));
                dataGridView1.DataSource = db.tbl_grades.Where(x => x.Exam1 >= avg).ToList();
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
                dataGridView1.Columns[dataGridView1.Columns.Count - 2].Visible = false;
                dataGridView1.Columns[dataGridView1.Columns.Count - 3].Visible = false;
                dataGridView1.Columns[dataGridView1.Columns.Count - 4].Visible = false;
            }
            if (radioButton11.Checked)
            {
                var max = db.tbl_grades.Max(x => x.Exam1);
                var maxStudent = db.tbl_grades.SingleOrDefault(x => x.Exam1 == max).StudentId;
                dataGridView1.DataSource = db.tbl_students.Where(x => x.Id == maxStudent).ToList();
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
                dataGridView1.Columns[dataGridView1.Columns.Count - 2].Visible = false;
                MessageBox.Show(max.ToString());
            }
            if (radioButton12.Checked)
            {
                var max = db.tbl_grades.Min(x => x.Exam1);
                MessageBox.Show(max.ToString());
            }
        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            var q = from d1 in db.tbl_grades
                    join d2 in db.tbl_students
                        on d1.StudentId equals d2.Id
                    join d3 in db.tbl_lessons
                        on d1.LessonId equals d3.Id
                    select new
                    {
                        Student = d2.Name + " " + d2.Surname,
                        LessonName=d3.LessonName,
                        Exam1 = d1.Exam1,
                        Exam2 = d1.Exam2,
                        Exam3 = d1.Exam3,
                        Avg=d1.Average
                    };
            dataGridView1.DataSource = q.ToList();
        }
    }
}