using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    private static UiManager _instance = new();
    public static UiManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<UiManager>();
            }
            return _instance;
        }
    }
    TPlayer _player;
    PlayerState _state;
    [SerializeField] private UIMainScrean _UIMainScrean;
    [SerializeField] private StateScrean _UIStateScrean;
    [SerializeField] private InventoryScrean _UIInventoryScrean;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        //±»ÀÌ?
        //else
        //{
        //    Destroy(gameObject);
        //}
    }

    private void Start()
    {
        _player = GameManager.Instance.CurrentPlayer;
        _state = _player.GetPlayerState;

        //_UIMainScrean.gameObject.SetActive(true);
        //_UIInventoryScrean.gameObject.SetActive(true);

    }


    public void SetActive_UIMainScrean()
    {

        if (_UIMainScrean.gameObject.activeInHierarchy)
        {
            _UIMainScrean.gameObject.SetActive(false);
        }
        else
        {
            _UIMainScrean.gameObject.SetActive(true);
        }

    }

    public void SetActive_StateScrean()
    {
        if (_UIStateScrean.gameObject.activeInHierarchy)
        {

            _UIStateScrean.gameObject.SetActive(false);
        }
        else
        {

            _UIStateScrean.gameObject.SetActive(true);
        }
    }
    public void SetActive_InventoryScrean()
    {
       

        // ÇöÀç »óÅÂ ·Î±ë
        Debug.Log($"Current inventory screen state: {_UIInventoryScrean.gameObject.activeInHierarchy}");
        if (_UIInventoryScrean.gameObject.activeInHierarchy)
        {

            _UIInventoryScrean.gameObject.SetActive(false);
        }
        else
        {

            _UIInventoryScrean.gameObject.SetActive(true);
        }
        // »óÅÂ º¯°æ ÈÄ ·Î±ë
        Debug.Log($"New inventory screen state: {_UIInventoryScrean.gameObject.activeInHierarchy}");
    }
















    private List<UiBase> _bases = new List<UiBase>();

    public T ShowPopup<T>() where T : UiBase
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
