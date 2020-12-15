using System;
using System.Collections.Generic;
using System.Text;

namespace KhuCachLy
{
    public class Nutrition
    {
        protected float maxValue;
        protected float minValue;
        public float value;


        public void ChangeValue(int percen)
        {
            this.maxValue = this.maxValue * (float)(1 + (percen / 100.0));
            this.minValue = this.minValue * (float)(1 + (percen / 100.0));
        }

        public bool Evaluate()
        {
            if (this.value <= this.maxValue && this.value >= this.minValue) return true;
            else return false;
        }

        public void Info()
        {
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
            Console.WriteLine(value);
        }
    }


    public class Starch : Nutrition
    {
        public Starch()
        {
            maxValue = 1000;
            minValue = 800;
        }

        public Starch(int v)
        {
            maxValue = 1000;
            minValue = 800;
            value = v;
        }
    }
    public class Fiber : Nutrition
    {
        
        public Fiber()
        {
            maxValue = 800;
            minValue = 600;
        }

        public Fiber(int v)
        {
            maxValue = 800;
            minValue = 600;
            value = v;
        }
    }
    public class Protein : Nutrition
    {
        public Protein()
        {
            maxValue = 600;
            minValue = 500;
        }

        public Protein(int v)
        {
            maxValue = 600;
            minValue = 500;
            value = v;
        }

    }
    public class Fat : Nutrition
    {
        public Fat()
        {
            maxValue = 500;
            minValue = 300;
        }

        public Fat(int v)
        {
            maxValue = 500;
            minValue = 300;
            value = v;
        }
    }

}
