using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }

    private TPlayer _player;
    public TPlayer CurrentPlayer => _player;
    public List<ItemData> itemData;
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        //else
        //{
        //    Destroy(gameObject);
        //}
        _player = FindObjectOfType<TPlayer>();
    }


    private void Start()
    {
        
        //AddItemData();

        //AddItemDataUI();

        
    }

    public void Addinventory()
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            InventoryManager.Instance.AddinventoryItem(itemData[i]);
        }
    }

    public void Removeinventory()
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            InventoryManager.Instance.RemoveinventoryItem(itemData[i]);
        }
    }

    private void AddItemDataUI()
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            InventoryManager.Instance.AddItemSlot(itemData[i].Item);
        }
    }

    //private void AddItemData()
    //{
    //    for (int i = 0; i < itemData.Count; i++)
    //    {
    //        itemData.Add(itemData[i]);
    //    }
    //}
}
