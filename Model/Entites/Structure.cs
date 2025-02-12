using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entites;

[Table("STRUCTURES")]
public class Structure
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("STRUCTURE_ID")]
    public int StructureId { get; set; }
}