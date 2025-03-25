using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPlayer : MonoBehaviour
{
    private PlayerState playerState;

    private void Start()
    {
        playerState = new PlayerState(10, 5, 10, 15000, 30, 20, 100, 15);
    }
    
    

}
