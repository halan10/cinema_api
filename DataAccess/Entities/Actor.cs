using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Actor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string Place_of_birth { get; set; }
    }
}
