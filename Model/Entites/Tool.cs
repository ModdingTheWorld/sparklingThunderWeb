using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Model.Entites;


public class Tool
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("TOOL_ID")]
    public int ToolId { get; set; }
    [Column("NAME"), MaxLength(20)] public string? Name { get; set; } = null;

}