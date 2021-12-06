// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using GradesConsoleApp;


//8
List<Lecturer> studentList = new List<Lecturer>();
List<string> StudentList = new List<string>();


void StartApp()
{
    switch (StartMenu())
    {
        case 1:
            Add();
            break;
    }
}
StartApp();




int StartMenu()
{
    Console.WriteLine("Hi lecturer what you want to do ?");
    Console.WriteLine("for add student -press 1,to add the second student press 2");
    Console.WriteLine("chose number ");
    return int.Parse(Console.ReadLine());
}




void Add()
{
    try
    {
        //3
        Console.WriteLine("How many students do you want to keep");
        int NumStudent = int.Parse(Console.ReadLine());
        Console.WriteLine("entar your name");
        string NameLecturer = Console.ReadLine();
        //4
        for (int i = 0; i < NumStudent; i++)
        {
            Console.WriteLine("Enter a student name");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter a student id");
            string studentId = Console.ReadLine();
            Console.WriteLine("Enter 3 gardes");
            int gardes = int.Parse(Console.ReadLine());
            int gardes1 = int.Parse(Console.ReadLine());
            int gardes3 = int.Parse(Console.ReadLine());
            //5
            int[] gardesOfStu = new int[] { gardes, gardes1, gardes3 };
            studentList.Add(new Lecturer(NameLecturer, studentName, studentId, gardesOfStu));
        }





        void SaveInFile()       //6-//7
        {
            int cuontre = 0;
            FileStream fs = new FileStream($@"C:\TEST\{NameLecturer}.txt", FileMode.Append);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                foreach (Lecturer student in studentList)
                {
                    writer.WriteLine($" id: {cuontre}   ,name Lecturer:{student.nameLecturer},  taz:{student.idStudent}   , student name:{student.studentName}   ,gareds Student:{student.garedsStudent[0]} {student.garedsStudent[1]} {student.garedsStudent[2]},");
                    cuontre++;
                }
            }
        }
        SaveInFile();



        void CreatList()    //9
        {
            FileStream file = new FileStream($@"C:\TEST\{NameLecturer}.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(file))
            {
                for (int i = 0; i < NumStudent; i++)
                {
                    string str = reader.ReadLine();
                    StudentList.Add(str);
                }
                //Console.WriteLine(StudentList[1]);
            }
        }
        CreatList();
    }
    catch (Exception error)
    {
        Console.WriteLine(error);
    }
}









