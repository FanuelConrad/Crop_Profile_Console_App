using System;
using System.Globalization; // for lots of globalization types
using CsvHelper;
using CsvHelper.Configuration;

namespace Crop_Profile_Console_App
{
    public class pValue
    {
        public int latitude { get; set; }
        public string cardinalPoint { get; set; }
        public string Month { get; set; }
        public double value { get; set; }
        Qwery qwery{get;set;}
        public pValue()
        {

        }

        public pValue(int lat, string cardinalPoint, string month)
        {
            this.latitude = lat;
            this.cardinalPoint = cardinalPoint;
            this.Month = month;
        }

        public class pValueCsvRowMap : ClassMap<pValue>
        {
            public pValueCsvRowMap()
            {
                Map(x => x.latitude).Index(0);
                Map(x => x.cardinalPoint).Index(1);
                Map(x => x.Month).Index(2);
                Map(x => x.value).Index(3);
            }
        }

        public double GetPValue()
        {
            var reader = new StreamReader(@"C:\Users\Hp\Documents\GitHub\Crop_Profile_Console_App\pValue.csv");
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            csv.Context.RegisterClassMap<pValueCsvRowMap>();
            var records = csv.GetRecords<pValue>();

            IEnumerable<pValue> query = records.Where(x => x.latitude == this.latitude && x.cardinalPoint == this.cardinalPoint && x.Month == this.Month);

            foreach (var item in query)
            {
                value = item.value;
            }
            return value;
        }
        
    }
}