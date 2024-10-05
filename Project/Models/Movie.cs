using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }

        public required int Released { get; set; }

    }
}
