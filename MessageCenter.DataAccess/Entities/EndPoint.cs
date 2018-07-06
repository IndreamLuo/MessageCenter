namespace MessageCenter.DataAccess.Entities
{
    public class EndPoint
    {
        public virtual int Id { get; set; }
        public virtual int Key { get; set; }
        public virtual string Name { get; set; }
        public virtual string Comment { get; set; }
    }
}