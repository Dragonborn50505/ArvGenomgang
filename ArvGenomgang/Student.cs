
public class Student : Human
{
    public string School { get; set; } = "NTI";

    public Student()
    {
        Name = "Herbert";
        Age = 16;

        movingObjekt = new Plane();
    }
}