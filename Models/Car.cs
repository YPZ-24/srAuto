namespace SrAuto.Models
{

    public class Car
    {
        public int CarID  { get; set; }
        public string carTag { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string photoUrl { get; set; }
        public int ClientID  { get; set; }
        public int status { get; set; }

        public virtual Client Client { get; set; }
    }
}