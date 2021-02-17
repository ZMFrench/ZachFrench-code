using System.Collections.Generic;
using tohModels;
namespace tohBL
{
    public interface IHeroBL
    {
        List<Hero> GetHeroes();

        void AddHero(Hero newHero);
    }
}