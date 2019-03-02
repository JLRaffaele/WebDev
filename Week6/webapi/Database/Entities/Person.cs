using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("person")]
public class Person
{
    [Column("person_id")]
    [Key]
    public long personId {get; set;}

    [Column("first_name")]
    public string first_name {get; set;}

    [Column("middle_name")]
    public decimal middle_name {get; set;}

    [Column("last_name")]
    public int last_name {get; set;}

    public Student Student { get; set; }
}