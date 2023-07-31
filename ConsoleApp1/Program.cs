Shape a = new Shape();
a.X = 1;
a.Y = 2;

Shape b = new Shape();
b.X = 1;
b.Y = 2;
Console.WriteLine(a==b);
public class Shape
{   
    public int X { get; set; }
    public int Y { get; set; }
}



