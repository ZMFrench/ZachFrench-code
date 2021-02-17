using System;
using tohModels;
using tohBL;
using tohDL;

namespace tohUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new HeroMenu(new HeroBL(new HeroRepoSC()));
            menu.Start();
            
        }
    }
}
