using Exercise3.Entities.Enums;

namespace Exercise3.Entities;
using Exercise3.Entities.Enums;
abstract class Shape
{
    public Color Color { get; set; }
    

    public Shape(Color color)
    {
        Color = color;
    }

    public abstract double Area();


}