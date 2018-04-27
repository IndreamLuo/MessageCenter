namespace MessageCenter.DataAccess.Entities
{
    public enum ServiceType
    {
        Null = 0b0000_0000_0000_0000,
        Json = 0b0000_0000_0000_0001,
        Xml = 0b0000_0000_0000_0010,
        Http = 0b0001_0000_0000_0000,
        HttpGet = 0b0001_0000_0001_0000,
        HttpPost = 0b0001_0000_0010_0000,
        HttpPut = 0b0001_0000_0100_0000,
        HttpDelete = 0b0001_0000_1000_0000,
    }
}