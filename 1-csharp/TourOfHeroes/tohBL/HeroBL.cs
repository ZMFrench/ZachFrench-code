using System;
using System.Collections.Generic;
using tohDL;
using tohModels;

namespace tohBL
{
    public class HeroBL : IHeroBL
    {
        private IHeroRepository repo = new HeroRepoSC();

        public void AddHero(Hero newHero){
            //ToDO: Add BL
            repo.AddHero(newHero);
        }

        public List<Hero> GetHeroes(){
            //TODO: add BL
            return repo.GetHeroes();
        }
    }
}