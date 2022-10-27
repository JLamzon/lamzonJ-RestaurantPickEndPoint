//Jessie Lamzon
//10-26-22
//Restaurant Picker End Point
//https://localhost:7087/restaurantpicker/foodpicker/*enter type of food*
//Peer review by Carlos Felipe : This code is very organized. Looks polished. The inputs vary a lot and I liked the choice to be able to pick a random thing. Great work.


using Microsoft.AspNetCore.Mvc;

namespace lamzonJ_RestaurantPick.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantPickerController : ControllerBase
{
    [HttpGet]
    [Route("foodpicker/{userPick}")]

    public string restaurants(string userPick)
    {
        string[] mexican = new string[] { "La Estrella", "El Jardin Restaurant", "El Chappala", "Tepa Taqueria", "Taqueria El Azteca" };
        string[] thai = new string[] { "Spice it up!", "Royal Siam", "Chim", "Green Papaya", "Bangkok Restaurant" };
        string[] chinese = new string[] { "Kitty's Kitchen", "Bamboo Inn", "Lee's Restaurant", "Dragon Palace", "China Palace" };
        string[] indian = new string[] { "Maharaja", "Swagat", "Tandoori Grill", "Indian Cafe Restaurant", "India 4 U" };
        string[] american = new string[] { "Chilis", "AppleBees", "BJ's", "Denny's", "Red Robbin" };
        string[] randomPick = new string[] { "La Estrella", "El Jardin Restaurant", "El Chappala", "Tepa Taqueria", "Taqueria El Azteca", "Spice it up", "Royal Siam", "Chim", "Green Papaya", "Bangkok Restaurant", "Kitty's Kitchen", "Bamboo Inn", "Lee's Restaurant", "Dragon Palace", "China Palace", "Maharaja", "Swagat", "Tandoori Grill", "Indian Cafe Restaurant", "India 4 U", "Chilis", "AppleBees", "BJ's", "Denny's", "Red Robbin" };

        int index = 0;
        Random rand = new Random();

        if (userPick == "mexican")
        {
            index = rand.Next(mexican.Length);
            string mex = mexican[index];
            return $"Mexican food at {mex}!";
        }
        else if (userPick == "thai")
        {
            index = rand.Next(thai.Length);
            string tai = thai[index];
            return $"Thai food at {tai}!";
        }
        else if (userPick == "chinese")
        {
            index = rand.Next(chinese.Length);
            string china = chinese[index];
            return $"Chinese food at {china}!";
        }
        else if (userPick == "indian")
        {
            index = rand.Next(indian.Length);
            string indi = indian[index];
            return $"Indian food at {indi}!";
        }
        else if (userPick == "american")
        {
            index = rand.Next(american.Length);
            string amer = american[index];
            return $"American food at {amer}!";
        }
        else if (userPick == "random")
        {
            index = rand.Next(randomPick.Length);
            string randPick = randomPick[index];
            return $"Let's eat at {randPick}!";
        }
        else
        {
            return $"Please choose: Mexican | Thai | Chinese | American | Random";
        }
    }
}
