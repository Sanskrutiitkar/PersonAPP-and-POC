using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BMI
{
    class Person
    {
        private int id;
        private string name;
        private int age;
        private int height;
        private int weight;

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public int Age
        {
            get { return age; }
        }

        public int Height
        {
            get { return height; }
        }

        public int Weight
        {
            get { return weight; }
        }

        public Person(int id, string name, int age) : this(id, name, age, 5, 50)
        {
        }

        public Person(int id, string name, int age, int height, int weight)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public double CalculateBMI ()
        {
            return Math.Round((double)this.weight / ((this.height * 0.305) * (this.height * 0.305)),3);
        }

        public string CalculateBodyType()
        {
            double BMI = CalculateBMI();
            if (BMI >= 18.5 && BMI <= 24.9)
            {
                return "Normal";
            }
            else if (BMI > 25 && BMI <= 30)
            {
                return  "Overweight";
            }
            else 
            {
                return  "Obese";
            }
 
        }
    }
}