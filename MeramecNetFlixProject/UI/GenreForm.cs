using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;

namespace MeramecNetFlixProject.UI
{

    public partial class GenreForm : Form
    {
        GENRE objGenre = new GENRE();
        public GenreForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)//delete
        {
            //GENRE objGenre = new GENRE();
            objGenre.id = textBox1.Text.Trim();
            objGenre.name = textBox2.Text.Trim();
            try
            {
                bool status = GenreDB.DeleteGenreList(objGenre);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    MessageBox.Show("Genre deleted from database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = GenreDB.GetGenreList();
                }
                else
                {
                    MessageBox.Show("Genre was not found in database to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void GenreForm_Load(object sender, EventArgs e)//load data
        {
            dataGridView1.DataSource = GenreDB.GetGenreList();
        }

        private void button1_Click(object sender, EventArgs e)//add
        {
            objGenre.id = textBox1.Text.Trim();
            objGenre.name = textBox2.Text.Trim();

            try
            {
                bool status = GenreDB.AddGenreList(objGenre);
                
                if (status) 
                {
                    MessageBox.Show("Genre added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = GenreDB.GetGenreList();
                }
                else
                {
                    MessageBox.Show("Genre was not added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }             

    }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)//update, fix where statement in GenreDB.Update....
        {
            //GENRE objGenre = new GENRE();
            objGenre.id = textBox1.Text.Trim();
            objGenre.name = textBox2.Text.Trim();

            try
            {
                bool status = GenreDB.UpdateGenreList(objGenre);

                if (status)
                {
                    MessageBox.Show("Genre added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = GenreDB.GetGenreList();
                }
                else
                {
                    MessageBox.Show("Genre was not added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
