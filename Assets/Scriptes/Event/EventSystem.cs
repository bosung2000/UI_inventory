using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    // 게임 상태 관련 이벤트
    public event Action onGameStart;
    public event Action onGameOver;

    //UI 이벤트
    public event Action onUIUpdate;

    private void Start()
    {
        onGameStart += () => onUIUpdate?.Invoke();

        onGameOver += () => onUIUpdate?.Invoke();
    }

}

public class GameSystem : MonoBehaviour
{
    public event Action onPlayerDeath;
    public event Action onGameOver;

    private void Start()
    {
        //플레이가 죽으면 게임 오버 이벤트 발생
        onPlayerDeath += () => onGameOver?.Invoke();

        //게임 오버 시 쳐리할 내용 
        onGameOver += () =>
        {
            Debug.Log("Game OVer");
        };

        //메소드 사용
        onGameOver += init;
    }

    private void init()
    {
        Debug.Log("게임 종료시 데이터 초기화 ");
    }
}
