using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiBase : MonoBehaviour
{
    protected virtual void Awake()
    {

    }
    protected virtual void Start()
    {
        PlayShowAnimation();
    }

    protected void PlayShowAnimation()
    {
        transform.localScale = Vector3.one * 0.8f;
        transform.DOScale(Vector3.one, 0.52f).SetEase(Ease.OutBack);
    }
    protected void PlayClick(int index = 1)
    {

    }

    public virtual void Hide()
    {
        Destroy(gameObject);
    }
    public virtual void OnCancel()
    {
        Hide();
    }
    public virtual void OnOK()
    {
        Hide();
    }
}
