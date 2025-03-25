using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPlayer : MonoBehaviour
{
    private PlayerState _playerState;
    public PlayerState GetPlayerState =>_playerState;

    private void Awake()
    {
        _playerState = new PlayerState(10, 5, 10, 15000, "Bosung", 30, 20, 100, 15);
    }
    private void Start()
    {
        
    }
    
    

}
