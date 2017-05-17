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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.menuStrip1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.menuStrip1.Enabled = false;
        }

        private void loginbutton1_Click(object sender, EventArgs e)
        {
            //new Form2().Show();
            Login oFrm2 = new Login();
            oFrm2.evtFrm += new ShowFrm(oFrm2_evtFrm);
            oFrm2.Show();
        }
        void oFrm2_evtFrm()
        {
            menuStrip1.Enabled = true;
        }

        private void manageAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageAccount().Show();
        }

        private void genreFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GenreForm().Show();
        }

        private void vendorFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VendorForm().Show();
        }

        private void browseInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Browse().Show();
        }

        private void movieFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MovieForm().Show();
        }

        private void inventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InventoryReport().Show();
        }

        private void memberReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MemberReport().Show();
        }
    }
}
