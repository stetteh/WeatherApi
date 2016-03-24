using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApi
{
    public enum LookupType
    {
        Zip,
        CityState,
    }

    public class WeatherManger
    {

        public WeatherInfo GetWeather(string userInput)
        {
            //determine which lookup to use
            LookupType lookupType = FigureOutLookupType(userInput);


            ILookup lookup = new WUGLookup();
            //determine if userINput is a zip or otherwise using regex
            //if it was a zip string then
            WeatherEvent result;

            switch (lookupType)
            {
                case LookupType.Zip:
                    result = lookup.GetByZip(userInput);
                    break;
                case LookupType.CityState:
                default:
                    result = lookup.GetByCityState(userInput);
                    break;
            }


            //map result to weatherinfo
            var info = new WeatherInfo();
            //info.Temp = result.CurrentObservations.Temperature + "° F";

            return info;
        }

        private LookupType FigureOutLookupType(string userInput)
        {
            //do regex check for zip here.
            throw new NotImplementedException();
        }
    }
}
