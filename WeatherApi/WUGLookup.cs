using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApi
{
        public interface ILookup
        {
            WeatherEvent GetByCityState(string citystate);
            WeatherEvent GetByZip(string zip);
        }

        public class WUGLookup : ILookup
        {
            public WeatherEvent GetByCityState(string citystate)
            {
                //RESTSHARP CODE
                throw new NotImplementedException();
            }

            public WeatherEvent GetByZip(string zip)
            {
                //RESTSHARP CODE
                throw new NotImplementedException();
            }
        }
   
}
