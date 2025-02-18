using HerdarVsCumprirContrato.Model.Enums;

namespace HerdarVsCumprirContrato.Model.Entities;

public abstract class AbstractShape : IShape
{
    public Color Color { get; set; }
    
    public abstract double Area();
}