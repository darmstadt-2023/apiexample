using Microsoft.AspNetCore.Mvc;

namespace apiexample.Controllers;
[ApiController]
[Route("[controller]")]
public class StudentController : Controller {
[HttpGet]
public List<Student> Get(){
    Console.WriteLine("Student endpoint called");
    Student objectStudent= new Student();
    return objectStudent.GetAll();
}

[HttpGet("{id}")]
public Student GetOneStudent(int id){
    Console.WriteLine("Student endpoint called");
    Student objectStudent= new Student();
    return objectStudent.GetOne(id);
}

}
