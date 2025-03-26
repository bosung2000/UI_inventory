using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    public Item item;
    public int amount;
    public bool isEmpty =>item == null;

    public ItemSlot()
    {
        item= null;
        amount= 0;
    }

    public void AddItem(Item newItem, int count =1)
    {
        item = newItem;
        amount= count;
    }

    public void RemoveItem(int count =1)
    {
        amount -=count;
        if (amount <=0)
        {
            Clear();
        }
    }

    public void Clear()
    {
        item = null;
        amount = 0;
    }

}
