using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entites;

public class Entity : Item
{
    public Entity()
    {
        base.Type = EItemType.Entity;
    }

    [Column("DESCRIPTION"), MaxLength(350)] 
    public string? Description {get; set; }
    
}