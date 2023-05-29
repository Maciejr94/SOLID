// See https://aka.ms/new-console-template for more information
using LSPMain;

Console.WriteLine("Hello, World!");

#region ducks
//List<Duck> ducks = new List<Duck>();
//ducks.Add(new CityDuck());
//ducks.Add(new RubberDuck());

//ducks.ForEach(duck => duck.Fly());
#endregion ducks







#region coffe
Coffee coffee;
Console.WriteLine("Making normal coffee");
coffee = new Coffee();
coffee.Brew();

Console.WriteLine("Making latte coffee");
coffee = new CoffeeLatte();
coffee.Brew();
#endregion coffe

