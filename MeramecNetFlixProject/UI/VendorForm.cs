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
    public partial class VendorForm : Form
    {
        VENDOR objVendor = new VENDOR();
        public VendorForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)//delete
        {
            objVendor.id = textBox1.Text.Trim();
            objVendor.name = textBox2.Text.Trim();
            objVendor.title = textBox3.Text.Trim();
            objVendor.quantity = textBox4.Text.Trim();
            try
            {
                bool status = VendorDB.DeleteVendorList(objVendor);
                if (status) //You can use this syntax as well..if (status ==true)
                {
                    MessageBox.Show("Vendor deleted from database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = VendorDB.GetVendorList();
                }
                else
                {
                    MessageBox.Show("Vendor was not found in database to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void VendorForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = VendorDB.GetVendorList();
        }

        private void button1_Click(object sender, EventArgs e)//add
        {
            objVendor.id = textBox1.Text.Trim();
            objVendor.name = textBox2.Text.Trim();
            objVendor.title = textBox3.Text.Trim();
            objVendor.quantity = textBox4.Text.Trim();

            try
            {
                bool status = VendorDB.AddVendorList(objVendor);

                if (status)
                {
                    MessageBox.Show("Vendor added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = VendorDB.GetVendorList();
                }
                else
                {
                    MessageBox.Show("Vendor was not added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)//update
        {
            objVendor.id = textBox1.Text.Trim();
            objVendor.name = textBox2.Text.Trim();
            objVendor.title = textBox3.Text.Trim();
            objVendor.quantity = textBox4.Text.Trim();

            try
            {
                bool status = VendorDB.UpdateVendorList(objVendor);

                if (status)
                {
                    MessageBox.Show("Vendor added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = VendorDB.GetVendorList();
                }
                else
                {
                    MessageBox.Show("Vendor was not added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
