using detailedEntityFrameworkCore.Data;
using Microsoft.EntityFrameworkCore;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            movieDbContext movieDbContext = new movieDbContext();
            movieDbContext.Database.EnsureCreated();

            var allContext = movieDbContext.Films.Include(x => x.Director)
                                                 .Include(f => f.Players)
                                                 .ThenInclude(x=>x.Player);


            var data = allContext.Select(f => new
            {
                f.Name,
                Yonetmen = f.Director.Name + " " + f.Director.LastName,
                Oyuncu = f.Players.ToList()[0].Player.Name + " " + f.Players.ToList()[0].Player.LastName
            });

            var list = data.ToList();
            dataGridView1.DataSource = list;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectorForm directorForm = new DirectorForm();
            directorForm.Show();
        }
    }
}
