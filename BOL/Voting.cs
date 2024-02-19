using System.ComponentModel.DataAnnotations;

namespace BOL
{
    internal class Voting
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Age { get; set; }

    }
}
