using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance ==null)
            {
                _instance= FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }

    private TPlayer _player;
    public TPlayer CurrentPlayer => _player;

    private void Awake()
    {
        if (_instance ==null)
        {
            _instance= this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    private void Start()
    {
        _player =FindObjectOfType<TPlayer>();
    }

}
