using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entites;

public class Block
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("BLOCK_ID")]
    public int BlockId { get; set; }
    [Column("NAME"), MaxLength(20)] public string? Name { get; set; } = null;

}