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

        // Her er en OVERRIDE af den virtuelle metode ToString, som er arvet
        // fra klassen Object. Det vil sige, at når man kalder ToString på
        // et objekt af klassen StudentTeam, så vil denne metode blive kaldt
        // i stedet for den oprindelige ToString metode i klassen Object.
        public override string ToString()
        {
            //return base.ToString();
            return ($"Team name : {this.teamName} - Number of students in team : {this.numberOfStudentsInTeam} - School name : {schoolName} -");
        }

        // Herunder er der 2 metoder, hvor de 2 første metoder benytter OVERLOADING.
        // Det vil sige, at det er de angivne parametere, der afgør hvilken af de 2 metoder,
        // der bliver kaldt.
        // Det er ren skibidi crunch, at man kan kalde metoden AddNumbers med både int og
        // double parametre, da det er de angivne parametere, der afgør hvilken metode,
        // der bliver kaldt. Så den der kalder metoden behøver ikke at bekymre sig om
        // hvilken metode, der bliver kaldt, da det er parametrene, der afgør det.
        public int AddNumbers(int number1, int number2)
        {
            return (number1 + number2);
        }

        public double AddNumbers(double number1, double number2)
        {
            return (number1 + number2);
        }

        public int AddNumbersInt(int number1, int number2)
        {
            return (number1 + number2);
        }

        public double AddNumbersDouble(double number1, double number2)
        {
            return (number1 + number2);
        }
    }
}
