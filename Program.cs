using DateBaseOfTeachers.Models;
using DateBaseOfTeachers.Services;
ITeacherService teacherService = new TeacherService();


string userChoice = string.Empty;
do
{
    Console.Clear();
    Console.WriteLine("==========================================");
    Console.WriteLine("             Datebase Of Teachers         ");
    Console.WriteLine("==========================================");
    Console.WriteLine("1. Show Teacher Base ");
    Console.WriteLine("2. Add New Teacher ");
    Console.WriteLine("3. Exit");
    Console.WriteLine("\n");

    int userInput = Convert.ToInt32(Console.ReadLine());
    switch (userInput)
    {
        case 1:
            {
               Teacher[] teachers = teacherService.ShowTeachers();
               if(teachers.Length == 0)
                {
                    Console.WriteLine("No teachers found");
                }
                else
                {
                    foreach(var teacher in teachers)
                    {
                        Console.WriteLine("-------------------------");
                        Console.WriteLine($"Id: {teacher.Id}");
                        Console.WriteLine($"Full Name: {teacher.FullName}");
                        Console.WriteLine($"Subject: {teacher.Subject}");
                        Console.WriteLine($"Experience: {teacher.Experience}");
                        Console.WriteLine($"Address: {teacher.Address}");
                    }
                }
                break;
            }
        
        case 2:
            {
                Teacher teacher = new Teacher();
                teacherService.AddTeacher(teacher);
                break;

            }
        
        case 3:
            {
                Console.WriteLine("Programm Finished!!!");
                break;
            }
        default:
            {
                Console.WriteLine("Wrong Choice!!!");
                break;
            }
    }
    Console.WriteLine("\nMenu ga qaytish uchun yes yozing:");
    userChoice = Console.ReadLine();
    
} while(userChoice.ToLower() == "yes");
