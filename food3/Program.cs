using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food3
{
    class FoodType
    {
        private string name;
        private int protein;
        private int carbs;
        private int fat;

        public string Name { get => name; set => name = value; }
        public int Protein { get => protein; set => protein = value; }
        public int Carbs { get => carbs; set => carbs = value; }
        public int Fat { get => fat; set => fat = value; }

        public FoodType(string name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
        }


        public override string ToString()
        {
            return name + ": protein: " + protein + "%, ugljikohidrati: " + carbs + "%, masti: " + fat + "%";
        }
    }

    class Food
    {
        private FoodType type;
        private int weight;

        internal FoodType Type { get => type; set => type = value; }
        public int Weight { get => weight; set => weight = value; }

        public Food(FoodType type, int weight)
        {
            this.type = type;
            this.weight = weight;
        }

        public double GetProtein()
        {
            return (type.Protein * weight) / 100.0;
        }

        public double GetCarbs()
        {
            return (type.Carbs * weight) / 100.0;
        }

        public double GetFat()
        {
            return (type.Fat * weight) / 100.0;
        }

        public override string ToString()
        {
            return type.ToString() + ", gramaža: " + weight + "g";
        }

        public string ToStringInGrams()
        {
            return type.Name + ": protein: " + GetProtein().ToString("0.0") + "g, ugljikohidrati: " + GetCarbs().ToString("0.0") + "g, mast: " + GetFat().ToString("0.0") + "g, gramaža: " + Weight + "g ";
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

            Console.WriteLine(food.ToStringInGrams());



            Console.ReadKey();

        }
    }
}