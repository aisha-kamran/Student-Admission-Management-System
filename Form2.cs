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
//Student detail Form
namespace PROJECT_DBMS
{
    public partial class Form2 : Form
    {
       
        string address = @"Data Source=DESKTOP-GMDPHBB;Initial Catalog=dbms project;Integrated Security=True";
        //Data Source = DESKTOP - GMDPHBB; Initial Catalog = lab; Integrated Security = True
        SqlConnection connection;
        SqlCommand command;
        private static string uname = "";

        

        public Form2()
        {
            InitializeComponent();
            connection = new SqlConnection(address);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Computer Science");
            comboBox1.Items.Add("Arts and commerce");
            comboBox1.Items.Add("Medical and science");
            comboBox1.Items.Add("Enginner and science");
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string gender = string.Empty;
            try
            {

                if (placeHolderTextBox1.Text == "" || placeHolderTextBox2.Text == "" || placeHolderTextBox3.Text == "" || placeHolderTextBox5.Text == "" || placeHolderTextBox6.Text == "" || placeHolderTextBox7.Text == "" || placeHolderTextBox8.Text == "" || placeHolderTextBox9.Text == "")
                {
                    MessageBox.Show("Fill all the fields");
                }
          
                else
                {
                    
                    if (radioButton1.Checked)
                    {
                        gender = "M";
                    }
                    else if (radioButton2.Checked)
                    {
                        gender = "F";
                    }
                    connection.Open();
                    command = new SqlCommand("insert into StudentRecord(sr_name,sr_guardian_name,sr_dateBirthAge,sr_Address,sr_gender,sr_cnic,sr_guardian_cnic,sr_marital_status,sr_contactno,sr_Facultytype) values ('" + placeHolderTextBox1.Text + "','" + placeHolderTextBox2.Text + "','" + placeHolderTextBox3.Text + "','" + placeHolderTextBox5.Text + "','" + @gender + "','" + int.Parse(placeHolderTextBox6.Text) + "','" + int.Parse(placeHolderTextBox7.Text) + "','" + placeHolderTextBox8.Text + "','" + int.Parse(placeHolderTextBox9.Text) + "','" + comboBox1.Text + "')", connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Record Inserted Sucessfully .... !!!!!");
                    this.Hide();
                    connection.Close();
                    Form1 mainpage = new Form1();
                    mainpage.ShowDialog();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
       
       
        
        private void placeHolderTextBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
    
