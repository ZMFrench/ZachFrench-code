using tohModels;
using System.Collections.Generic;
using System;
namespace tohDL
{
    public interface IHeroRepository
    {
        List<Hero> GetHeroes();

        Hero AddHero(Hero newHero);
    }
}