using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksempel1
{
    public class StudentTeam
    {
        private int numberOfStudentsInTeam;
        private string? teamName;

        // Den variabel som er erklæret herunder er en statisk variabel,
        // som virker på selve klassen og IKKE på objekter af klassen.
        // Det vil altså sige, at alle objekter af klassen har samme værdi
        // af variablen schoolName. 
        // Man kan heller ikke bruge syntaksen this.schoolName , da 
        // this jo hører sammen med et givet objekt af klassen.
        private static string? schoolName;

        // Her er en constructor. Dette kan man se ved at metoden har
        // SAMME navn som klassen. Og desuden at der IKKE er angivet
        // nogen retur type. 
        //public StudentTeam(int numberOfStudentsInTeam, string teamName)
        //{
        //    this.numberOfStudentsInTeam = numberOfStudentsInTeam;
        //    this.teamName = teamName;
        //}

        // Hvis man bruger syntaksen herunder med default værdier kan man
        // udelade den tomme constructor vist i linje 41.
        public StudentTeam(int numberOfStudentsInTeam = 10, string teamName = "TestTeam")
        {
            this.numberOfStudentsInTeam = numberOfStudentsInTeam;
            this.teamName = teamName;
            // Kodelinjen herunder giver en comiler fejl.
            //this.schoolName = "Test";
        }

        public StudentTeam() : this(8, "TestTeam2")
        {
        }

        public void setNumberOfStudentsInTeam(int numberOfStudentsInTeam)
        {
            this.numberOfStudentsInTeam = numberOfStudentsInTeam;
        }

        public int getNumberOfStudentsInTeam()
        {
            return (this.numberOfStudentsInTeam);
        }

        public string ?TeamName
        {
            get
            {
                return (this.teamName);
            }
            set
            {
                this.TeamName = value;
            }
        }

        public int NumberOfStudentsInTeam
        {
            get
            {
                return (this.numberOfStudentsInTeam);
            }
            set
            {
                if ((value < Const.minNumberOfStudentsInClass) || 
                    (value > Const.maxNumberOfStudentsInClass))
                {
                    throw new ArgumentException($@"Antal elever skal være mellem {Const.minNumberOfStudentsInClass} 
                      og {Const.maxNumberOfStudentsInClass} !!!");
                }
                else
                {
                    this.numberOfStudentsInTeam = value;
                }
            }
        }

        public static string ?SchoolName
        {
            get
            {
                return (schoolName);
            }
            set
            {
                schoolName = value;
            }
        }
    }
}
