door me1 = new door();

enum stat
{
    open,
    closed,
    locked
}
class door
{
    public stat status;
    public int key;

    public door()
    {
        Console.WriteLine("enter your key");
        this .key = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(key);
        Console.WriteLine("key is created");
        status = stat.locked;
    }
    public void Open()
    {
        status = stat.open;
    }
    public void Close()
    {
        status = stat.closed;
    }
    public void Lock()
    {
        status = stat.locked;
    }
    public void Unlock()
    {
        Console.WriteLine("enter your key to unlock the door");
        int inputKey = Convert.ToInt32(Console.ReadLine());
        if (inputKey == key)
        {
            status = stat.closed;
        }else
        {
            Console.WriteLine("wrong key");
        }
    }
    public void ChangeKey()
    {
        Console.WriteLine ("enter your old key");
        int oldkey = Convert.ToInt32(Console.ReadLine());
        if (oldkey == key)
        {
            Console.WriteLine("enter your new key");
            key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("key changed");
        }

    }

}