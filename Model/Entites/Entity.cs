

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entites;

public class Entity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ENTITY_ID")]
    public int EntityId { get; set; }
    [Column("NAME"), MaxLength(20)] public string? Name { get; set; } = null;

    
    [Column("DESCRIPTION"), MaxLength(350)] 
    public string? Description {get; set; }
    
    
}