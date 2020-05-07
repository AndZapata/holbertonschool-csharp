using System;

/// <summary>
/// Class Shape
/// </summary>
class Shape
{
    /// <summary>
    /// Function that throws a error massage exception
    /// </summary>
    /// <returns>new throws message exception</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Class Rectangle that inherits from Shape
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    public int Width
    {
        get
        {
            return (width);
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }
    public int Height
    {
        get
        {
            return (height);
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }
}
