using System;

namespace ConsoleApp2.Animal
{
    public  class Bird : FatherAnimal {

        Byte lengthWings = 0;
        public Bird(Byte age, String name, Byte lengthWings, String color, String sex) :base(age, name, color, sex)
        {
            this.name = name;
            this.age = age;
            this.lengthWings = lengthWings;
            this.color = color;
            this.sex = sex;
        }

        public string GetInfoBird()
        {
            Console.WriteLine("Птица:");
            GetInfo();
            Console.WriteLine($"lengthWings: {lengthWings}");
            Console.WriteLine();
            return "";
        }

        public override void Move()
        {
            Console.WriteLine("Вжух-вжух");
        }
        public override string ToString()
        {
            return GetInfoBird();
        }
    }
}
