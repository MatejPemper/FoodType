using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food1
{
    
    class FoodType
    {
        private string name;
        private int protein;
        private int carbs;
        private int fat;

        private static int counter = 0;

        public FoodType(string name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;

        }

        public string GetName()
        {
            return name;
        }

        public int GetProtein()
        {
            return protein;
        }

        public int GetCarbs()
        {
            return carbs;
        }

        public int GetFat()
        {
            return fat;
        }

        public string toString()
        {
            return name + ": p - " + protein + "%, c - " + carbs + "%, f - " + fat + "%";
        }

        public static int GetNumberOfCreatedInstances()
        {
            return counter++;
        }
    }

    class Food
    {
        private FoodType type;
        private int weight;

        public Food(FoodType type, int weight)
        {
            this.type = type;
            this.weight = weight;
        }

        public FoodType GetType()
        {
            return type;
        }

        public int GetWeight()
        {
            return weight;
        }

        public double GetProtein()
        {
            return (type.GetProtein() / 100.0) * weight;
        }

        public double GetCarbs()
        {
            return (type.GetCarbs() / 100.0) * weight;
        }

        public double GetFat()
        {
            return (type.GetFat() / 100.0) * weight;
        }

        public string toString()
        {
            return type.toString() + ", w - " + weight + "g";
        }

        public string toStringInGrams()
        {
            return type.GetName() + ": p - " + Math.Round(GetProtein(), 1) + "g, c - " + Math.Round(GetCarbs(), 1) + "g, f - " + Math.Round(GetFat(), 1) + "g, w - " + weight + "g";
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Unesi ime hrane: ");
                string name = Console.ReadLine();

                Console.WriteLine("Unesi udio proteina(u postocima): ");
                int protein = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Unesi udio ugljikohidrata (u postocima): ");
                int carbs = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Unesi udio masti (u postocima): ");
                int fat = Convert.ToInt32(Console.ReadLine());

                FoodType foodType = new FoodType(name, protein, carbs, fat);

                Console.WriteLine("Unesi gramažu hrane: ");
                int weight = Convert.ToInt32(Console.ReadLine());

                Food food = new Food(foodType, weight);

                Console.WriteLine(food.toStringInGrams());
            


            Console.ReadKey();

        }
    }
}
