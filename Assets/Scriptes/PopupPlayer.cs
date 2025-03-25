using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopupPlayer : UiBase
{
    [SerializeField]private TextMeshProUGUI textLevel;
    [SerializeField]private TextMeshProUGUI textName;

    private int _id;
    private string _name;

    protected override void Start()
    {
        base.Start();
    }
    //√÷±‚»≠
    public void Initialize(List<Item> item)
    {
        _id = item.;
        _name = name;

        Refresh();
    }
    private void Refresh()
    {

    }
}
