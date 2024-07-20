using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person(1, "rama", 12);
            //PrintDetails(person1);

            //Person person2 = new Person(2, "sham", 23, 6, 60);
            //PrintDetails(person2);

            Person[] person = new Person[4]
            { new Person(1, "rama", 12),
              new Person(2, "sham", 23, 6, 60),
              new Person(3,"ravi",25,6,70),
              new Person(4,"Geeta",20,5,50)};
            PrintDetails(person);
        }
       
    
        static void PrintDetails(Person[] person) 
        {
            //Console.WriteLine("BMI for details enetred = " + person.CalculateBMI());
            //Console.WriteLine(person.CalculateBodyType());
            double maxBMI = 0;
            Person maxPerson = null;
            foreach (Person p in person)
            {
                double bmi = p.CalculateBMI();
                Console.WriteLine("BMI for "+ p + " is " + bmi);
                string bodyType = p.CalculateBodyType();
                Console.WriteLine("Body type for "+ p + " is " + bodyType);
                if (bmi > maxBMI)
                {
                    maxBMI = bmi;
                    maxPerson = p;
                }
            }
            Console.WriteLine("Person with max BMI--------");
            Console.WriteLine("Id = " + maxPerson.Id);
            Console.WriteLine("Name = " + maxPerson.Name);
            Console.WriteLine("Age = " + maxPerson.Age);
            Console.WriteLine("Height = " + maxPerson.Height);
            Console.WriteLine("Weight = " + maxPerson.Weight);
        }

    }
}
