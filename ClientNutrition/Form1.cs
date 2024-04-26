using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientNutrition.ServiceReference3;

namespace ClientNutrition
{
    public partial class Form1 : Form
    {
        private ServiceNutrition.NutritionServiceSoapClient client = new ServiceNutrition.NutritionServiceSoapClient();
        public string UserEmail { get; private set; }

        public Form1()
        {
            InitializeComponent();   
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (AuthenticateUser(textBoxUsername.Text, textBoxPassword.Text))
            {
                UserEmail = textBoxUsername.Text; 
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Authentication failed! Please check your email address and password.", "Authentication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool AuthenticateUser(string email, string password)
        {
            ServiceReference3.NutritionServiceSoapClient serviceClient = new ServiceReference3.NutritionServiceSoapClient();
            string authenticationResult = serviceClient.Login(email, password);
            if (authenticationResult == "Auhtentication successful!")
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }
    }
}
