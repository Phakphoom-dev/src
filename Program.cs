
int manticoreHealth = 10;
int maximumManticoreHealth = 10;
int cityHealth = 15;
int maximumCityHealth = 15;
int round = 1;
int cannonDamage = Helper.CalculateCanonDamage(round);

Console.BackgroundColor = ConsoleColor.Yellow;
int manticoreDistance = Helper.GetNumberInRange(
    "Player 1, how far away from the city do you want to station the Manticore? ", 1, 100);

Console.ResetColor();

Console.WriteLine("Player 2 it's your turn ");

while (manticoreHealth > 0 || cityHealth > 0)
{
    if (round == 1)
        Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine($"STATUS : City: {cityHealth}/{maximumCityHealth} | Manticore: {manticoreHealth}/{maximumManticoreHealth} ");
    Console.WriteLine($"The cannon is expected to deal {cannonDamage} damage this round.");

    int roundCanonRange = Helper.GetNumberInRange("Enter desired cannon range: ", 1, 100);

    if (roundCanonRange == manticoreDistance)
    {
        manticoreHealth -= cannonDamage;
        Console.WriteLine("That round was a DIRECT HIT!");
    }
    else if (roundCanonRange < manticoreDistance)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
    }
    else
    {
        Console.WriteLine("That round OVERSHOT the target.");
    }

    if (manticoreHealth <= 0)
    {
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        break;
    }

    if (cityHealth <= 0)
    {
        Console.WriteLine("The city of Consolas has been destroyed!");
        break;
    }

    cityHealth -= 1;
    round += 1;
    cannonDamage = Helper.CalculateCanonDamage(round);
    
    Console.WriteLine("-----------------------------------------------------------");
}

