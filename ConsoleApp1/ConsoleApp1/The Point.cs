Point point1 = new Point(2, 3);
Point point2 = new Point(-4, 0);
Console.WriteLine("("+ point1.x + "," + point1.y +")" );
Console.WriteLine("(" + point2.x + "," + point2.y + ")");

class Point
{
    public int x { get; }
    public int y { get; }
    public  Point(int x, int y)
    {
        this .x = x;
        this .y = y;
    }
    public  Point() : this(0,0)
    {
        return x = y = 0;
    }

}
