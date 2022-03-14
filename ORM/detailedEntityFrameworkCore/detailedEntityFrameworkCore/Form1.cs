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
        movieDbContext movieDbContext = new movieDbContext();
        private void Form1_Load(object sender, EventArgs e)
        {
          
            movieDbContext.Database.EnsureCreated();

            var allContext = movieDbContext.Films.Include(x => x.Director)
                                                 .Include(f => f.Players)
                                                 .ThenInclude(x=>x.Player);


            var data = allContext.Select(f => new
            {
                Id = f.Id,
                FilmAdi = f.Name,
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

        private void button3_Click(object sender, EventArgs e)
        {
            PlayerForm form = new PlayerForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieForm movieForm = new MovieForm();
            movieForm.Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            listBoxPlayers.Items.Clear();
            var id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var selectedFilm = movieDbContext.Films.Include(f => f.Players)
                                              .ThenInclude(p => p.Player)
                                              .FirstOrDefault(f => f.Id == id);


            foreach (var film in selectedFilm.Players)
            {
                listBoxPlayers.Items.Add(film.Player.Name + " " + film.Player.LastName);
            }




        }
    }
}
