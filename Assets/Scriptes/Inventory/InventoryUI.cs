using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private Transform slotsParent;
    [SerializeField] private GameObject slotPrefab;
    private List<InventorySlotUI> slotUIs = new List<InventorySlotUI>();

    private void Start()
    {
        InitializeUI();
        InventoryManager.Instance.OnInventoryChanged += UpdateUI;
    }

    private void InitializeUI()
    {
        // ½½·Ô UI »ý¼º
        for (int i = 0; i < InventoryManager.Instance.maxSlots; i++)
        {
            GameObject slotObj = Instantiate(slotPrefab, slotsParent);
            InventorySlotUI slotUI = slotObj.GetComponent<InventorySlotUI>();
            slotUIs.Add(slotUI);
        }
    }

    private void UpdateUI()
    {
        for (int i = 0; i < slotUIs.Count; i++)
        {
            if (i < InventoryManager.Instance.slots.Count)
            {
               slotUIs[i].UpdateSlot(InventoryManager.Instance.slots[i]);
            }
            else
            {
                slotUIs[i].RemoveSlot();
            }
        }
    }
}
