
namespace Crop_Profile_Console_App
{
    class Temperature
    {
        public double GetAvgTemp()
        {
            Result result = new Result();
            double[] avgTemp = new double[3];
            avgTemp[0] = result.GetResult().forecast.forecastday[0].day.avgtemp_c;
            avgTemp[1] = result.GetResult().forecast.forecastday[1].day.avgtemp_c;
            avgTemp[2] = result.GetResult().forecast.forecastday[2].day.avgtemp_c;

            double average = avgTemp.Average();
            return average;
        }

    }
}