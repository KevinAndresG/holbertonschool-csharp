using System;

///<sumary>some shapes</sumary>
class Shape
{
	///<sumary>Empty now</sumary>
	public virtual int Area()
	{
		throw new NotImplementedException("Area() is not implemented");
	}
}
///<sumary>Rectangles</sumary>
class Rectangle : Shape
{
	private int width;
	private int height;
	public int Width
	{
		get { return width; }
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Width must be greater than or equal to 0");
			}
			width = value;
		}
	}
	public int Height
	{
		get { return height; }
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Height must be greater than or equal to 0");
			}
			height = value;
		}
	}
	///<Returns>return the area of rectangle</Returns>
	public new int Area()
	{
		return (width * height);
	}
	///<Returns>return the format of rectangle</Returns>
	public override string ToString()
	{
		return ($"[{this.GetType()}] {width} / {height}");
	}
}

///<sumary>Squares</sumary>
class Square : Rectangle
{
	private int size;
	public int Size
	{
		get { return size; }
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Size must be greater than or equal to 0");
			}
			size = value;
			base.Width = size;
			base.Height = size;
		}
	}
}
