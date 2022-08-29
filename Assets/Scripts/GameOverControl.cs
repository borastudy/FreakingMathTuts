using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverControl : MonoBehaviour
{
    [SerializeField] Text textScore;
    [SerializeField] LifeControl lifeControl;

    public void SetScore(int score)
    {
        textScore.text = score.ToString();
    }

    public void ClickToContinue ()
    {
        Debug.Log("Clicked Button continue");
        gameObject.SetActive(false);
        lifeControl.ResetLife();
    }
}
