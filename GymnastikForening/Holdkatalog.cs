using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymnastikForening
{
    public class HoldKatalog
    {
        private List<Hold> holdListe;

        public HoldKatalog()
        {
            holdListe = new List<Hold>();
        }

        public void TilføjHold(Hold hold) // der må ikke være dubletter
        {
            if (FindHold(hold.HoldId) != null)
            {
                throw new ArgumentException($"Der findes allerede et hold med hold id {hold.HoldId} ");
            }
            else
            {
                holdListe.Add(hold);
            }
        }

        public Hold FindHold(string holdId)
        {
            //foreach (Hold hold in holdListe)
            //{
            //    if (hold.HoldId == holdId)
            //        return hold;
            //}
            int i = 0; 
            while (i < holdListe.Count)
            {
                if (holdListe[i].HoldId == holdId)
                    return holdListe[i];
                i++;
            }
            return null;
        }

        public void PrintHoldListe()
        {
            foreach (Hold hold in holdListe)
            {
                Console.WriteLine(hold);
            }
        }

        public int FindAntalHold(string holdNavn)
        {
            //int antal = 0; 
            //foreach (Hold hold in holdListe)
            //{
            //    if (hold.HoldNavn == holdNavn)
            //    {
            //        antal++; 
            //    }
            //}
            //return antal;
            return HentHoldListe(holdNavn).Count;
        }

        public List<Hold> HentHoldListe(string holdNavn)
        {
            List<Hold> liste = new List<Hold>();
            foreach (Hold hold in holdListe)
            {
                if (hold.HoldNavn == holdNavn)
                {
                    liste.Add(hold);
                }
            }
            return liste; 
        }

        public override string ToString()
        {
            string returString = "";
            foreach (Hold hold in holdListe)
            {
                returString = returString + hold.ToString() + " \n";
            }
            return returString;
        }

    }
}
