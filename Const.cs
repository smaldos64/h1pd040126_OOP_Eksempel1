using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksempel1
{
    public static class Const
    {
        public const int minNumberOfStudentsInClass = 5;
        public const int maxNumberOfStudentsInClass = 20;
        
        // Metoden herunder giver compiler fejl, da det er en IKKE statisk metode
        // i en statisk klasse.
        //public void DoSomething()
        //{
        //    Console.WriteLine("Hello");
        //}

        public static int MyMultiplier(this int myIntParameter, int myMultiplier = 2)
        {
            return (myIntParameter * myMultiplier);
        }

    }
}
