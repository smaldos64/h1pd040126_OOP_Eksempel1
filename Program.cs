namespace Eksempel1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            StudentTeam studentTeam_Object = new StudentTeam();
            StudentTeam studentTeam_Object1 = new StudentTeam(7, "h1pd040126");

            StudentTeam.SchoolName = "Tech College";
            StudentTeam.SchoolName = "Teknisk Skole";

            studentTeam_Object.setNumberOfStudentsInTeam(5);
            studentTeam_Object1.setNumberOfStudentsInTeam(15);

            studentTeam_Object1.NumberOfStudentsInTeam = 3;
            studentTeam_Object1.NumberOfStudentsInTeam = 20;

            Console.WriteLine($"Number of students in {studentTeam_Object.TeamName} is : {studentTeam_Object.getNumberOfStudentsInTeam()}");
            Console.WriteLine($"Number of students in {studentTeam_Object1.TeamName} is : {studentTeam_Object1.getNumberOfStudentsInTeam()}");

            Console.ReadLine();
        }
    }
}
