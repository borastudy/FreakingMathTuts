using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeControl : MonoBehaviour
{
    [SerializeField] Text textScore;
    private GameDataManager gameDataManager;

    private void Start()
    {
        gameDataManager = GameDataManager.dataManager;
        textScore.text = gameDataManager.HighScore.ToString();
    }

    public void ClickToGameScene ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
}
