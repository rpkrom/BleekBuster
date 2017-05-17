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
    public partial class ManageAccount : Form
    {
        MEMBER objMember = new MEMBER();
        public ManageAccount()
        {
            InitializeComponent();
        }

        private void ManageAccount_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MemberDB.GetMemberList();
        }

        private void button1_Click(object sender, EventArgs e)//add
        {
            int stat, contact;
            objMember.number = textBox1.Text.Trim();
            objMember.joindate = textBox2.Text.Trim();
            objMember.firstname = textBox3.Text.Trim();
            objMember.lastname = textBox4.Text.Trim();
            objMember.address = textBox5.Text.Trim();
            objMember.city = textBox6.Text.Trim();
            objMember.state = textBox7.Text.Trim();
            objMember.zipcode = textBox8.Text.Trim();
            objMember.phone = textBox9.Text.Trim();
            objMember.email = textBox10.Text.ToString().Trim();
            objMember.login_name = textBox11.Text.Trim();
            objMember.password = textBox12.Text.Trim();
            objMember.subscription_id = textBox13.Text.Trim();
            objMember.photo = pictureBox1.Image.ToString();

            if (radioButton1.Checked)
            {
                stat = 1;
                objMember.member_status = stat.ToString();
            }
            if (radioButton2.Checked)
            {
                stat = 2;
                objMember.member_status = stat.ToString(); ;
            }
            if (radioButton3.Checked)
            {
                contact = 1;
                objMember.contact_method = contact.ToString();
            }
            if (radioButton4.Checked)
            {
                contact = 2;
                objMember.contact_method = contact.ToString();
            }
            if (radioButton5.Checked)
            {
                contact = 3;
                objMember.contact_method = contact.ToString();
            }
            if (radioButton6.Checked)
            {
                contact = 4;
                objMember.contact_method = contact.ToString();
            }

            try
            {
                bool status = MemberDB.AddMemberList(objMember);

                if (status)
                {
                    MessageBox.Show("Member added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = MemberDB.GetMemberList();
                }
                else
                {
                    MessageBox.Show("Member was not added to database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MemberDB.GetMemberList();
        }

        private void button3_Click(object sender, EventArgs e)//update
        {
            objMember.number = textBox1.Text.Trim();
            objMember.joindate = textBox2.Text.Trim();
            objMember.firstname = textBox3.Text.Trim();
            objMember.lastname = textBox4.Text.Trim();
            objMember.address = textBox5.Text.Trim();
            objMember.city = textBox6.Text.Trim();
            objMember.state = textBox7.Text.Trim();
            objMember.zipcode = textBox8.Text.Trim();
            objMember.phone = textBox9.Text.Trim();
            objMember.email = textBox10.Text.Trim();
            objMember.login_name = textBox11.Text.Trim();
            objMember.password = textBox12.Text.Trim();
            objMember.subscription_id = textBox13.Text.Trim();
            objMember.photo = pictureBox1.Image.ToString();


            if (radioButton1.Checked)
            {
                objMember.member_status = radioButton1.Text.ToString().Trim();
            }
            if (radioButton2.Checked)
            {
                objMember.member_status = radioButton2.Text.ToString().Trim();
            }
            if (radioButton3.Checked)
            {
                objMember.contact_method = radioButton3.Text.ToString().Trim();
            }
            if (radioButton4.Checked)
            {
                objMember.contact_method = radioButton4.Text.ToString().Trim();
            }
            if (radioButton5.Checked)
            {
                objMember.contact_method = radioButton5.Text.ToString().Trim();
            }
            if (radioButton6.Checked)
            {
                objMember.contact_method = radioButton6.Text.ToString().Trim();
            }

            try
            {
                bool status = MemberDB.UpdateMemberList(objMember);

                if (status)
                {
                    MessageBox.Show("Member information updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = MemberDB.GetMemberList();
                }
                else
                {
                    MessageBox.Show("Member information was not updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)//delete
        {
            objMember.number = textBox1.Text.Trim();
            objMember.joindate = textBox2.Text.Trim();
            objMember.firstname = textBox3.Text.Trim();
            objMember.lastname = textBox4.Text.Trim();
            objMember.address = textBox5.Text.Trim();
            objMember.city = textBox6.Text.Trim();
            objMember.state = textBox7.Text.Trim();
            objMember.zipcode = textBox8.Text.Trim();
            objMember.phone = textBox9.Text.Trim();
            objMember.email = textBox10.Text.Trim();
            objMember.login_name = textBox11.Text.Trim();
            objMember.password = textBox12.Text.Trim();
            objMember.subscription_id = textBox13.Text.Trim();
            objMember.photo = pictureBox1.Image.ToString();


            if (radioButton1.Checked)
            {
                objMember.member_status = radioButton1.Text.ToString().Trim();
            }
            if (radioButton2.Checked)
            {
                objMember.member_status = radioButton2.Text.ToString().Trim();
            }
            if (radioButton3.Checked)
            {
                objMember.contact_method = radioButton3.Text.ToString().Trim();
            }
            if (radioButton4.Checked)
            {
                objMember.contact_method = radioButton4.Text.ToString().Trim();
            }
            if (radioButton5.Checked)
            {
                objMember.contact_method = radioButton5.Text.ToString().Trim();
            }
            if (radioButton6.Checked)
            {
                objMember.contact_method = radioButton6.Text.ToString().Trim();
            }

            try
            {
                bool status = MemberDB.DeleteMemberList(objMember);

                if (status)
                {
                    MessageBox.Show("Member deleated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = MemberDB.GetMemberList();
                }
                else
                {
                    MessageBox.Show("Member not deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;

            pictureBox1.Image.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void ManageAccount_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MemberDB.GetMemberList();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[5].Value.ToString();
                textBox6.Text = row.Cells[6].Value.ToString();
                textBox7.Text = row.Cells[7].Value.ToString();
                textBox8.Text = row.Cells[8].Value.ToString();
                textBox9.Text = row.Cells[9].Value.ToString();
                textBox10.Text = row.Cells[10].Value.ToString();
                textBox11.Text = row.Cells[11].Value.ToString();
                textBox12.Text = row.Cells[12].Value.ToString();
                textBox13.Text = row.Cells[13].Value.ToString();
            }
        }
    }
}
