namespace ExercicioFixacao.Entities;

public class People
{
    public string Name { get; set; }
    public string Email { get; set; }
    public double Salary { get; set; }

    public People(string name, string email, double salary)
    {
        Name = name;
        Email = email;
        Salary = salary;
    }
}