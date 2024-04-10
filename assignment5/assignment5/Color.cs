using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5;

public class Color
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }
    public int Alpha { get; set; }

    public Color(int red, int green, int blue, int alpha)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    public Color(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = 255;
    }

    public decimal GetGrayscale()
    {
        return (Red + Green + Blue) / 3;
    }
}

public class Ball
{
    public decimal Size { get; set; }
    public Color Color { get; set; }
    public int Counts { get; set; }

    public Ball(decimal size, Color color)
    {
        Size = size;
        Color = color;
    }

    public void Pop()
    {
        Size = 0;
    }

    public void Throw()
    {
        if(Size > 0)
        {
            Counts++;
        }
    }
}
