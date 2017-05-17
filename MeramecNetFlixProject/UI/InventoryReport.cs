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
    public partial class InventoryReport : Form
    {
        public InventoryReport()
        {
            InitializeComponent();
        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamdDataSet1.MOVIE' table. You can move, or remove it, as needed.
            this.mOVIETableAdapter.Fill(this.teamdDataSet1.MOVIE);

            this.reportViewer1.RefreshReport();
        }
    }
}
