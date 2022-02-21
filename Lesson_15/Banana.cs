using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    public class Banana : abstFruit
    {
        public bool HasBlackSpots { get; set; }
        public bool IsGreen { get; set; }
        public float Size { get; set; }


        public override bool IsThisMyFavorite()
        {
           return false;
        }

        public override string ToString()
        {
            return "Banana";
        }


    }
}
