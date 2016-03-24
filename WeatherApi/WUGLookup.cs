using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace WeatherApi
{
    public interface ILookup
    {
        WeatherInfo GetByCityState(string citystate);
        WeatherInfo GetByZip(string zip);
    }

    public class WUGLookup : ILookup
    {
        public WeatherInfo GetByCityState(string citystate)
        {
            //RESTSHARP CODE
            var client = new RestClient("http://api.wunderground.com");
            var request = new RestRequest("api/{apikey}/conditions/q/{state}/{city}.json", Method.GET);
            request.AddUrlSegment("apikey", "1cad542395da4541"); // adds to POST or URL querystring based on Method

            var response = client.Execute<List<WeatherEvent>>(request);
            List<WeatherEvent> events = response.Data; // raw content as string


            return null;
        }

        public WeatherInfo GetByZip(string zip)
        {
            //RESTSHARP CODE
            var client = new RestClient("http://api.wunderground.com");
            var request2 = new RestRequest("api/{apikey}/conditions/q/{zipcode}.json", Method.GET);
            request2.AddUrlSegment("apikey", "1cad542395da4541"); // adds to POST or URL querystring based on Method
            request2.AddUrlSegment("zipcode", zip); // adds to POST or URL querystring based on Method

            var response = client.Execute<WeatherEvent>(request2);
            WeatherEvent weatherEvent = response.Data; // raw content as string


            //map result to weatherinfo
            var info = new WeatherInfo();
            info.Temp = weatherEvent.current_observation.temp_f + "° F";
            info.City = weatherEvent.current_observation.display_location.city;
            info.State = weatherEvent.current_observation.display_location.state;

            return info;

        }
    }

}
