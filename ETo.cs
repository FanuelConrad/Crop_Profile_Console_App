namespace Crop_Profile_Console_App
{
    class ETo
    {
        private double pvalue{get;set;}
        private double tmean{get;set;}
        private string month{get;set;}
        public ETo(string location, string cardinalPoint, string month)
        {
            string[] locationCoordinates=location.Split(',');
            int latitude =(int)decimal.Parse(locationCoordinates[0]);
            this.month=month;
            
            pValue pvalue =new pValue(latitude,cardinalPoint,month);
            this.pvalue=pvalue.GetPValue();

            Temperature temperature=new Temperature();
            tmean = temperature.GetAvgTemp(location);
        }

        public double GetETo()
        {
            double eto;
            eto = (pvalue * ((0.46 * tmean) + 8));
            
            return eto;

        }
    }
}