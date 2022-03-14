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
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }
        movieDbContext dbContext = new movieDbContext();
        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            List<int> selectedPlayers = new List<int>();
            foreach (dynamic item in listBoxPlayers.SelectedItems)
            {
                selectedPlayers.Add(item.Id);
            }

            Film film = new Film
            {
                DirectorId = (int)comboBoxDirector.SelectedValue,
                Duration = (int)numericUpDownDuration.Value,
                Name = textBoxName.Text,
                PublishDate = dateTimePublishDate.Value,
                Rating = (int)numericUpDownRating.Value
            };
            dbContext.Films.Add(film);

            dbContext.SaveChanges();

            selectedPlayers.ForEach(pl => film.Players.Add(new FilmsPlayer
            {
                FilmId = film.Id,
                PlayerId = pl
            }));

            dbContext.SaveChanges();


        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            getDirectors();
            getPlayers();
        }


        private void getPlayers()
        {
            var players = dbContext.Players.Select(p => new
            {
                Id = p.Id,
                FullName = p.Name + " " + p.LastName
            }).ToList();

            listBoxPlayers.DataSource = players;
            listBoxPlayers.DisplayMember = "FullName";
            listBoxPlayers.ValueMember = "Id";
        }

        private void getDirectors()
        {
            var directors = dbContext.Directors.Select(d => new
            {
                Id = d.Id,
                FullName = d.Name + " " + d.LastName
            });

            comboBoxDirector.DataSource = directors.ToList();
            comboBoxDirector.DisplayMember = "FullName";
            comboBoxDirector.ValueMember = "Id";


        }
    }
}
