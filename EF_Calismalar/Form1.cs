using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                            item.StudentId,
                            item.LessonId,
                            item.Exam1,
                            item.Exam2,
                            item.Exam3,
                            item.Average
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

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
            | x.Surname==TxtSOYAD.Text
            ).ToList();
        }

        private void TxtAD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}