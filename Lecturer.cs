// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


    namespace GradesConsoleApp
{
    public class Lecturer
    {
        public string nameLecturer;
        public string studentName;
        public string idStudent;
        public int[] garedsStudent;

        public Lecturer(string nameLecturer, string studentName, string idStudent, int[] garedsStudent)
        {
            this.nameLecturer = nameLecturer;
            this.studentName = studentName;
            this.idStudent = idStudent;
            this.garedsStudent = garedsStudent;
        }

    }

}


