using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFcoreExercise1.Models
{
    [Table("TBL_Country")]
    public class Country
    {
        [Key]

        public int KeyId { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }

        /// <summary>
        /// Collection Navigation Property
        /// </summary>
        public ICollection<City>? Cities { get; set; }
    }
}
