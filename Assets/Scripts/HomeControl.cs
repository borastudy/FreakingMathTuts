using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeControl : MonoBehaviour
{
    [SerializeField] Text textScore;
    [SerializeField] GameDataManager gameDataManager;

    private void Start()
    {
        textScore.text = gameDataManager.HighScore.ToString();
    }

    public void ClickToGameScene ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
