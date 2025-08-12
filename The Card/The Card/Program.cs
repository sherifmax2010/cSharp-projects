
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
    public string color;
    public string rank;
    public Card(string Color, string rank)
    {
        this.color = color;
        this.rank = rank;
    }
}
