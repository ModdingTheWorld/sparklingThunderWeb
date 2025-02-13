using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entites;
[Table("ITEM_TYPE")]
public abstract class ItemType
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ITEM_TYPE_ID")]
    public int ItemTypeId { get; set; }
    [Column("NAME"), MaxLength(20)] public string? Name { get; set; }
}