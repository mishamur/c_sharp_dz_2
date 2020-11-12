using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Animal
{
    public class Mammals : FatherAnimal
    {
        bool freandly = false;

        public Mammals(Byte age, String name, String color, String sex, bool freandly) : base(age, name, color, sex)
        {
            this.name = name;
            this.age = age;
            this.color = color;
            this.sex = sex;
            this.freandly = freandly;
        }

        public string GetInfoMammals()
        {
            Console.WriteLine("Млекопитающее");
            GetInfo();
            Console.WriteLine($"freandly: {freandly}");
            Console.WriteLine();
            return "";
        }

        public override string ToString()
        {
            return GetInfoMammals();
        }

        public override void Move()
        {
            Console.WriteLine("Топ-топ");
        }


    }
}
