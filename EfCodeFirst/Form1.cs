using System;
using System.Windows.Forms;
using EfCodeFirst.Entity;

namespace EfCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Context c = new Context();
            c.Database.Create();
        }
    }
}
