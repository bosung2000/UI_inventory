using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class InventoryManager : MonoBehaviour
{
    private static InventoryManager _instance;
    public static InventoryManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<InventoryManager>();
            }
            return _instance;
        }
    }

    public int maxSlots = 16;
    public List<ItemSlot> slots;

    public event Action OnInventoryChanged;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            InitInventory();
            DontDestroyOnLoad(gameObject);
        }
        //else
        //{
        //    Destroy(gameObject);
        //}
    }

    private void InitInventory()
    {
        slots = new List<ItemSlot>();
        for (int i = 0; i < maxSlots; i++)
        {
            slots.Add(new ItemSlot());
        }
    }

    public bool AddItem(Item item,int amount =1)
    {
        var emptySlot = slots.Find(slot => slot.isEmpty);
        if (emptySlot == null)
        {
            emptySlot.AddItem(item,amount);
            OnInventoryChanged?.Invoke(); //변경 이벤트 호출 
            return true;
        }

        return false; // 가득 참 

    }
}
