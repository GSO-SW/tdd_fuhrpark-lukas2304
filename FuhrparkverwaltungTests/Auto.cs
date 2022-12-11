using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuhrparkverwaltungTests
{
    class Auto
    {
        private int kilometerstand;
        private double fuellstandInLiter;
        private double verbrauchInLiter;

        //Aufgabe 1
        public Auto (int kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }

        public int Kilometerstand
        { 
            
            get
            { 
                return kilometerstand; 
            } 
        }

        public void Fahren (int streckeInKilometern)
        {
            if (streckeInKilometern > 0)
            {
                kilometerstand += streckeInKilometern;
            }
            
        }

   

    }
}
