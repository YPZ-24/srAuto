namespace SrAuto.Models
{

    public class Notification
    {
        public int NotificationID  { get; set; }
        public int ClientID { get; set; }
        public int SubjectID { get; set; }
        public string description { get; set; }
        public int status { get; set; }
        public virtual Subject Subject { get; set; }
    }
}