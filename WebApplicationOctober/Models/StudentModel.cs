using System;
namespace WebApplicationOctober.Models;

public class StudentModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Credits { get; set; }
    public string Email { get; set; }
    public List<string> Courses { get; set; }

    public StudentModel()
    {
        Id = 0;
        Name = string.Empty;
        Credits = 0;
        Email = string.Empty;
    }

    public StudentModel(int id, string name, int credits, string email)
    {
        Id = id;
        Name = name;
        Credits = credits;
        Email = email;
    }

    public void AddCourse(string course)
    {
        if (Courses == null)
        {
            Courses = new List<string>();
        }
        Courses.Add(course);
    }
}