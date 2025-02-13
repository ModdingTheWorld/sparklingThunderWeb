using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entites;

public class Block : Item
{
    public Block()
    {
        Type = EItemType.Block;
    }
}