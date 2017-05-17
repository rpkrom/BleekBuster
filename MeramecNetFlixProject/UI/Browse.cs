using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;

namespace MeramecNetFlixProject.UI
{
    public partial class Browse : Form
    {
        MOVIE objMovie = new MOVIE();
        public Browse()
        {
            InitializeComponent();
        }

        private void Browse_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MovieDB.GetMovieList();
        }

        private void rentbutton1_Click(object sender, EventArgs e)
        {
            objMovie.movie_title = textBox1.Text.Trim();
            MessageBox.Show("Thanks for choosing Bleekbuster, enjoy " + objMovie.movie_title + "!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
