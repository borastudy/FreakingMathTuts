using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverControl : MonoBehaviour
{
    [SerializeField] Text textScore;
    [SerializeField] LifeControl lifeControl;
    [SerializeField] TimerBarControl timerBarControl;

    public void SetScore(int score)
    {
        textScore.text = score.ToString();
    }

    public void ClickToContinue ()
    {
        Debug.Log("Clicked Button continue");
        gameObject.SetActive(false);
        lifeControl.ResetLife();
        timerBarControl.Reset();
    }

    public void ClickNoThankYou ()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
