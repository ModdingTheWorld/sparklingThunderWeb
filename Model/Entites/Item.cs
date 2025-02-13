using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Model.Configurations;

namespace Model.Entites;
[Table("ITEMS")]
public class Item
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ITEM_ID")]
    public int ItemId { get; set; }
    
    [Column("ITEM_TYPE")]
    public ItemType ItemType { get; set; }

    [Column("NAME"), MaxLength(20)] public string? Name { get; set; } = null;
}
