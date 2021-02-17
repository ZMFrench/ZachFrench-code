using System;
using tohModels;
using tohBL;

namespace tohUI
{
    class Program
    {
        private static IHeroBL heroBL = new HeroBL();
        static void Main(string[] args)
        {
            //Add Hero method
            Hero newHero = new Hero();
            SuperPower newSuperPower = new SuperPower();
            
            Console.WriteLine("Enter Hero Name: ");
            newHero.HeroName = Console.ReadLine();
            Console.WriteLine("Enter the Hero's HP: ");
            newHero.HP = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Superpower name: ");
            newSuperPower.Name = Console.ReadLine();
            Console.WriteLine("Enter their Superpower's description: ");
            newSuperPower.Description = Console.ReadLine();            
            Console.WriteLine("Enter their Superpower's damage: ");
            newSuperPower.Damage = int.Parse(Console.ReadLine());
            newHero.SuperPower = newSuperPower;            
            Console.WriteLine("Set the Hero's element: ");
            newHero.ElementType = Enum.Parse<Element>(Console.ReadLine());

            heroBL.AddHero(newHero);
            foreach(var item in heroBL.GetHeroes()){
                Console.WriteLine($"Hero created with the following details:\n\t Name: {item.HeroName}\n\t SuperPower: {item.SuperPower.Name}");
            }
        }
    }
}
