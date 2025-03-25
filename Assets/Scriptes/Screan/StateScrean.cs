using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StateScrean : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txt_Power;
    [SerializeField] private TextMeshProUGUI txt_def;
    [SerializeField] private TextMeshProUGUI txt_health;
    [SerializeField] private TextMeshProUGUI txt_critical;

    private PlayerState playerState;
    private void Start()
    {
        playerState=GameManager.Instance.CurrentPlayer.GetPlayerState;
        init(playerState.Power,playerState.Defense,playerState.health,playerState.critical);
    }


    private void init(int power,int def,int health,int critical)
    {
        txt_Power.text =$"str : {power.ToString()}";
        txt_def.text = $"def : {def.ToString()}";
        txt_health.text = $"health : {health.ToString()}";
        txt_critical.text = $"critical : {critical.ToString()}";
    }


}
