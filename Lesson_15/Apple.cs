using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    public class Apple : abstFruit
    {
        public string Color { get; set; }
        public bool PinkLady { get; set; }

       
        public override bool IsThisMyFavorite()
        {
           return false;
        }
        public override string ToString()
        {
            return "Apple";
        }


    }
}
