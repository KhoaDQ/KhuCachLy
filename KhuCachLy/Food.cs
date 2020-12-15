using System;
using System.Collections.Generic;
using System.Text;

namespace KhuCachLy
{
    public class Food
    {
        int numbered;
        int price;
        Nutrition starch;
        Nutrition fiber;
        Nutrition protein;
        Nutrition fat;

        public Food()
        { }

        public Food(int numbered, int price,int s, int fi, int p, int fa)
        {

            this.Price = price;
            this.Numbered = numbered;
            this.Starch = new Starch(s);
            this.Fiber = new Fiber(fi);
            this.Protein = new Protein(p);
            this.Fat = new Fat(fa);
        }

        public int Numbered { get => numbered; set => numbered = value; }
        public int Price { get => price; set => price = value; }
        public Nutrition Starch { get => starch; set => starch = value; }
        public Nutrition Fiber { get => fiber; set => fiber = value; }
        public Nutrition Protein { get => protein; set => protein = value; }
        public Nutrition Fat { get => fat; set => fat = value; }
    }
}
