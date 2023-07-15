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
        Sold = false

    },
    new Plant()
     {
        Species = "Fiddle Leaf",
        LightNeeds = 2,
        AskingPrice = 6.00M,
        City = "Nashville",
        ZIP = "37203",
        Sold = false

    }
};

Console.WriteLine("Welcome to Plantville!");



string? choice = null;

while (choice != "0")
{
    Console.WriteLine(@"Please select a choice from the menu:
    1. Display All Plants
    2. Post a plant to be adopted
    3. Adopt a Plant
    4. Remove Plant
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
        try { throw new NotImplementedException("Adopt a Plant"); }
        catch (Exception ex)
        {
            Console.WriteLine(ex);

        }
    }
    else if (choice == "4")
    {
        try { throw new NotImplementedException("Remove Plant"); }
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


void sectionDivider()
{
    Console.WriteLine(" ");
    Console.WriteLine("------------------------------------- ");
    Console.WriteLine(" ");
}