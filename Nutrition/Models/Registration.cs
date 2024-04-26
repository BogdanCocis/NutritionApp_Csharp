using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nutrition.Models
{
    public class Registration
    {
        public int ID_Utilizator { get; set; }
        public string Nume_Utilizator { get; set; }
        public string Parola_Hash { get; set; }
        public string Email_Utilizator { get; set; }
        public string Gen_Utilizator { get; set; }

    }
}