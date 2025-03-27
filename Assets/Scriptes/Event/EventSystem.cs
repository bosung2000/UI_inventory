using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    // ���� ���� ���� �̺�Ʈ
    public event Action onGameStart;
    public event Action onGameOver;

    //UI �̺�Ʈ
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
        //�÷��̰� ������ ���� ���� �̺�Ʈ �߻�
        onPlayerDeath += () => onGameOver?.Invoke();

        //���� ���� �� �ĸ��� ���� 
        onGameOver += () =>
        {
            Debug.Log("Game OVer");
        };

        //�޼ҵ� ���
        onGameOver += init;
    }

    private void init()
    {
        Debug.Log("���� ����� ������ �ʱ�ȭ ");
    }
}
