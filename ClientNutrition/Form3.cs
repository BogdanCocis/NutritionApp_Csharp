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
using Newtonsoft.Json;
using static ClientNutrition.Food;




namespace ClientNutrition
{
    
    public partial class Form3 : Form
    {
        private ServiceNutrition.NutritionServiceSoapClient client = new ServiceNutrition.NutritionServiceSoapClient();
        private int totalCaloriesConsumed = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void listBoxViewAliment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void listBoxViewAddAliment_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void listBoxViewPlans_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxAddElement_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumberfOfCalorie_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddAliment_Click(object sender, EventArgs e)
        {
            string numeAliment = textBoxAddElement.Text;
            int calorii = Convert.ToInt32(textBoxNumberfOfCalorie.Text);
            string macronutrienti = textBoxMacronutrient.Text;
            string result = client.AddFood(numeAliment, calorii, macronutrienti);
            MessageBox.Show(result);
            RefreshFoodList();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxViewAliment.SelectedItem != null)
            {
                string foodName = ((Food)listBoxViewAliment.SelectedItem).Name;
                string result = client.DeleteFood(foodName);
                MessageBox.Show(result);
                RefreshFoodList();
            }
            else
            {
                MessageBox.Show("Select a food to delete.");
            }
        }


        private void RefreshFoodList()
        {
            var allFoodsJson = client.GetAllFoods();
            var foods = JsonConvert.DeserializeObject<List<Food>>(allFoodsJson);
            listBoxViewAliment.DataSource = foods;
            listBoxViewAliment.DisplayMember = "Name";
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxViewAliment.SelectedItem != null)
            {
                Food selectedFood = (Food)listBoxViewAliment.SelectedItem;
                string newFoodName = textBoxAddElement.Text;
                int newCalories = Convert.ToInt32(textBoxNumberfOfCalorie.Text);
                string newMacronutrients = textBoxMacronutrient.Text;
                string result = client.UpdateFood(selectedFood.ID, newFoodName, newCalories, newMacronutrients);
                MessageBox.Show(result);
                RefreshFoodList();
            }
            else
            {
                MessageBox.Show("Select a food to update.");
            }
        }

        

        private void buttonExit_Click(object sender, EventArgs e)
        {
            List<Food> selectedFoods = new List<Food>();
            foreach (Food selectedFood in listBoxViewAliment.SelectedItems)
            {
                selectedFoods.Add(selectedFood);
                totalCaloriesConsumed += selectedFood.Calories;
                listBoxViewAddAliment.Items.Add(selectedFood);
            }
            listBoxViewAddAliment.DisplayMember = "Name";
            textBoxCalorieConsumed.Text = totalCaloriesConsumed.ToString();
        }




        private void Form3_Load(object sender, EventArgs e)
        {
            var allFoodsJson = client.GetAllFoods();
            var foods = JsonConvert.DeserializeObject<List<Food>>(allFoodsJson);
            listBoxViewAliment.DataSource = foods;
            listBoxViewAliment.DisplayMember = "Name";
            var allMealPlansJson = client.GetAllMealPlans();
            var mealPlans = JsonConvert.DeserializeObject<List<MealPlanInfo>>(allMealPlansJson);
            listBoxViewPlans.DataSource = mealPlans;
            listBoxViewPlans.DisplayMember = "Description"; 
        }


        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpMessage = "This application allows you to manage nutrition information.\n";
            helpMessage += "To add a food, enter the name, number of calories, and macronutrients in the respective fields and click the 'Add Food' button.\n";
            helpMessage += "To delete a food, select it from the food list and click the 'Delete' button.\n";
            helpMessage += "To update a food, select it from the food list, enter the new information, and click the 'Update' button.\n";
            helpMessage += "To exit, select the foods you want to move, then click the 'Exit' button. The total calories of these foods will be displayed in the text box.\n";
            helpMessage += "To log out, use the logout button in the menu.";

            MessageBox.Show(helpMessage, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }


        private void textBoxCalorieConsumed_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxMacronutrient_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Food
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public string Macronutrients { get; set; }

        public class MealPlanInfo
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
    }
}