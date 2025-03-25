using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopupPlayer : UiBase
{
    [SerializeField]private TextMeshProUGUI textLevel;
    [SerializeField]private TextMeshProUGUI textName;

    //private TPlayer _player;
    //private Action _onUpdate;
    protected override void Start()
    {
        base.Start();
    }
    //√÷±‚»≠
    //public void Initialize(TPlayer tplayer,Action onupdate =null)
    //{
    //    _player= tplayer;
    //    _onUpdate= onupdate;
    //    Refresh();

    //}
    //private void Refresh()
    //{
    //    textLevel.text = _player.level.ToString();
    //    textName.text = _player.name.ToString();

    //}
    public void OnInventory()
    {
        //UiManager.Instance.ShowPopup<popupinventory>
    }
}
