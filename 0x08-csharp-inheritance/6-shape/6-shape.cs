﻿using System;

///<summary>Represents a shape.</summary>
class Shape
{
    ///<summary>Provides calculated area of a shape: Not Implemented.</summary>
    public virtual int Area()
    {
        throw new System.NotImplementedException("Area() is not implemented");
    }
}

///<summary>Represents a rectangle.</summary>
class Rectangle:Shape
{
    private int width;
    private int height;

    ///<summary>Gets or sets width.  Width must be non-negative.</summary>
    public int Width
    {
        get {return (width);}
        set
        {
            if (value < 0)
                throw new System.ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }
    ///<summary>Gets or sets height.  Height must be non-negative.</summary>
    public int Height
    {
        get {return (height);}
        set
        {
            if (value < 0)
                throw new System.ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
}