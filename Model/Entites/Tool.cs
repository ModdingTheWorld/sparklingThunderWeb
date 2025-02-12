using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entites;

[Table("TOOLS")]
public class Tool
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("TOOL_ID")]
    public int ToolId { get; set; }
}