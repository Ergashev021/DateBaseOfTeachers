using DateBaseOfTeachers.Models;

namespace DateBaseOfTeachers.Services;
public interface ITeacherService
{
    void CreateTeacher(Teacher teacher);
    Teacher[] ShowTeachers();
    void PrintTeacher(Teacher teacher);
  
}