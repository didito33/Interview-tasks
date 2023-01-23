// See https://aka.ms/new-console-template for more information
using AnimalSimulations;


Animal fox1 = new Fox(3);
Animal fox2 = new Fox(3);
Animal fox3 = new Fox(3);

Animal rabbit1 = new Rabbit(1);
Animal rabbit2 = new Rabbit(1);
Animal rabbit3 = new Rabbit(1);

Animal deer1 = new Deer(2);
Animal deer2 = new Deer(2);
Animal deer3 = new Deer(2);

List<Animal> animals = new List<Animal>();
animals.Add(fox1);
animals.Add(fox2);
animals.Add(fox3);
animals.Add(rabbit1);
animals.Add(rabbit2);
animals.Add(rabbit3);
animals.Add(deer1);
animals.Add(deer2);
animals.Add(deer3);

Random random = new Random();
Type type = typeof(Foods);
var values = type.GetEnumValues();

foreach (var animal in animals)
{
    while (!animal.IsDead())
    {
        animal.Feed((Foods)values.GetValue(random.Next(values.Length)));
    }
}
//Console.WriteLine(animals.Where(f=>f.DaysSurvived == 6).Single().DaysSurvived);
Console.WriteLine("The rabbits' lifespans were: ");
Console.WriteLine($"{animals.Where(f => f.MaxEnergy == 1).Min(f => f.DaysSurvived)} MIN");
Console.WriteLine($"{animals.Where(f => f.MaxEnergy == 1).Average(f => f.DaysSurvived):f0} on average");
Console.WriteLine($"{animals.Where(f => f.MaxEnergy == 1).Max(f => f.DaysSurvived)} MAX");

Console.WriteLine("\nThe deers' lifespans were: ");
Console.WriteLine($"{animals.Where(f => f.MaxEnergy == 2).Min(f => f.DaysSurvived)} MIN");
Console.WriteLine($"{animals.Where(f => f.MaxEnergy == 2).Average(f => f.DaysSurvived):f0} on average");
Console.WriteLine($"{animals.Where(f => f.MaxEnergy == 2).Max(f => f.DaysSurvived)} MAX");

Console.WriteLine("\nThe foxes' lifespans were: ");
Console.WriteLine($"{animals.Where(f => f.MaxEnergy == 3).Min(f => f.DaysSurvived)} MIN");
Console.WriteLine($"{animals.Where(f=>f.MaxEnergy == 3).Average(f=>f.DaysSurvived):f0}  on average");
Console.WriteLine($"{animals.Where(f => f.MaxEnergy == 3).Max(f => f.DaysSurvived)} MAX");

//Simplified simulation with an input from the console

/*Fox fox = new Fox(3);
Rabbit rabbit = new Rabbit(2);
Deer deer = new Deer(3);

int dayCounter = 1;
while(!fox.IsDead() || !rabbit.IsDead() || !deer.IsDead())
{
    Console.WriteLine($"Day {dayCounter}. Feed the animals with: Carrot, Meat or Grass");
    string food = Console.ReadLine();
    if (Enum.TryParse(food, true, out Foods foodEnum))
    {
        fox.Feed(foodEnum);
        rabbit.Feed(foodEnum);
        deer.Feed(foodEnum);
    }
    else
    {
        Console.WriteLine("The meal that you have entered is not in the list.");
        continue;
    }
    dayCounter++;
    Console.WriteLine($"The fox has {fox.CurrEnergy} energy left.");
    Console.WriteLine($"The rabbit has {rabbit.CurrEnergy} energy left.");
    Console.WriteLine($"The deer has {deer.CurrEnergy} energy left." + '\n');
}
Console.WriteLine($"The fox lived through {fox.DaysSurvived} meals, the rabbit through {rabbit.DaysSurvived} meals and lastly " +
    $"the deer through {deer.DaysSurvived} meals.");
*/