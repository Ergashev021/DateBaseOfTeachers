using System.Net.Sockets;

namespace DateBaseOfTeachers.Models;
public class Teacher
{
    public int Id{get; set;}
    public string FullName{get; set;}
    public string Subject {get; set;}
    public int experience{get; set;}
    public string Address{get; set;}
}