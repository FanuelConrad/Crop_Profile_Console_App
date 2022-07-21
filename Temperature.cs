
namespace Crop_Profile_Console_App
{
    class Temperature
    {

        public Temperature()
        {
            
        }
        public double GetAvgTemp(string location)
        {
            Result result = new Result(/*location*/);
            double[] avgTemp = new double[3];
            avgTemp[0] = result.GetResult(location).forecast.forecastday[0].day.avgtemp_c;
            avgTemp[1] = result.GetResult(location).forecast.forecastday[1].day.avgtemp_c;
            avgTemp[2] = result.GetResult(location).forecast.forecastday[2].day.avgtemp_c;

            double average = avgTemp.Average();
            return average;
        }

    }
}