
using Newtonsoft.Json.Linq;

var client1 = new HttpClient();
var client2 = new HttpClient();

var kanyeURL = "https://api.kanye.rest/";
var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

for (int i = 0; i <5; i++)
{
    var kanyeResponse = client1.GetStringAsync(kanyeURL).Result;
    var ronResponse = client2.GetStringAsync(ronURL).Result;

    var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
    var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

    Console.WriteLine($"Yeezy: {kanyeQuote}");
    Console.WriteLine($"Ron: {ronQuote}");
    Console.WriteLine();
}
