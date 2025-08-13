foreach (color c in Enum.GetValues(typeof(color)))
{
    foreach (rank r in Enum.GetValues(typeof(rank)))
    {   
        //String cc = Convert.ToString(c);
        //String rr = Convert.ToString(r);
        Card me = new Card(c, r);
        Console.WriteLine($"The {me.color} {me.rank}");
    }
}
enum color
{
    red,
    green,
    blue,
    yellow
}
enum rank
{
    one = 1,
    two = 2,
    three = 3,
    four = 4,
    five = 5,
    six = 6,
    seven = 7,
    eight = 8,
    nine = 9,
    ten = 10,
    Dollar,
    Percent,
    Caret,
    Ampersand
}
class Card
{
    public color color;
    public rank rank;
    public Card(color color, rank rank)
    {
        this.color = color;
        this.rank = rank;
    }
}
