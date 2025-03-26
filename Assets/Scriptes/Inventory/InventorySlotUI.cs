using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotUI : MonoBehaviour
{
    [SerializeField] private Image iconImage;
    [SerializeField] private Button slotButton;

    public void UpdateSlot(ItemSlot slot)
    {
        if (!slot.isEmpty)
        {
            iconImage.sprite = slot.item.icon;
            iconImage.enabled = true;                        
        }
        else
        {
            iconImage.enabled = false;
        }
    }

    private void Start()
    {
        slotButton.onClick.AddListener(OnSlotClick);
    }

    private void OnSlotClick()
    {
        // 클릭 처리 (아이템 사용, 장비 등)
    }
}
