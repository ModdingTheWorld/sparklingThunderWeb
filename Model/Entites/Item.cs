using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Model.Entites;
[Table("ITEMS")]
public class Item
{
    public Item()
    {
        Type = EItemType.BaseItem;
    }
    public Item(EItemType type)
    {
        Type = type;
    }
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ITEM_ID")]
    public int ItemId { get; set; }
    
    [Column("TYPE")] public EItemType Type { get; set; }
    [Column("NAME"), MaxLength(20)] public string? Name { get; set; } = null;

}
public enum EItemType
{
    Block, Entity, Tool, Weapon, BaseItem
}