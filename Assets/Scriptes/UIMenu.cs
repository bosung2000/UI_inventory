using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenu : MonoBehaviour
{
    public void ONMainScrean()
    {
        Debug.Log("Is Main Screan");
        UiManager.Instance.SetActive_UIMainScrean();
    }
    public void OnStatus()
    {
        Debug.Log("Is Status Screan");
        UiManager.Instance.SetActive_UIMainScrean();
        UiManager.Instance.SetActive_StateScrean();
        
    }
    public void OnInventory()
    {
        Debug.Log("Is Inventory");
        UiManager.Instance.SetActive_UIMainScrean();
        UiManager.Instance.SetActive_InventoryScrean();
    }
}
