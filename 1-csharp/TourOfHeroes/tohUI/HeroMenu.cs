using System;
using tohBL;
using tohModels;

namespace tohUI
{
    public class HeroMenu : IMenu
    {
        private IHeroBL _heroBL;
        public HeroMenu(IHeroBL heroBL){
            _heroBL = heroBL;
        }
        public void Start() {
            Boolean stay = true;

            do{
                //menu options part
                Console.WriteLine("Welcome to my Tour of Heroes app! What would you like to do?");
                Console.WriteLine("[0] Create a Hero");
                Console.WriteLine("[1] Get all Heroes");
                Console.WriteLine("[2] Exit");

                //get user input
                Console.WriteLine("Enter a number choice: ");
                string userInput = Console.ReadLine();

                switch(userInput){
                    case "0":
                        CreateHero();
                        break;
                    case "1":
                        GetHeroes();
                        break;
                    case "2":
                        stay = false;
                        ExitRemarks();
                        break;
                    default:
                        Console.WriteLine("Invalid input! Not part of menu options! >:[");
                        break;
                }
            }
            while (stay);
        }

        public void CreateHero(){
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

            Console.WriteLine("Hero successfully created!");
            _heroBL.AddHero(newHero);
        }
        public void GetHeroes(){
            foreach(var item in _heroBL.GetHeroes()){
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        public void ExitRemarks() {
            Console.WriteLine("goodbye friend! see you next time!");
        }
    }
}