using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIHUD : MonoBehaviour
{
    [SerializeField] private GameObject objMenu;
    private bool isMove = false;

    private void Start()
    {
        //var popup=UiManager.Instance.ShowPopup<PopupPlayer>();
        //popup.Initialize(new TPlayer(),OnUpgrade);
    }

    public void OnUpgrade()
    {

    }
    public void OnMenu()
    {
        if (isMove == false)
        {
            isMove = true;
            if (objMenu.activeSelf == false)
            {
                objMenu.SetActive(true);
                objMenu.transform.DOLocalMoveY(objMenu.transform.localPosition.y - 500f, 0.5f).SetEase(Ease.OutCubic).OnComplete(() =>
                    {
                        isMove = false;
                    });
            }
            else
            {
                objMenu.transform.DOLocalMoveY(objMenu.transform.localPosition.y + 500f, 0.5f).SetEase(Ease.OutCubic).OnComplete(() =>
                {
                    isMove = false;
                    objMenu.SetActive(false);
                }); ;
            }
        }
    }

    public void MainScrean()
    {

    }

}
