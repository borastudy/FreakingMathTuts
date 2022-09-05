using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    public int HighScore { get; set; }

    public static GameDataManager dataManager;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        dataManager = this;
    }

    private void Start()
    {
        Debug.Log("Game data manager started..");
    }
    private void OnDestroy()
    {
        Debug.Log("Game data manager ended..");
    }
}
