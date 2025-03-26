using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    weapon,
    armor,
    accessories
}
[System.Serializable]
public class Item 
{
    
    public string Name;
    
    public ItemType Type;
    
    public int str;
    public int def;
    public int health;
    public int cretical;
    //public ItemState ItemState;
    public Sprite icon;
    
}
