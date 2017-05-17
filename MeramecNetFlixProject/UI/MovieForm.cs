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
    public partial class MovieForm : Form
    {
        MOVIE objMovie = new MOVIE();
        public MovieForm()
        {
            InitializeComponent();
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MovieDB.GetMovieList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//find button
        {

        }

        private void button3_Click(object sender, EventArgs e)//update
        {
            objMovie.movie_number = movienumtextBox1.Text.Trim();
            objMovie.movie_title = titletextBox2.Text.Trim();
            objMovie.Description = desctextBox3.Text.Trim();
            objMovie.movie_year_made = yeartextBox4.Text.Trim();
            objMovie.movie_retail_cost = rentaltextBox9.Text.Trim();
            objMovie.image = imagetextBox6.Text.Trim();
            objMovie.genre_id = genrecomboBox1.Text.Trim();
            //objMovie. = rentaltextBox9.Text.Trim(); //rental does not exist
            objMovie.movie_rating = ratingcomboBox2.Text.Trim();
            //objMovie. = mediacomboBox3.Text.Trim(); //media type does not exist
            objMovie.trailer = trailertextBox7.Text.Trim();
            objMovie.copies_on_hand = quantitytextBox8.Text.Trim();

            try
            {
                bool status = MovieDB.UpdateMovieList(objMovie);
                if (status) 
                {
                    MessageBox.Show("Movie updated from database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = MovieDB.GetMovieList();
                }
                else
                {
                    MessageBox.Show("Movie was not found in database to update.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)//delete
        {
            objMovie.movie_number = movienumtextBox1.Text.Trim();
            objMovie.movie_title = titletextBox2.Text.Trim();
            objMovie.Description = desctextBox3.Text.Trim();
            objMovie.movie_year_made = yeartextBox4.Text.Trim();
            objMovie.movie_retail_cost = rentaltextBox9.Text.Trim();
            objMovie.image = imagetextBox6.Text.Trim();
            objMovie.genre_id = genrecomboBox1.Text.Trim();
            //objMovie. = rentaltextBox9.Text.Trim(); //rental does not exist
            objMovie.movie_rating = ratingcomboBox2.Text.Trim();
            //objMovie. = mediacomboBox3.Text.Trim(); //media type does not exist
            objMovie.trailer = trailertextBox7.Text.Trim();
            objMovie.copies_on_hand = quantitytextBox8.Text.Trim();

            try
            {
                bool status = MovieDB.DeleteMovieList(objMovie);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    MessageBox.Show("Movie deleted from database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = MovieDB.GetMovieList();
                }
                else
                {
                    MessageBox.Show("Movie was not found in database to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)//add
        {
            objMovie.movie_number = movienumtextBox1.Text.Trim();
            objMovie.movie_title = titletextBox2.Text.Trim();
            objMovie.Description = desctextBox3.Text.Trim();
            objMovie.movie_year_made = yeartextBox4.Text.Trim();
            objMovie.movie_retail_cost = rentaltextBox9.Text.Trim();
            objMovie.image = imagetextBox6.Text.Trim();
            objMovie.genre_id = genrecomboBox1.Text.Trim();
            //objMovie. = rentaltextBox9.Text.Trim(); //rental does not exist
            objMovie.movie_rating = ratingcomboBox2.Text.Trim();
            //objMovie. = mediacomboBox3.Text.Trim(); //media type does not exist
            objMovie.trailer = trailertextBox7.Text.Trim();
            objMovie.copies_on_hand = quantitytextBox8.Text.Trim();

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

        private void button5_Click(object sender, EventArgs e)//
        {
            movienumtextBox1.Clear();
            titletextBox2.Clear();
            desctextBox3.Clear();
            yeartextBox4.Clear();
            rentaltextBox9.Clear();
            imagetextBox6.Clear();
            genrecomboBox1.ResetText();
            rentaltextBox9.Clear(); //rental does not exist
            ratingcomboBox2.ResetText();
            mediacomboBox3.ResetText(); //media type does not exist
            trailertextBox7.Clear();
            quantitytextBox8.Clear();
        }
    }
}
