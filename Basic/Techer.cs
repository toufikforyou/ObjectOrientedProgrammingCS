class Teacher : University
{
    public Teacher(int id, string name, string department) : base(id, name, department) { }

    public virtual void TeacherRegister()
    {
        Console.WriteLine("Teacher Register on Teacher class");
    }
}