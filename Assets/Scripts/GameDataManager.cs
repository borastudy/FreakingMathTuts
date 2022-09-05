using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    public int HighScore { get; set; }

    private void Start()
    {
        Debug.Log("Game data manager started..");
    }
    private void OnDestroy()
    {
        Debug.Log("Game data manager ended..");
    }
}
