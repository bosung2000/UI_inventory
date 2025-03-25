using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public int id { get; set; }
    public string name { get; set; }



    public Item(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
}
