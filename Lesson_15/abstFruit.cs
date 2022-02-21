using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    public abstract class abstFruit
    {
        public string Name { get; set; }
        public int Calories { get; set; }

        public abstract bool IsThisMyFavorite();
        
      

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
