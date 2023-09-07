using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBarControl : MonoBehaviour
{
    [SerializeField] float durationPerQuestion = 10.0f;
    [SerializeField] Image imageTimerBar;
    [SerializeField] LifeControl lifeControl;
    [SerializeField] GameControl gameControl;

    private bool isTimeOut = false;

    float timeCounter;

    private void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {

        //timeCounter / 10 = 1;
        //9/10 = 0.9

        //0 / 10 = 0;

        //isTimeOut = false => !isTimeOut = true

        if (!isTimeOut)
        {
            timeCounter -= Time.deltaTime;

            var normalized = timeCounter / durationPerQuestion;

            //timeCounter = timeCounter + Time.deltaTime;

            Debug.Log("Delta time : " + Time.deltaTime);
            Debug.Log("Current count : " + timeCounter);
            Debug.Log("Normalized : " + normalized);

            imageTimerBar.fillAmount = normalized;

            if (normalized <= 0)
            {
                isTimeOut = true;
                //what happend?
                RemoveLifeAndResetTimer();
            }
        }
    }

    public void Reset()
    {
        timeCounter = durationPerQuestion;
        imageTimerBar.fillAmount = 1;
        isTimeOut = false;
    }

    public void Pause()
    {
        isTimeOut = true;
    }

    void RemoveLifeAndResetTimer ()
    {
        gameControl.ResetBonusLife();

        lifeControl.RemoveLife();
        //2 - 1 = 1
        //1 - 1 = 0

        if (lifeControl.StillHasLife())
        {
            Reset();
        }
        else
        {
            //Gameover
            Debug.Log("Gameover will appear");
            gameControl.ShowGameOver();
        }
    }
}
