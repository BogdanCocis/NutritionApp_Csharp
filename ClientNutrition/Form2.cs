using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientNutrition.ServiceNutrition;


namespace ClientNutrition
{
    public partial class Form2 : Form
    {
        private ServiceNutrition.NutritionServiceSoapClient client = new ServiceNutrition.NutritionServiceSoapClient();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        
        private void buttonNewMenu_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
        

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double height, weight;
                int age;

                if (!double.TryParse(textBoxHeight.Text, out height) ||
                    !double.TryParse(textBoxWeight.Text, out weight) ||
                    !int.TryParse(textBoxAge.Text, out age))
                {
                    MessageBox.Show("Please enter valid numeric values for height, weight, and age.");
                    return;
                }
                string email = ((Form1)Application.OpenForms["Form1"]).UserEmail;
                string gender = client.GetGender(email);
                if (string.IsNullOrEmpty(gender))
                {
                    MessageBox.Show("Gender not found for the specified email address.");
                    return;
                }
                MessageBox.Show($"Gender returned by GetGender method: {gender}");
                double idealWeight;
                if (gender.ToLower() == "male" || gender.ToLower() == "female" || gender.ToLower() == "feminine")
                {
                    idealWeight = client.CalculateIdealWeight(gender.ToLower(), height, age);
                }
                else
                {
                    MessageBox.Show("Invalid gender detected.");
                    return;
                }
                double bmi = client.CalculateBMI(weight, height);
                textBoxIdealWeight.Text = idealWeight.ToString("F2");
                textBoxBMI.Text = bmi.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxIdealWeight_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxBMI_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonDietPlan_CheckedChanged(object sender, EventArgs e)
        {
            buttonNewMenu.Tag = "DietPlan";
        }

        private void radioButtonMuscleGain_CheckedChanged(object sender, EventArgs e)
        {
            buttonNewMenu.Tag = "MuscleGain";
        }

        private void radioButtonImpruveDigestion_CheckedChanged(object sender, EventArgs e)
        {
            buttonNewMenu.Tag = "ImproveDigestion";
        }

        private void radioButtonMaintance_CheckedChanged(object sender, EventArgs e)
        {
            buttonNewMenu.Tag = "Maintenance";
        }
    }
}
