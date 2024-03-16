
internal class Program
{
    private static void Main(string[] args)
    {

    }
}
public interface IDamage
{
    public void Death();
}
public interface Iatack
{
    public void Fire();
}
public abstract class Animal
{
    public abstract void Eat();
    public abstract void Sleep();
}

public class Cat : Animal,IDamage,Iatack //C# cho phép kế thừa 1 lớp, nhưng có thể kế thừa được nhiều interface
{
    public override void Eat() // ghi đè vào phương thức Eat
    {
       
    }
    public override void Sleep()
    {
       
    }

    public void Death() //phương thức được kế thừa từ interface IDamage
    {

    }
    public void Fire() //phương thức được kế thừa từ interface Iatack
    {

    }   
} 