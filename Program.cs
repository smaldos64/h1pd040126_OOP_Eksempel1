using Eksempel1.NonAbstract;

namespace Eksempel1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            // Her oprettes et objekt af klassen StudentTeam ved at bruge den tomme constructor.
            StudentTeam studentTeam_Object = new StudentTeam();
            // Her oprettes et andet objekt af klassen StudentTeam ved at bruge den
            // constructor, der overloader den tomme construcor.
            StudentTeam studentTeam_Object1 = new StudentTeam(7, "h1pd040126");

            StudentTeam.SchoolName = "Tech College";
            StudentTeam.SchoolName = "Teknisk Skole";

            studentTeam_Object.setNumberOfStudentsInTeam(5);
            studentTeam_Object1.setNumberOfStudentsInTeam(15);

            studentTeam_Object1.NumberOfStudentsInTeam = 5;
            studentTeam_Object1.NumberOfStudentsInTeam = 20;

            Console.WriteLine($"Number of students in {studentTeam_Object.TeamName} is : {studentTeam_Object.getNumberOfStudentsInTeam()}");
            Console.WriteLine($"Number of students in {studentTeam_Object1.TeamName} is : {studentTeam_Object1.getNumberOfStudentsInTeam()}");

            Console.WriteLine($"Number of students in {studentTeam_Object.TeamName} is : {studentTeam_Object.NumberOfStudentsInTeam}");
            Console.WriteLine($"Number of students in {studentTeam_Object1.TeamName} is : {studentTeam_Object1.NumberOfStudentsInTeam}");

            // I de 2 kode linjer herunder er der implicit kald til ToString() metoden,
            // da vi forsøger at udskrive et objekt direkte.
            Console.WriteLine(studentTeam_Object);
            Console.WriteLine(studentTeam_Object1);

            // I de 2 kode linjer herunder er der eksplicit kald til ToString() metoden.
            // 
            Console.WriteLine(studentTeam_Object.ToString());
            Console.WriteLine(studentTeam_Object1.ToString());

            int myNumber = 10;
            int myMultipliedNumber = myNumber.MyMultiplier(5);
            Console.WriteLine($"myMultipliedNumber er : {myMultipliedNumber}");
            
            myMultipliedNumber = myNumber.MyMultiplier();
            Console.WriteLine($"myMultipliedNumber er : {myMultipliedNumber}");

            studentTeam_Object.AddNumbers(5, 10);
            studentTeam_Object.AddNumbers(5.0, 10.0);
            studentTeam_Object.AddNumbers(5, 10.0);

            studentTeam_Object.AddNumbersInt(5, (int)10.0);

            HundNonAbstract hundNonAbstract_Object = new HundNonAbstract("Fido");

            hundNonAbstract_Object.TraekVejret(); // Kalder den almindelige metode fra Dyr  

            hundNonAbstract_Object.Sov(); // Kalder den overskrevne virtuelle metode } }

            DyrNonAbstract dyrNonAbstract_Object = new DyrNonAbstract("Ukendt dyretype !!!");

            dyrNonAbstract_Object.TraekVejret(); // Kalder den almindelige metode fra Dyr 

            dyrNonAbstract_Object.Sov(); // Kalder den oprindelige metode i klassen Dyr

            Console.ReadLine();
        }
    }
}
