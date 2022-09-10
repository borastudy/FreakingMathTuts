using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    //public int HighScore { get; set; }
    public int HighScore
    {
        get
        {
            Debug.Log("Get HighScore");
            return PlayerPrefs.GetInt("my_last_high_score");
        }
        set
        {
            Debug.Log("Set HighScore");
            PlayerPrefs.SetInt("my_last_high_score", value);
        }

    }

    public static GameDataManager dataManager;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        dataManager = this;

        //PlayerPrefs.DeleteKey("my_last_high_score");
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
