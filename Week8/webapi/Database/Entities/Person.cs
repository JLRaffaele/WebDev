using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    [Table("person")]
    public class Person
    {
        [Column("person_id")]
        [Key]
        public long personId {get; set;}

        [Column("first_name")]
        public string first_name {get; set;}

        [Column("middle_name")]
        public string middle_name {get; set;}

        [Column("last_name")]
        public string last_name {get; set;}

        public Student Student { get; set; }
    }

}