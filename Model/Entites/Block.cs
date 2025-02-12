using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entites;
[Table("BLOCKS")]
public class Block
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("BLOCK_ID")]
    public int BlockId { get; set; }
}