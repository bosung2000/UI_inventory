using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    private static UiManager _instance = new();
    public static UiManager Instance { get { return _instance; } }

    private List<UiBase> _bases = new List<UiBase>();

    public T ShowPopup<T>() where T :UiBase
    {
        return ShowPopup(typeof(T).Name) as T;
    }


    public UiBase ShowPopup(string Name)
    {
        var obj = Resources.Load($"Popups/{Name}", typeof(GameObject)) as GameObject;

        if (obj == null)
        {
            Debug.LogWarning($"Failed to ShowPopup({Name})");
            return null;
        }
        return ShowPopupWithPrefab(obj);
    }

    private UiBase ShowPopupWithPrefab(GameObject prefab)
    {
        var obj = Instantiate(prefab, GameObject.Find("Canvas").transform);
        return ShowPopup(obj);
    }

    private UiBase ShowPopup(GameObject obj)
    {
        var popup = obj.GetComponent<UiBase>();
        _bases.Insert(0, popup);
        obj.SetActive(true);
        return popup;
    }
       

}
