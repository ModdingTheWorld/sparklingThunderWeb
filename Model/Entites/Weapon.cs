﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entites;


public class Weapon : Item
{
    public Weapon()
    {
        Type = EItemType.Weapon;
    }
}