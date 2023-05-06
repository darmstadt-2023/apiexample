public class Student{
    public int Id { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }
    public string ? Address { get; set; }

    List<Student>  listOfStudents;

    public void initList(){
        listOfStudents=new List<Student>();
        listOfStudents.Add(new Student{Fname="Jill", Lname="Smith", Address="E street"});
        listOfStudents.Add(new Student{Fname="Bob", Lname="Smith", Address="E street"});
        listOfStudents.Add(new Student{Fname="Ann", Lname="Smith"});
    }
    public List<Student> GetAll()
    {
        initList();
        return listOfStudents;
    }

    public Student GetOne(int id){
        initList();
        return listOfStudents[id];
    }

}