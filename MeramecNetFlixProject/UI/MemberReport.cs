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
    public partial class MemberReport : Form
    {
        public MemberReport()
        {
            InitializeComponent();
        }

        private void MemberReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamdDataSet.MEMBER' table. You can move, or remove it, as needed.
            this.mEMBERTableAdapter.Fill(this.teamdDataSet.MEMBER);
            // TODO: This line of code loads data into the 'teamdDataSet.MEMBER' table. You can move, or remove it, as needed.
            this.mEMBERTableAdapter.Fill(this.teamdDataSet.MEMBER);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
