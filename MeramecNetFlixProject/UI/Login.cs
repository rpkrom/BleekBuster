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
    public delegate void ShowFrm();
    public partial class Login : Form
    {
        public event ShowFrm evtFrm;
        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.TopMost = true;
            //UNtextBox1.Text = "user1";
            //PWtextBox1.Text = "password";
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (true)
            {
                
            }
        }
        private void signinbutton1_Click(object sender, EventArgs e)
        {
            if (UNtextBox1.Text == "user1" && PWtextBox1.Text == "password")
            {
                evtFrm();
                this.Close();
            }
            if (UNtextBox1.Text == "user2" && PWtextBox1.Text == "password")
            {
                evtFrm();
                this.Close();
            }
            if (UNtextBox1.Text == "user3" && PWtextBox1.Text == "password")
            {
                evtFrm();
                this.Close();
            }
           
            //if (evtFrm != null)
            //{
            //    evtFrm();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ManageAccount().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
