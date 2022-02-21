using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    public class Peach : abstFruit

    {
        public override bool IsThisMyFavorite()
        {
            return true;
        }

        public override string ToString()
        {
            return "Peach";
        }
    }
}
