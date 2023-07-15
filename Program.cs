// See https://aka.ms/new-console-template for more information
using ExtraVert;

List<Plant> plants = new List<Plant>()
{
    new Plant()
    {
        Species = "Fern",
        LightNeeds = 4,
        AskingPrice = 6.00M,
        City = "Nashville",
        ZIP = "37203",
        Sold = false

    },
    new Plant()
     {
        Species = "Cactus",
        LightNeeds = 5,
        AskingPrice = 47.00M,
        City = "Nashville",
        ZIP = "37203",
        Sold = false

    },
    new Plant()
     {
        Species = "Snake Plant",
        LightNeeds = 4,
        AskingPrice = 26.00M,
        City = "Nashville",
        ZIP = "37203",
        Sold = false

    },
    new Plant()
     {
        Species = "Spider Plant",
        LightNeeds = 3,
        AskingPrice = 16.00M,
        City = "Nashville",
        ZIP = "37203",
        Sold = true

    },
    new Plant()
     {
        Species = "Fiddle Leaf",
        LightNeeds = 2,
        AskingPrice = 6.00M,
        City = "Nashville",
        ZIP = "37203",
        Sold = true

    }
};

Random random = new Random();


Console.WriteLine("Welcome to Plantville!");


string? choice = null;

while (choice != "0")
{
    Console.WriteLine(@"Please select a choice from the menu:
    1. Display All Plants
    2. Post a plant to be adopted
    3. Adopt a Plant
    4. Remove Plant
    5. Plant of the Day
    0. Exit
    ");
    choice = Console.ReadLine();

    if (choice == "1")
    {
        try 
        {
            Console.Clear();
            displayAllPlants();
            sectionDivider();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);

        }

    }
    else if (choice == "2")
    {
        try 
        {
            Console.Clear();
            postPlant();
            sectionDivider();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);

        }
    }
    else if (choice == "3")
    {
        try 
        { 
            Console.Clear();
            adoptPlant();
            sectionDivider();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);

        }
    }
    else if (choice == "4")
    {
        try 
        {
            Console.Clear();
            removePlant();
            sectionDivider();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);

        }
    }
    else if (choice == "5")
    {
        try
        {
            Console.Clear();
            plantOfTheDay();
            sectionDivider();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);

        }
    }
    else if (Int32.Parse(choice) > plants.Count )
    {
        Console.WriteLine("Please make a valid selection:");
        Console.WriteLine("");
    }

}

Console.WriteLine("Thanks for visiting");


void displayAllPlants()
{
    
    for (int i = 0; i < plants.Count; i++) 
    {
        Console.WriteLine($"{i+1}. {plants[i].Species} in {plants[i].City} {(!plants[i].Sold ? "is available" : "was sold")} for {plants[i].AskingPrice} ");    
    }
}

void postPlant()
{
    Console.WriteLine("Plant Species: ");
    var species = Console.ReadLine();
    Console.WriteLine("Light Needs: ");
    var lightNeeds = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Asking Price: ");
    var price = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("City where plant is located: ");
    var city = Console.ReadLine();
    Console.WriteLine("ZIP: ");
    var zip = Console.ReadLine();
    var sold = false;

    

    plants.Add(
        new Plant()
        {
            Species = species,
            LightNeeds = lightNeeds,
            AskingPrice = price,
            City = city,
            ZIP = zip,
            Sold = false

        });
    
}

void adoptPlant()
{
    
        for (int i = 0; i < plants.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{plants[i].Species} in {plants[i].City} ");
        }

    Console.WriteLine();
    Console.WriteLine("Please select the plant you wish to adopt (enter 0 to return to main menu): ");

    int adoptedPlant = Convert.ToInt32(Console.ReadLine());
    


    if (adoptedPlant == 0)
    {
        Console.Clear();
        return;
    } else
    {
        // Update value in list of objects - plants(list)[adoptedPlant -1](object by index).Sold(key in object) = true(new value)
        plants[adoptedPlant - 1].Sold = true;
    }
}

void removePlant()
{
    displayAllPlants();
    Console.WriteLine();
    Console.WriteLine("Select the plant you wish to remove (enter 0 to return to main menu): ");
    
    int plantToRemove = Convert.ToInt32(Console.ReadLine());
    

    if (plantToRemove == 0)
    {
        Console.Clear();
        return;
    }
    else
    {
        plants.RemoveAt(plantToRemove - 1);
    }

}

void plantOfTheDay()
{
    int randomInt = random.Next(1, plants.Count);

   
    Console.WriteLine($"{plants[randomInt].Species}");

    if (!plants[randomInt].Sold) 
    {
        
     Console.Write(@$"The Plant of the Day is:
     Plant: {plants[randomInt].Species}
     Location: {plants[randomInt].City}
     Light Needs: {plants[randomInt].LightNeeds}
     Price: {plants[randomInt].AskingPrice}
    ");
        Console.WriteLine();
        Console.WriteLine("Press 0 to return to the menu: ");
        string mainMenu = Console.ReadLine();

        if (mainMenu == "0" || string.IsNullOrEmpty(mainMenu))
        {
            Console.Clear();
            return;
        }else
        {
            Console.WriteLine("Please enter 0 if trying to return to the menu.");
        }

    }
    
    
}

void sectionDivider()
{
    Console.WriteLine(" ");
    Console.WriteLine("------------------------------------- ");
    Console.WriteLine(" ");
}
