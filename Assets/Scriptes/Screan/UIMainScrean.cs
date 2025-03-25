using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainScrean : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Charatername;
    [SerializeField] private TextMeshProUGUI _Lv;
    [SerializeField] private Image _Lv_Exp;
    [SerializeField] private TextMeshProUGUI _Exp_text;
    [SerializeField] private float animationSpeed = 2f;
    private TPlayer _player;
    private PlayerState PlayerState;
    private float targetFillAmount;

    private void Start()
    {
        _player = GameManager.Instance.CurrentPlayer;
        PlayerState = _player.GetPlayerState;
        Init(PlayerState.name,PlayerState.Lv,PlayerState.CurrentExp,PlayerState.MaxExp);
    }
    private void Init(string name, int LV, int exp, int maxexp)
    {
        Charatername.text = name;
        _Lv.text = $"LV : {LV.ToString()}";
        UpdateExpBar(_player.GetPlayerState.CurrentExp,_player.GetPlayerState.MaxExp); 
    }

    public void UpdateExpBar(int currentExp,int maxExp)
    {
        targetFillAmount = (float)currentExp / maxExp;
        StartCoroutine(AnimaterFillAmount());
        _Exp_text.text = $"{currentExp}/{maxExp}";
    }

    private IEnumerator AnimaterFillAmount()
    {
        float currentFill = _Lv_Exp.fillAmount;
        while (Mathf.Abs(currentFill-targetFillAmount) >0.01f)
        {
            currentFill = Mathf.Lerp(currentFill, targetFillAmount, Time.deltaTime * animationSpeed);
            _Lv_Exp.fillAmount =currentFill;
            yield return null;
        }
        _Lv_Exp.fillAmount = targetFillAmount;
    }
}
