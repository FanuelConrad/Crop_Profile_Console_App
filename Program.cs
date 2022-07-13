using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestSharp;

namespace Crop_Profile_Console_App
{
    

    class Program
    {
        static void Main(string[] args)
        {
            //Temperature.GetTmean();
            Temperature temperature=new Temperature();
            temperature.GetTmean();
            //WeatherForecast weatherForecast=new WeatherForecast();
            //weatherForecast.GetWeatherForecast();
        }
    }
}