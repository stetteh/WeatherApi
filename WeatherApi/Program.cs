using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace WeatherApi
{
    class Program
    {
        static void Main(string[] args)
        {

            var mgr = new WeatherManager();
            var weatherInfo = mgr.GetWeather("72120");

            Console.WriteLine(weatherInfo.Temp);
            //var client = new RestClient("http://api.wunderground.com");
            //// client.Authenticator = new HttpBasicAuthenticator(username, password);

            //var request = new RestRequest("api/{apikey}/conditions/q/{state}/{city}.json", Method.GET);
            //request.AddUrlSegment("apikey", "1cad542395da4541"); // adds to POST or URL querystring based on Method
            //request.AddUrlSegment("city", "West Memphis"); // adds to POST or URL querystring based on Method
            //request.AddUrlSegment("state", "AR"); // adds to POST or URL querystring based on Method
            //                                      //request.AddParameter("id", "123"); // replaces matching token in request.Resource

            //var request2 = new RestRequest("api/{apikey}/conditions/q/{zipcode}.json", Method.GET);
            //request2.AddUrlSegment("apikey", "1cad542395da4541"); // adds to POST or URL querystring based on Method
            //request2.AddUrlSegment("zipcode", Console.ReadLine()); // adds to POST or URL querystring based on Method

            ////execute the request
            //var response = client.Execute<List<WeatherEvent>>(request);
            //List<WeatherEvent> events = response.Data; // raw content as string



            ////Console.WriteLine("Please enter your zipcode");
            ////string input = Console.ReadLine();
            ////int userinput = Convert.ToInt32(input);


            //if (userinput == 72223)
            //{
            //    foreach (var e in events)
            //    {
            //        Console.WriteLine($" {e.current_observation.display_location.city} {e.current_observation.temp_f}");
            //    }            
            //}
            //else
            //{
            //    Console.WriteLine("Zip code Not known");
            //}


            Console.ReadLine();
        }
    }




}

