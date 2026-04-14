using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksempel1.NonAbstract
{
    public class HundNonAbstract : DyrNonAbstract
    {
        public HundNonAbstract(string navn) : base(navn) { }

        // Vi VALGFRI overskriver den virtuelle metode
        public override void Sov()
        {
            Console.WriteLine($"{Navn} sover i hundekurven og drømmer om ben.");
        }
    }
}
