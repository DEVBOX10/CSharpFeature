public record Person
{
    public string Name { get; }
    public int Age { get; }
    public Person(string name, int age) => (Name, Age) = (name, age);
}

public record Person2
{
    public string Name { get; init; }
    public int Age { get; init; }
}