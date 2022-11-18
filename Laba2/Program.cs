namespace Laba2;
class Program
{
    static void Main(string[] args)
    {
        var cahier = new Cashier();

        cahier.burger.CreateFood(5);
        cahier.drink.CreateFood(10);
        cahier.patato.CreateFood(2);
    }
}

class Cashier
{
    public ICreater burger = new BurgerMaker();
    public ICreater drink = new DrinkMaker();
    public ICreater patato = new PotatoMaker();


}


interface ICreater
{
    void CreateFood(int count);
}

class BurgerMaker : ICreater
{
    public void CreateFood(int count)
    {
        Console.WriteLine($"Create {count} Burger");
    }
}

class DrinkMaker : ICreater
{
    public void CreateFood(int count)
    {
        Console.WriteLine($"Create {count} Burger");
    }
}

class PotatoMaker : ICreater
{
    public void CreateFood(int count)
    {
        Console.WriteLine($"Create {count} Burger");
    }
}