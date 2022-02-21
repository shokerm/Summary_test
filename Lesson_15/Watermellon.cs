using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    public class Watermellon : abstFruit
    {
        public override bool IsThisMyFavorite()
        {
            return false;
        }

        public override string ToString()
        {
            return "Watermellon";
        }
    }
}
