using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemState : State
{
    public ItemState(string name,int power, int defense, int health, int critical) : base(name,power, defense, health, critical)
    {

    }
}
