/* 
in java:

in c#:
    fields, properties, methods, constructors
    fields - charateristics of the object
    methods - behavior of your object
    constructors - special method called only on creation of object



POCO - plain c# object
    - class that holds data
*/

namespace tohModels {
    /// <summary>
    /// Data structure used for modeling a Hero.
    /// </summary>
    
    public class Hero {
        private string heroName;
        private int hp;
        private Element elementType;
        private SuperPower superpower;
        public string HeroName{ 
            get{ return heroName;}
            set{
                if(value.Equals(null)) {} //TODO: throw exception
                heroName = value;
            }
        }
        public int HP { 
            get{ return hp;}
            set{
                if(value.Equals(null)) {} //TODO: throw exception
                hp = value;
            }
        }
        public Element ElementType {get; set;}
        
        public SuperPower SuperPower { 
            get{ return superpower;}
            set{
                if(value.Equals(null)) {} //TODO: throw exception
                superpower = value;
            }
        }
    }
}