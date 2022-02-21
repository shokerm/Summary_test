using System;

namespace Lesson_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            abstFruit a1 = new Apple()
            {
                Calories = 150,
                Color = "Red",
            };
            abstFruit b1 = new Banana()
            {
                Calories = 220,
                IsGreen = false,
                Size = 10
            };

            abstFruit p1 = new Peach()
            {
                Calories = 75
            };
            abstFruit w1 = new Watermellon()
            {
                Calories = 375
            };


            FruitSalad f1 = new FruitSalad();
            f1.Fruits[0] = a1;
            f1.Fruits[1] = b1;
            f1.Fruits[2] = p1;
            f1.Fruits[3] = w1;

            Console.WriteLine(f1.GetTotalCalories());
            Console.WriteLine(f1.ContainsMyFavoriteFruit());

            try
            {
                PrintAppleColor(b1);
            }
            catch (FruitException ex)
            {

                Console.WriteLine(ex.Message);
            }

            try
            {
                PrintBannaSize(b1);
            }
            catch (FruitException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            GetFruitSaladAndPrintItsTotalCalories(f1);
            GetFruitSaladAndPringIfMyFavoriteFruitIsIn(f1);
            abstFruit[] af = new abstFruit[] { p1, a1, w1 };
            FruitSalad x = GetFruitsArrayAndMakeFruitSalad(af);
            Console.WriteLine(x);
            
           
            

        }

        public static void PrintAppleColor(abstFruit a)
        {
            if ((a is Apple))
            {
                Console.WriteLine((a as Apple).Color);

            }
            else
            {
                throw new FruitException("Not an apple...");
            }
           
          
                
           
        }

        public static void PrintBannaSize(abstFruit b)
        {
            if ((b is Banana))
            {
                Console.WriteLine((b as Banana).Size);

            }
            else
            {
                throw new FruitException("Not a banana...");
            }




        }

        public static void GetFruitSaladAndPrintItsTotalCalories(FruitSalad f)
        {
           
                Console.WriteLine(f.GetTotalCalories());
           
           
            
        }

        public static void GetFruitSaladAndPringIfMyFavoriteFruitIsIn(FruitSalad f)
        {
            Console.WriteLine(f.ContainsMyFavoriteFruit());
        }

        public static FruitSalad GetFruitsArrayAndMakeFruitSalad(abstFruit[] af)
        {
            FruitSalad f = new FruitSalad();
            f.Fruits = af;
            return f;
         
        }


    }
}
