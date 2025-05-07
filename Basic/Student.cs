class Student : University, IStudent
{
    private string cls;

    public Student(int id, string name, string cls, string department) : base(id, name, department)
    {
        this.cls = cls;
    }

    public bool Login()
    {
        return false;
    }

    public void Register()
    {
        Console.WriteLine($"Id {id} Name: {name} Class: {cls} Department: {department}");
    }

}