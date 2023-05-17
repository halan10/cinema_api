namespace Data.Entities
{
    public class Session
    {
        public int Id { get; set; }
        public string Film_name { get; set; }
        public double Film_raiting { get; set; }
        public string Description { get;set; }
        public double Price { get; set; }
        public DateTime Next_session { get; set; }

    }
}
