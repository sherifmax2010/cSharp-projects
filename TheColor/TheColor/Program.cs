Color me = new Color(245, 156, 0);
Console.WriteLine($"({me.red} , {me.green} , {me.blue})");
Console.WriteLine($"({Color.Red.red} , {Color.Red.green} , {Color.Red.blue})");

class Color
{
    public int red { get; }
    public int green { get; }
    public int blue { get; }

    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Orange { get; } = new Color(255, 165, 0);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Green { get; } = new Color(0, 255, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Purple { get; } = new Color(128, 0, 128);
    public static Color Red { get; } = new Color(255, 0, 0);



    public Color(int red, int green, int blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
    }
}
