using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Model.Entites;
[Table("ITEMS")]
public class Item
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ITEM_ID")]
    public int ItemId { get; set; }
}