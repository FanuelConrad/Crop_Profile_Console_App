namespace Crop_Profile_Console_App
{
    class Qwery
    {
        private string _locationCoordinates{get;set;}
        private string _cardinalPoint{get;set;}
        private string _month{get;set;}
        private int latitude{get;set;}
        private int longitude{get;set;}

        public Qwery(string locationCoordinates,string cardinalPoint,string month)
        {
            this._locationCoordinates=locationCoordinates;
            this._cardinalPoint=cardinalPoint;
            this._month=month;
        }

        public int GetLatitude()
        {
            string[] locationCoordinates=_locationCoordinates.Split(',');
            latitude =Convert.ToInt32(locationCoordinates[0]);

            return latitude;
        }

    }
}