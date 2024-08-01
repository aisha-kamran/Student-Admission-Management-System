using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//FRont page Form//
namespace PROJECT_DBMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Properties.SignUpForm signUpForm = new Properties.SignUpForm();
            Properties.UserLogIn logIn=new Properties.UserLogIn();
            Properties.Adminlogin adminlogin=new Properties.Adminlogin();  
           Form1 main=new Form1();
          
               
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(70, Color.Purple);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            linkLabel3.BackColor = Color.Purple;
            Properties.Adminlogin adminlogin = new Properties.Adminlogin();
            adminlogin.ShowDialog();
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Properties.UserLogIn logIn = new Properties.UserLogIn();
            logIn.ShowDialog();
            

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Properties.SignUpForm signUpForm = new Properties.SignUpForm();
           signUpForm.ShowDialog();
         


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(70, Color.Purple);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
public class PlaceHolderTextBox : TextBox
{

    bool isPlaceHolder = true;
    string _placeHolderText;
    public string PlaceHolderText
    {
        get { return _placeHolderText; }
        set
        {
            _placeHolderText = value;
            setPlaceholder();
        }
    }

    public new string Text
    {
        get => isPlaceHolder ? string.Empty : base.Text;
        set => base.Text = value;
    }

    //when the control loses focus, the placeholder is shown
    private void setPlaceholder()
    {
        if (string.IsNullOrEmpty(base.Text))
        {
            base.Text = PlaceHolderText;
            this.ForeColor = Color.Gray;
            this.Font = new Font(this.Font, FontStyle.Italic);
            isPlaceHolder = true;
        }
    }

    //when the control is focused, the placeholder is removed
    private void removePlaceHolder()
    {

        if (isPlaceHolder)
        {
            base.Text = "";
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Font = new Font(this.Font, FontStyle.Regular);
            isPlaceHolder = false;
        }
    }
    public PlaceHolderTextBox()
    {
        GotFocus += removePlaceHolder;
        LostFocus += setPlaceholder;
    }

    private void setPlaceholder(object sender, EventArgs e)
    {
        setPlaceholder();
    }

    private void removePlaceHolder(object sender, EventArgs e)
    {
        removePlaceHolder();
    }
}