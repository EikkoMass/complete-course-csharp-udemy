namespace ExercicioResolvidoConjuntos.Entities;

public class User
{
    public string Name { get; set; }
    public DateTime CreationDate { get; set; }

    public User(string name, DateTime creationDate)
    {
        Name = name;
        CreationDate = creationDate;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is User)) return false;
        User user = (User) obj;
        return Name.Equals(user.Name);
    }
}