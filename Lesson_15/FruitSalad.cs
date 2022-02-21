using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    public class FruitSalad
    {
        public abstFruit[] Fruits { get; set; } = new abstFruit[4];



        public int GetTotalCalories()
        {
            int calories = 0;
            foreach (abstFruit fruit in Fruits)
            {
                calories += fruit.Calories;
            }
            return calories;

        }

        public bool ContainsMyFavoriteFruit()
        {
            foreach (abstFruit fruit in Fruits)
            {
                if (fruit.IsThisMyFavorite())
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            string x = "";
            foreach (abstFruit fruit in this.Fruits)
            {
                
                x += fruit + "\n";
                              
            }
            return x;
            
        }
    }
}
