using detailedEntityFrameworkCore.Data;
using detailedEntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detailedEntityFrameworkCore
{
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
        }

        movieDbContext context = new movieDbContext();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Director director = new Director
            {
                Name = textBoxName.Text,
                LastName = textBoxLastName.Text,
                Info = textBoxInfo.Text
            };

            context.Directors.Add(director);
            int result = context.SaveChanges();
            string message = result > 0 ? "Başarılı" : "Başarısız";

            MessageBox.Show(message);
            getDirectors();
         
        }

        void getDirectors()
        {
            var directors = context.Directors.ToList();
            dataGridView1.DataSource = directors;
        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            getDirectors();
        }
    }
}
