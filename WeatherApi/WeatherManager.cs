using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WeatherApi
{
    public enum LookupType
    {
        Zip,
        CityState,
    }

    public class WeatherManager
    {

        public WeatherInfo GetWeather(string userInput)
        {
            //determine which lookup to use
            LookupType lookupType = FigureOutLookupType(userInput);


            ILookup lookup = new WUGLookup();
            //determine if userINput is a zip or otherwise using regex
            //if it was a zip string then
            WeatherInfo result;

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


            return result;
        }

        public LookupType FigureOutLookupType(string userInput)
        {
            //do regex check for zip here.
            string pattern = @"^\d{5}(\-\d{4})?";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(userInput))
            {
                return LookupType.Zip;
            }
            else
            {
                return LookupType.CityState;
            }

        }
    }
}
