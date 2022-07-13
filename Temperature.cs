using System.Text.Json;
using System.Text.Json.Serialization;
using RestSharp;

namespace Crop_Profile_Console_App
{
    class Temperature : Day
    {
        public float maxtemp_c { get; set; }
        private float[] _tempMax;
        private float[] _tempMin;
        private int _numberOfDays = 3;
        private float _tempMean;
        private float _tempMaxSum;
        private float _tempMinSum;
        private float _tempMaxMean;
        private float _tempMinMean;

        /*public temperature(float[] tempMax, float[] tempMin, int numberOfDays, float tempMean, float tempMaxSum, float tempMinSum)
        {
            this._tempMax = tempMax;
            this._tempMin = tempMin;
            this._numberOfDays = numberOfDays;
            this._tempMean = tempMean;
            this._tempMaxSum = tempMaxSum;
            this._tempMinSum = tempMinSum;
        }*/

        public float GetSumOfTmax(float[] tempMax)
        {
            this._tempMaxSum = tempMax.Sum();
            return _tempMaxSum;
        }

        public float GetSumOfTmin(float[] tempMin)
        {
            this._tempMinSum = tempMin.Sum();
            return this._tempMinSum;
        }

        public float GetTmaxMean(float tempMaxSum, int numberOfDays)
        {
            this._tempMaxMean = tempMaxSum / numberOfDays;
            return this._tempMaxMean;
        }

        public float GetTminMean(float tempMinSum, int numberOfDays)
        {
            this._tempMinMean = tempMinSum / numberOfDays;
            return this._tempMinMean;
        }

        public void GetTmean()
        {
            
            Result result=new Result();
            
            Console.WriteLine(result.GetWeatherForecast().forecast.forecastday[0].day.avgtemp_c);

            //this._tempMean=(tempMaxMean + tempMinMean)/2;
            //return this._tempMean;
           
            //Console.WriteLine( GetWeatherForecast());
           // Console.WriteLine(result.forecast.forecastday[0].day.avgtemp_c);
           // Console.WriteLine(result.forecast.forecastday[1].day.avgtemp_c);
            //Console.WriteLine(result.forecast.forecastday[2].day.avgtemp_c);

        }
    }
}