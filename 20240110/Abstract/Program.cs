internal class Program
{
    private static void Main(string[] args)
    { 
    
    }
}
public abstract class Enemy
{
    public abstract void Actack();
}
public class Animal : Enemy
{
    public override void Actack()
    {
        Console.WriteLine("Cao, can, xe");
    }
}
public class Robot : Enemy
{
    public override void Actack()
    {
        Console.WriteLine("Ban sung")
    }
}