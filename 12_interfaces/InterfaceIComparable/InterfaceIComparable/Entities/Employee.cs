using System.Globalization;

namespace InterfaceIComparable.Entities;

public class Employee : IComparable
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string csv)
    {
        string[] values = csv.Split(',');
        Name = values[0];
        Salary = double.Parse(values[1], CultureInfo.InvariantCulture);
    }

    public override string ToString()
    {
        return $"{Name}, {Salary.ToString("F2",CultureInfo.InvariantCulture)}";
    }

    public int CompareTo(object? obj)
    {
        if (!(obj is Employee))
        {
           throw new ArgumentException($"Object must be of type {nameof(Employee)}"); 
        }
        
        Employee employee = (Employee) obj;
        
        //return Salary.CompareTo(employee.Salary);
        return Name.CompareTo(employee.Name);
    }
}