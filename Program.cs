using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestSharp;
using CsvHelper;
using CsvHelper.Configuration;

namespace Crop_Profile_Console_App
{


    class Program
    {
        static void Main(string[] args)
        {
            //Temperature.GetTmean();
            //Temperature temperature = new Temperature();
            //temperature.GetTmean();
            // Result result = new Result();
            //result.GetResult();
            //double temp = temperature.GetAvgTemp();
            //System.Console.WriteLine(temp);

            //pValue pvalue = new pValue(60,"North","Jan");
            //pvalue.GetPValue();

            //ETo eTo = new ETo("0.5182,35.2717", "North", "April");
            //System.Console.WriteLine(eTo.GetETo());

            GrowthStages growthStages=new GrowthStages("Cabbage");
            System.Console.WriteLine(growthStages.GetInitialStage());
        }
    }
}