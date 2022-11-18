namespace Laba2;


class Program
{
    // Вход в программу
    static void Main(string[] args)
    {
        // Инициализация объекта
        var cahier = new Cashier();

        // Вызов всех методов (для приготовления заказа)
        cahier.burger.CreateFood(5);
        cahier.drink.CreateFood(10);
        cahier.patato.CreateFood(2);
    }
}

// Класс отвечающий за заказы
// Передает кол-во еды которую нужно приготовить
class Cashier
{
    public ICreater burger = new BurgerMaker();
    public ICreater drink = new DrinkMaker();
    public ICreater patato = new PotatoMaker();
}


// Интерфейс
interface ICreater
{
    // Метод который нужно будет реализовать всем классам подписанным на него
    void CreateFood(int count);
}


// Класс отвечающий за приготовление Бургера
// Реализует интерфес ICreater
class BurgerMaker : ICreater
{
    // Метод который мы должны реализовать у интерфейса ICreater
    public void CreateFood(int count)
    {
        // Вывод в консоль результата
        Console.WriteLine($"Create {count} Burger");
    }
}


// Класс отвечающий за приготовление Напитка
// Реализует интерфес ICreater
class DrinkMaker : ICreater
{
    // Метод который мы должны реализовать у интерфейса ICreater
    public void CreateFood(int count)
    {
        // Вывод в консоль результата
        Console.WriteLine($"Create {count} Drink");
    }
}


// Класс отвечающий за приготовление Картошки
// Реализует интерфес ICreater
class PotatoMaker : ICreater
{
    // Метод который мы должны реализовать у интерфейса ICreater
    public void CreateFood(int count)
    {
        // Вывод в консоль результата
        Console.WriteLine($"Create {count} Potato");
    }
}