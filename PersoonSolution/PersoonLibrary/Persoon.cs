using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace PersoonLibrary
{
    public class Persoon
    {
       // private static readonly Regex regex = new Regex([\w -] +);
        private List<string> voornamen;
        //public List<string> checkVoornamen;
        public Persoon(List<String> voornamen)   
        {
            //checkVoornamen = voornamen.Distinct().ToList();
            //if (checkVoornamen.Length != voornamen.Length )
            // throw new ArgumentException("Twee maal dezelfde naam ingegeven"); 

            if (voornamen.Count < 1) throw new ArgumentException("Te weinig voornamen gegeven");

            foreach (var voornaam in voornamen)
            {
                if (voornaam.Length < 1)
                {
                    throw new ArgumentException("Lege voornaam gegeven");
                }
            }
            this.voornamen = voornamen;
        }

        public override string ToString()
        {
            return String.Join(" ", this.voornamen);
        }

    }
}
