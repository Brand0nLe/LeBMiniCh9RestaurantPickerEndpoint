//Brandon Le
//10-27-22
//Mini Challenge 9 - Restaurant Picker
//Web API project that will give the user 3 options to choose from.In my case I chose asian food, fast food, and beverages as my 3 options. There is an instructions page at /minich9/ But by entering ASIAN, FAST, or DRINKS the user will get a randomized restaurant/business sent back to them. I also included error messages for when anything else is entered it will prompt them to enter it in correctly and I also provided links that they can click as well.
//Peer Review: Elizar Garcia - Outstanding job! By far one of the best projects I have come by so far. The coding is beautiful. Adding links to take you to the next page was impressive it also generated the randome food. Mind blowing and outstanding work! great job!!!!


using Microsoft.AspNetCore.Mvc;

namespace LeBMiniCh9RestaurantPickerEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh9Controller : ControllerBase
{
    public string Instructions()
    {
        return "Welcome to the restaurant picker!\n You have 3 options: Asian Food, Fast Food or Beverages.\n ASIAN = Asian Food, FAST = Fast Food, and DRINKS = Beverages if you're thirsty!\n\n Enter your choice in the URL after restaurant/\n For example: https://localhost:7267/minich9/Restaurant/\n **Make sure to use all CAPS or your link won't work**\n\n Or if you're lazy you can use the following links:\n https://localhost:7267/minich9/Restaurant/ASIAN\n https://localhost:7267/minich9/Restaurant/FAST\n https://localhost:7267/minich9/Restaurant/DRINKS";
    }

    [HttpGet]
    [Route("Restaurant/{choice}")]
    public string Restaurant(string choice)
    {

    string [] asianFood = {"Mama's Pho", "Green Papaya", "Komachi Sushi", "OZ Korean BBQ", "Bonchon", "Royal Siam", "M Sushi", "Tasty Pot", "Blue House Korean BBQ", "RAW Sushi Bistro"};
    string [] fastFood = {"McDonald's", "Taco Bell", "Wendy's", "Jack In The Box", "Popeye's", "Burger King", "Wingstop", "Sonic's", "Del Taco", "Raising Cane's"};
    string [] beverages = {"T4", "Happy Lemon", "Jamba Juice", "Bober Tea", "Kung Fu Tea", "7 Leaves Cafe", "Purple Kow", "Boba Guys", "Sharetea", "Tea Dazed"};
    
        if(choice == "ASIAN")
        {
        Random r = new Random();
        int randomInt = r.Next(0, 9);
        return $"You chose Asian Food! You should try: {asianFood[randomInt]}";
        }
        
        if(choice == "FAST")
        {
        Random r = new Random();
        int randomInt = r.Next(0, 9);
        return $"You chose Fast Food! You should try: {fastFood[randomInt]}";
        }
                
        if(choice == "DRINKS")
        {
        Random r = new Random();
        int randomInt = r.Next(0, 9);
        return $"Someone's thirsty! You should try: {beverages[randomInt]}";
        }
        
        else
        {
            return "You entered an invalid choice! Please enter ASIAN, FAST, or DRINKS.\n **DON'T FORGET TO PUT THEM IN ALL CAPS**\n Or you can use the following links:\n https://localhost:7267/minich9/Restaurant/ASIAN\n https://localhost:7267/minich9/Restaurant/FAST\n https://localhost:7267/minich9/Restaurant/DRINKS";
        }
    }
}
