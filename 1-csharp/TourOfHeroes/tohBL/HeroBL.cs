using System;
using System.Collections.Generic;
using tohDL;
using tohModels;

namespace tohBL
{
    public class HeroBL : IHeroBL
    {
        private IHeroRepository _repo = new HeroRepoSC();
        public HeroBL(IHeroRepository repo) {
            _repo = repo;
        }

        public void AddHero(Hero newHero){
            //ToDO: Add BL
            _repo.AddHero(newHero);
        }

        public List<Hero> GetHeroes(){
            //TODO: add BL
            return _repo.GetHeroes();
        }
    }
}