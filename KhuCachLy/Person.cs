using System;
using System.Collections.Generic;
using System.Text;

namespace KhuCachLy
{
    public class Person
    {
        private float height;
        private int weight;
        private float bMI;
        private string status;
        public List<Food> foods;

        Nutrition starch = new Starch();
        Nutrition fiber = new Fiber();
        Nutrition protein = new Protein();
        Nutrition fat = new Fat();

        public int Weight { get => weight; set => weight = value; }
        public float BMI { get => bMI; set => bMI = value; }
        public float Height { get => height; set => height = value; }
        public string Status { get => status; set => status = value; }
        public Nutrition Starch { get => starch; set => starch = value; }

        public Person()
        { }

        public Person(int weight, float height)
        {
            this.Weight = weight;
            this.Height = height;
            this.BMI = weight / (height * height);

            if (this.BMI < 18.5)
            {
                this.Status = "Thiếu cân";
                this.Starch.ChangeValue(20);
                this.protein.ChangeValue(10);
                this.fat.ChangeValue(15);
            }
            else if (this.BMI <= 25)
            {
                this.Status = "Bình thường";
            }
            else if (this.BMI <= 30)
            {
                this.Status = "Thừa cân";
                this.Starch.ChangeValue(-25);
                this.Starch.value = 10;
                this.protein.ChangeValue(10);
                this.fat.ChangeValue(-10);
            }  
            else
            {
                this.Status = "Béo phì";
                this.Starch.ChangeValue(-30);
                this.protein.ChangeValue(10);
                this.fat.ChangeValue(-20);
            }

            this.foods = new List<Food>();

        }

        public override string ToString()
        {
            return "\nWeight: " + weight + "\nHeight: " + height + "\nBMI: " + bMI + "\n Status: " + status;
        }

        public float FoodFee()
        {
            float total = 0;
            foreach(Food item in this.foods)
            {
                total = total + item.Price;
            }
            return total;
        }

        public bool Evaluate()
        {

            foreach (Food item in this.foods)
            {
                this.Starch.value += item.Starch.value;
                this.fiber.value += item.Fiber.value;
                this.protein.value += item.Protein.value;
                this.fat.value += item.Fat.value;
            }

            if (this.Starch.Evaluate() && this.fiber.Evaluate() && this.protein.Evaluate() && this.fat.Evaluate()) return true;
            else return false;

        }
    }
}
