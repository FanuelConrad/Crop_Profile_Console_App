using System;
using System.Globalization; // for lots of globalization types
using CsvHelper;
using CsvHelper.Configuration;


namespace Crop_Profile_Console_App
{
    public class GrowthStages
    {
        public string crop { get; set; }
        public int totalGrowingPeriod { get; set; }
        public int initialStage { get; set; }
        public int cropDevelopmentStage { get; set; }
        public int midSeasonStage { get; set; }
        public int lateSeasonStage { get; set; }

        public GrowthStages()
        {

        }

        public GrowthStages(string crop)
        {
            this.crop = crop;
        }

        public IEnumerable<GrowthStages> GetGrowthStages()
        {
            GrowthStages result;
            var reader = new StreamReader(@"C:\Users\Hp\Documents\GitHub\Crop_Profile_Console_App\GrowthStages.csv");
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Context.RegisterClassMap<GrowthStagesMap>();
            var records = csv.GetRecords<GrowthStages>();
            return records;
        }

        public double GetInitialStage()
        {
            return GetGrowthStages().First(c => c.crop == crop).initialStage;  
        }
        public double GetCropDevelopmentStage()
        {
            return GetGrowthStages().First(c => c.crop == crop).cropDevelopmentStage;  
        }
        public double GetMidSeasonStage()
        {
            return GetGrowthStages().First(c => c.crop == crop).midSeasonStage;  
        }
        public double GetLateSeasonStage()
        {
            return GetGrowthStages().First(c => c.crop == crop).lateSeasonStage;  
        }
    }


    public class GrowthStagesMap : ClassMap<GrowthStages>
    {
        public GrowthStagesMap()
        {
            Map(m => m.crop).Index(0);
            Map(m => m.totalGrowingPeriod).Index(1);
            Map(m => m.initialStage).Index(2);
            Map(m => m.cropDevelopmentStage).Index(3);
            Map(m => m.midSeasonStage).Index(4);
            Map(m => m.lateSeasonStage).Index(5);
        }
    }
}