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
    public partial class PlayerForm : Form
    {
        public PlayerForm()
        {
            InitializeComponent();
        }

        movieDbContext context = new movieDbContext ();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Player player = new Player
            {
                Name = textBoxName.Text,
                LastName = textBoxLastName.Text,
                Info = textBoxInfo.Text
            };

            context.Players.Add(player);
            context.SaveChanges();

            getPlayers();
        }

        void getPlayers()
        {
            var players = context.Players.ToList();
            dataGridView1.DataSource = players;
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            getPlayers();
        }
    }
}
