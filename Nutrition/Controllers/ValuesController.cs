using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace Nutrition.Controllers
{
    public class ValuesController : ApiController
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NO0IUHH\SQLEXPRESS01;Initial Catalog=PlanuriAlimentareDB;Integrated Security=True;");

        // GET api/values
        public string Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Utilizatori", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return JsonConvert.SerializeObject(dt);
                }
                else
                {
                    return "No data found";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody] Utilizator utilizator)
        {
            try
            {
                if (string.IsNullOrEmpty(utilizator.Nume) || string.IsNullOrEmpty(utilizator.Email) || string.IsNullOrEmpty(utilizator.Gen) || string.IsNullOrEmpty(utilizator.Parola))
                {
                    return "Error: Incomplete user data!";
                }

                string hashedPassword = HashPassword(utilizator.Parola);

                SqlCommand cmd = new SqlCommand("INSERT INTO Utilizatori (Nume_Utilizator, Email_Utilizator, Gen_Utilizator, Parola_Hash) VALUES (@Nume, @Email, @Gen, @Parola)", con);
                cmd.Parameters.AddWithValue("@Nume", utilizator.Nume);
                cmd.Parameters.AddWithValue("@Email", utilizator.Email);
                cmd.Parameters.AddWithValue("@Gen", utilizator.Gen);
                cmd.Parameters.AddWithValue("@Parola", hashedPassword);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return "User added successfully!";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        // PUT api/values/5
        public string Put(int id, [FromBody] Utilizator utilizator)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Utilizatori SET Nume_Utilizator = @Nume, Email_Utilizator = @Email, Gen_Utilizator = @Gen, Parola_Hash = @Parola WHERE ID_Utilizator = @ID", con);
                cmd.Parameters.AddWithValue("@Nume", utilizator.Nume);
                cmd.Parameters.AddWithValue("@Email", utilizator.Email);
                cmd.Parameters.AddWithValue("@Gen", utilizator.Gen);
                cmd.Parameters.AddWithValue("@Parola", utilizator.Parola);
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return "User updated successfully!";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Utilizatori WHERE ID_Utilizator = @ID", con);
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return "User deleted successfully!";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        // POST api/values/login
        public string Login(string numeUtilizator, string parola)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Utilizatori WHERE Nume_Utilizator = @Nume AND Parola_Hash = @Parola", con);
                cmd.Parameters.AddWithValue("@Nume", numeUtilizator);
                cmd.Parameters.AddWithValue("@Parola", HashPassword(parola));

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    return "Login successful!";
                }
                else
                {
                    return "Invalid credentials!";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        // Metoda pentru generarea hash-ului parolei
        private string HashPassword(string password)
        {
            return Convert.ToBase64String(System.Security.Cryptography.SHA256.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)));
        }
    }

    public class Utilizator
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Email { get; set; }
        public string Gen { get; set; }
        public string Parola { get; set; }
    }

    public class UtilizatorLogin
    {
        public string Nume { get; set; }
        public string Parola { get; set; }
    }
}
