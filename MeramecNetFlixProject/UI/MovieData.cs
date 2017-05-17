using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeramecNetFlixProject.UI
{
    public partial class MovieData : Form
    {
        public MovieData()
        {
            InitializeComponent();
        }

        private void MovieData_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = MovieDB.GetMovieList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MOVIE objMovie = new MOVIE();
            objMovie.movie_number = textBox1.Text.Trim();
            objMovie.movie_title = textBox2.Text.Trim();
            objMovie.movie_year = textBox4.Text.Trim();
            objMovie.movie_rating = textBox6.Text.Trim();
            objMovie.genre_id = textBox3.Text.Trim();
            objMovie.Description = textBox5.Text;

            try
            {
                bool status = MovieDB.AddMovieList(objMovie);

                if (status)
                {
                    MessageBox.Show("Movie added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = MovieDB.GetMovieList();
                }
                else
                {
                    MessageBox.Show("Movie was not added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MOVIE objMovie = new MOVIE();
            objMovie.movie_number = textBox1.Text.Trim();
            objMovie.movie_title = textBox2.Text.Trim();
            objMovie.movie_year = textBox4.Text.Trim();
            objMovie.movie_rating = textBox6.Text.Trim();
            objMovie.genre_id = textBox3.Text.Trim();
            objMovie.Description = textBox5.Text;

            try
            {
                bool status = MovieDB.UpdateMovieList(objMovie);

                if (status)
                {
                    MessageBox.Show("Movie database updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = MovieDB.GetMovieList();
                }
                else
                {
                    MessageBox.Show("Movie data not updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MOVIE objMovie = new MOVIE();
            objMovie.movie_number = textBox1.Text.Trim();
            objMovie.movie_title = textBox2.Text.Trim();
            objMovie.movie_year = textBox4.Text.Trim();
            objMovie.movie_rating = textBox6.Text.Trim();
            objMovie.genre_id = textBox3.Text.Trim();
            objMovie.Description = textBox5.Text;

            try
            {
                bool status = MovieDB.DeleteMovieList(objMovie);

                if (status)
                {
                    MessageBox.Show("Movie deleted from database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = MovieDB.GetMovieList();
                }
                else
                {
                    MessageBox.Show("Movie was not deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
