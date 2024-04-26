using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace Nutrition
{
    /// <summary>
    /// Summary description for NutritionService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NutritionService : System.Web.Services.WebService
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NO0IUHH\SQLEXPRESS01;Initial Catalog=PlanuriAlimentareDB;Integrated Security=True;");
       
        [WebMethod]
        public string Login(string email, string password)
        {
            string query = "SELECT COUNT(*) FROM Utilizatori WHERE Email_Utilizator = @Email AND Parola_Hash = @Password";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                con.Open();
                int count = (int)command.ExecuteScalar();
                con.Close();
                if (count > 0)
                {
                    return "Auhtentication successful!";
                }
                else
                {
                    return "Incorrect email or password!";
                }
            }
        }
       
        [WebMethod]
        public string GetGender(string email)
        {
            string query = "SELECT Gen_Utilizator FROM Utilizatori WHERE Email_Utilizator = @Email";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@Email", email);
                con.Open();
                object result = command.ExecuteScalar();
                con.Close();

                if (result != null && result != DBNull.Value)
                {
                    string gender = result.ToString().Trim().ToLower(); 
                    if (gender == "feminine" || gender == "female")
                    {
                        return "female"; 
                    }
                    else if (gender == "masculine" || gender == "male")
                    {
                        return "male"; 
                    }
                    else
                    {
                        throw new ArgumentException("Invalid gender detected.");
                    }
                }
                else
                {
                    throw new ArgumentException("Gender not found for the specified email address.");
                }
            }
        }


        [WebMethod]
        public double CalculateIdealWeight(string gender, double height, int age)
        {
            if (gender.ToLower() == "male")
            {
                return (height - 100 - ((height - 150) / 4)) + ((age - 20) / 4);
            }
            else if (gender.ToLower() == "female")
            {
                return (height - 100 - ((height - 150) / 2.5)) + ((age - 20) / 6);
            }
            else
            {
                throw new ArgumentException("The gender must be 'male' or 'female'.");
            }
        }


        [WebMethod]
        public double CalculateBMI(double weight, double heightInCm)
        {
            double heightInM = heightInCm / 100;

            return weight / (heightInM * heightInM);
        }


        public class Food
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Calories { get; set; }
            public string Macronutrients { get; set; }
        }


        [WebMethod]
        public string GetAllFoods()
        {
            List<Food> foods = new List<Food>(); 
            string query = "SELECT ID_Aliment, Nume_Aliment, Calorii, Macronutrienti FROM Alimente";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Food food = new Food
                    {
                        ID = Convert.ToInt32(reader["ID_Aliment"]),
                        Name = reader["Nume_Aliment"].ToString(),
                        Calories = Convert.ToInt32(reader["Calorii"]),
                        Macronutrients = reader["Macronutrienti"].ToString()
                    };
                    foods.Add(food); 
                }
                con.Close();
            }
            return JsonConvert.SerializeObject(foods);
        }


        [WebMethod]
        public string AddFood(string numeAliment, int calorii, string macronutrienti)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Alimente (Nume_Aliment, Calorii, Macronutrienti) VALUES (@Nume_Aliment, @Calorii, @Macronutrienti)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Nume_Aliment", numeAliment);
                command.Parameters.AddWithValue("@Calorii", calorii);
                command.Parameters.AddWithValue("@Macronutrienti", macronutrienti);
                int rowsAffected = command.ExecuteNonQuery();
                con.Close();
                if (rowsAffected > 0)
                {
                    return "The food has been successfully added to the database";
                }
                else
                {
                    return "The food could not be added to the database.";
                }
            }
            catch (Exception ex)
            {
                return "Error adding the food: " + ex.Message;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        [WebMethod]
        public string DeleteFood(string numeAliment)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Alimente WHERE Nume_Aliment = @Nume_Aliment";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Nume_Aliment", numeAliment);
                int rowsAffected = command.ExecuteNonQuery();
                con.Close();
                if (rowsAffected > 0)
                {
                    return "The food has been successfully deleted from the database.";
                }
                else
                {
                    return "The food could not be deleted from the database. Please check the food name.";
                }
            }
            catch (Exception ex)
            {
                return "Error deleting food: " + ex.Message;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        [WebMethod]
        public string GetFoodInfo(string foodName)
        {
            try
            {
                con.Open();
                string query = "SELECT Nume_Aliment, Calorii FROM Alimente WHERE Nume_Aliment = @Nume_Aliment";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Nume_Aliment", foodName);
                SqlDataReader reader = command.ExecuteReader();
                FoodInfo foodInfo = new FoodInfo();
                if (reader.Read())
                {
                    foodInfo.Name = reader["Nume_Aliment"].ToString();
                    foodInfo.Calories = Convert.ToInt32(reader["Calorii"]);
                }
                con.Close();
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                return serializer.Serialize(foodInfo);
            }
            catch (Exception ex)
            {
                return "Error retrieving food information: " + ex.Message;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public class FoodInfo
        {
            public string Name { get; set; }
            public int Calories { get; set; }
        }


        [WebMethod]
        public string GetAllMealPlans()
        {
            List<MealPlanInfo> mealPlans = new List<MealPlanInfo>();

            string query = "SELECT ID_Plan, Nume_Plan, Descriere_Plan FROM PlanuriAlimentare";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-NO0IUHH\SQLEXPRESS01;Initial Catalog=PlanuriAlimentareDB;Integrated Security=True;"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        MealPlanInfo mealPlan = new MealPlanInfo
                        {
                            ID = Convert.ToInt32(reader["ID_Plan"]),
                            Name = reader["Nume_Plan"].ToString(),
                            Description = reader["Descriere_Plan"].ToString()
                        };
                        mealPlans.Add(mealPlan);
                    }
                    connection.Close();
                }
            }

            return JsonConvert.SerializeObject(mealPlans);
        }

        public class MealPlanInfo
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

        [WebMethod]
        public string UpdateFood(int foodId, string foodName, int calories, string macronutrients)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-NO0IUHH\SQLEXPRESS01;Initial Catalog=PlanuriAlimentareDB;Integrated Security=True;"))
                {
                    string query = "UPDATE Alimente SET Nume_Aliment = @FoodName, Calorii = @Calories, Macronutrienti = @Macronutrients WHERE ID_Aliment = @FoodId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FoodId", foodId);
                        command.Parameters.AddWithValue("@FoodName", foodName);
                        command.Parameters.AddWithValue("@Calories", calories);
                        command.Parameters.AddWithValue("@Macronutrients", macronutrients);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            return "Food updated successfully!";
                        }
                        else
                        {
                            return "No food found with the specified ID.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }
    }
}
