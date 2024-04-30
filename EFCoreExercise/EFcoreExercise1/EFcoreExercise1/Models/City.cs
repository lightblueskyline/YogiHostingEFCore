using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFcoreExercise1.Models
{
    [Table("TBL_City")]
    public class City
    {
        [Key]
        public int KeyId { get; set; }

        [Column("CityName", TypeName = "varchar(50)")]
        public string? Name { get; set; }

        [NotMapped]
        public int Population { get; set; }

        /// <summary>
        /// Foreign Key entity
        /// </summary>
        [ForeignKey("FKid")]
        public int CountryId { get; set; }

        /// <summary>
        /// Reference Navigation Property
        /// </summary>
        public Country? Country { get; set; }
    }
}
