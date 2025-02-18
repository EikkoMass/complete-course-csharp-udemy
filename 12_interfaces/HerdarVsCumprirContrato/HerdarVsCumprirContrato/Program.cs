using HerdarVsCumprirContrato.Model.Entities;
using HerdarVsCumprirContrato.Model.Enums;

namespace HerdarVsCumprirContrato;

public class Program
{
    static void Main(string[] args)
    {
        IShape s1 = new Circle() { Color = Color.White, Radius = 2.0 };
        IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
}