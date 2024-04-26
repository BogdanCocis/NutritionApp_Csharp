using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nutrition.Models
{
    namespace ClientNutrition.ServiceNutrition
    {
        public class Food
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Calories { get; set; }
            public string Macronutrients { get; set; }
        }
    }

}