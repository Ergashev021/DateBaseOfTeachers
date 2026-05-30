using DateBaseOfTeachers.Models;

namespace DateBaseOfTeachers.Services;
public interface ITeacherService
{
    
    void AddTeacher(Teacher teacher);
    Teacher[] ShowTeachers();
    
  
}