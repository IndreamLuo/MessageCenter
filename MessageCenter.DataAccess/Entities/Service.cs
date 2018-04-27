namespace MessageCenter.DataAccess.Entities
{
    public class Service
    {
        public virtual ServiceType Type { get; set; }
        public virtual string Url { get; set; }
    }
}