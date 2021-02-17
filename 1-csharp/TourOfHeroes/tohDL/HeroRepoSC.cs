using tohModels;
using System;
using System.Collections.Generic;
namespace tohDL
{
    public class HeroRepoSC : IHeroRepository
    {
        public List<Hero> GetHeroes(){
            return Storage.AllHeroes;
        }

        public Hero AddHero(Hero newHero){
            Storage.AllHeroes.Add(newHero);
            return newHero;
        }
    }
}