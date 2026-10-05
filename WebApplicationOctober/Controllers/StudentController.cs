namespace WebApplicationOctober.Controllers;
using Microsoft.AspNetCore.Mvc;
using WebApplicationOctober.Models;

public class StudentController : Controller
{
    private readonly IStudentCRUDInterface _studentRepository;
    public StudentController(IStudentCRUDInterface studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public IActionResult Index()
    {
        return View(_studentRepository.GetAllStudents());
        //return View();
    }
}
