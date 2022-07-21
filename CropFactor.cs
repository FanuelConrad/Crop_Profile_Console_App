using System;
using System.Globalization; // for lots of globalization types
using CsvHelper;
using CsvHelper.Configuration;

namespace Crop_Profile_Console_App
{
    public class CropFactor
    {
        public string crop { get; set; }
        public double initialStage { get; set; }
        public double cropDevelopmentStage { get; set; }
        public double midSeasonStage { get; set; }
        public double lateSeasonStage { get; set; } 

        public CropFactor()
        {
            
        }
        public CropFactor(string crop)
        {
            this.crop = crop;
        }

        public IEnumerable<CropFactor> GetCropFactor()
        {
            var reader = new StreamReader(@"C:\Users\Hp\Documents\GitHub\Crop_Profile_Console_App\CropFactor.csv");
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Context.RegisterClassMap<CropFactorMap>();
            var records = csv.GetRecords<CropFactor>();
            return records;
        }

        public double GetInitialStage()
        {
            return GetCropFactor().First(c => c.crop == crop).initialStage;  
        }
        public double GetCropDevelopmentStage()
        {
            return GetCropFactor().First(c => c.crop == crop).cropDevelopmentStage;  
        }
        public double GetMidSeasonStage()
        {
            return GetCropFactor().First(c => c.crop == crop).midSeasonStage;  
        }
        public double GetLateSeasonStage()
        {
            return GetCropFactor().First(c => c.crop == crop).lateSeasonStage;  
        }
    }

    public class CropFactorMap : ClassMap<CropFactor>
    {
        public CropFactorMap()
        {
            Map(m => m.crop).Index(0);
            Map(m => m.initialStage).Index(1);
            Map(m => m.cropDevelopmentStage).Index(2);
            Map(m => m.midSeasonStage).Index(3);
            Map(m => m.lateSeasonStage).Index(4);
        }
    }
}