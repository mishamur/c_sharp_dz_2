using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Animal
{
    public class Fish : FatherAnimal
    {
      protected String clascifik = "none";

        public Fish(Byte age, String name, String color, String sex, String clascifik) :base(age, name, color, sex)
        {
            this.clascifik = clascifik;
            this.age = age;
            this.name = name;
            this.color = color;
            this.sex = sex;
        }


        public string GetInfoFish()
        {
            Console.WriteLine("Рыба:");
            GetInfo();
            Console.WriteLine($"clascifik: {clascifik}");
            Console.WriteLine();
            return "";
        }
        
        public  override void Move()
        {
            Console.WriteLine("Буль-буль");
        }

        public override string ToString()
        {
            //return base.ToString();
            return GetInfoFish();
        }


    }
}
