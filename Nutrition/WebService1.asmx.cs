using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace Nutrition
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService1 : System.Web.Services.WebService
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
                string gender = (string)command.ExecuteScalar();
                con.Close();
                return gender;
            }
        }

        [WebMethod]
        public double CalculateIdealWeight(string gender, double height, int age)
        {
            if (gender.ToUpper() == "MALE")
            {
                return (height - 100 - ((height - 150) / 4)) + ((age - 20) / 4);
            }
            else if (gender.ToUpper() == "FEMALE")
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
    }
    }
