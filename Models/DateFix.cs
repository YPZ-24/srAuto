namespace SrAuto.Models
{

    public class DateFix
    {
        public int DateFixID  { get; set; }
        public int FixID  { get; set; }
        public int DateID  { get; set; }
        public double extraCost { get; set; }

        public virtual Fix Fix { get; set; }
        public virtual Date Date { get; set; }
    }
}