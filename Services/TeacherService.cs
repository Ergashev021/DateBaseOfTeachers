    using DateBaseOfTeachers.Models;
    namespace DateBaseOfTeachers.Services;
   
    public class TeacherService : ITeacherService
    {
        private Teacher[] teachers = new Teacher[100];
        private int count = 0;
        
    

    public void AddTeacher(Teacher teacher)
    {
        
        Console.Write("Id : ");
        teacher.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Full Name: ");
        teacher.FullName = Console.ReadLine();

        Console.Write("Subject: ");
        teacher.Subject = Console.ReadLine();

        Console.Write("Experience : ");
        teacher.Experience = Convert.ToInt32(Console.ReadLine());

        Console.Write("Address ");
        teacher.Address = Console.ReadLine();

        teachers[count] = teacher;
        count++;

        Console.WriteLine("Teacher successfully added!");
    }

 
    public Teacher[] ShowTeachers()
    {
        Teacher[] result = new Teacher[count];

        for (int i = 0; i < count; i++)
        {
            result[i] = teachers[i];
        }

        return result;
        
    }

   

   
}