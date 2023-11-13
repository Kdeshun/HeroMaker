using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker1
{
    public class Hero : IComparable
    {
        public Hero(string name, bool[] specialAbilities, List<string> cities, string sideKick, int strength, int speed, int stamina, DateTime birth, DateTime discovery, DateTime reveal, decimal yearsExp, string capeColor, int evilness, string logoSymbol)
        {
            Name = name;
            SpecialAbilities = specialAbilities;
            Cities = cities;
            SideKick = sideKick;
            Strength = strength;
            Speed = speed;
            Stamina = stamina;
            Birth = birth;
            Discovery = discovery;
            Reveal = reveal;
            YearsExp = yearsExp;
            CapeColor = capeColor;
            Evilness = evilness;
            LogoSymbol = logoSymbol;
        }

        public string Name { get; set; }
        public bool[] SpecialAbilities { get; set; }
        public List<String> Cities { get; set; }
        public string SideKick { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Stamina { get; set; }
        public DateTime Birth { get; set; }
        public DateTime Discovery { get; set; }
        public DateTime Reveal { get; set; }
        public decimal YearsExp { get; set; }
        public string CapeColor { get; set; }
        public int Evilness { get; set; }
        public string LogoSymbol { get; set; }

        public int CompareTo(object obj)
        {
            Hero other = (Hero)obj;
            return Name.CompareTo(other.Name);
        }

        override public string ToString()
        {
            string status_Message = "";
            status_Message += "name: " + this.Name;



            status_Message = "Your Hero '" + this.Name + "', can: ";
            if (this.SpecialAbilities[0])
                status_Message += "fly, ";
            if (this.SpecialAbilities[1])
                status_Message += "control minds, ";
            if (this.SpecialAbilities[2])
                status_Message += "mentally compute anything, ";
            if (this.SpecialAbilities[3])
                status_Message += "run fast, ";
            if (this.SpecialAbilities[4])
                status_Message += "lift impossibly heavy objects, ";
            if (this.SpecialAbilities[5])
                status_Message += "buy anything, ";
            if (this.SpecialAbilities[6])
                status_Message += "turn invisible, ";
            if (this.SpecialAbilities[7])
                status_Message += "shape shift, ";

            status_Message += "and thats it. They work in: ";
            foreach (String city in this.Cities)
            {
                status_Message += city + ", and ";
            }

            status_Message += "work with their trusty sidekick: " + this.SideKick + ".";

            status_Message += "\r\nThey have Strength: " + this.Strength + ". Speed: " + this.Speed + ". Stamina: " + this.Stamina + ". ";
            status_Message += "\r\nThe day that " + this.Name + " was born is: " + this.Birth + ". They discovered their abilities on: " + this.Discovery + ". They revealed themself to the rest of the world: " + this.Reveal + ". ";
            status_Message += "\r\nThey have " + this.YearsExp + " years experience";
            status_Message += "\r\nThe cape color they have is: " + this.CapeColor.ToString();
            status_Message += "\r\n" + this.Name + " has: " + this.Evilness + " capacity for Evil.";
            status_Message += "\r\nThe logo they have is: " + this.LogoSymbol;

            return status_Message;
        }
    }
}