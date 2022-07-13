using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Crop_Profile_Console_App
{
    class mean_annual_percentage_of_daytime_hours
    {
        private float _latitude;
        private string _cardinalPoint;
        private string _month;
        private float _p;

        public mean_annual_percentage_of_daytime_hours(float latitude, string cardinalPoint, string month, float p)
        {
            this._latitude = latitude;
            this._cardinalPoint = cardinalPoint;
            this._month = month;
            this._p = p;
        }

        public void getPValue()
        {
            using (var streamReader = new StreamReader(@"C:\Users\Hp\Documents\GitHub\Crop_Profile_Console_App\pValue.csv"))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    var records = csvReader.GetRecords<dynamic>().ToList();
                }
            }
        }

    }
}