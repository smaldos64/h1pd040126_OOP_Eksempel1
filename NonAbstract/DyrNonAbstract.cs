using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksempel1.NonAbstract
{
    public class DyrNonAbstract
    {
        private string? navn;

        public string? Navn
        {
            get { return (this.navn); }
            set { this.navn = value; }
        }

        public DyrNonAbstract(string navn)
        {
            this.navn = navn;
        }

        // 1. ALMINDELIG METODE
        // Alle dyr trækker vejret på samme måde i dette eksempel. 
        // Kan ikke overskrives direkte i klasser , der arver fra klassen Dyr.
        public void TraekVejret()
        {
            Console.WriteLine($"{Navn} trækker vejret: Ind... ud...");
        }

        // 2. VIRTUEL METODE (angivet med det reserverede ord : virtual)
        // En standard måde at sove på, som underklasser KAN ændre.
        public virtual void Sov()
        {
            Console.WriteLine($"{Navn} sover trygt og stille.");
        }
    }
}
