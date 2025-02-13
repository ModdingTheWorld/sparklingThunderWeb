using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entites;


public class Tool : Item
{
    public Tool()
    {
        Type = EItemType.Tool;
    }
}