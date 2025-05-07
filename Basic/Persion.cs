class Persion
{
    private int id = -1;
    private string name = "";
    private int age = -1;

    public Persion() { }

    public Persion(int id) { this.id = id; }

    public Persion(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public Persion(int id, string name, int age)
    {
        this.id = id;
        this.name = name;
        this.age = age;
    }

    public Persion(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public Persion(int id, int age)
    {
        this.id = id;
        this.age = age;
    }

    public void Register(int mobile)
    {
        Console.WriteLine($"Id: {id}, Name {name}, age {age}");
    }
    public void Register()
    {
        Console.WriteLine($"Id: {id}, Name {name}, age {age}");
    }

    public void Login()
    {

    }

    public int getId()
    {
        return id;
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public int GetSetId
    {
        get { return id; }
        set { id = value; }
    }




}