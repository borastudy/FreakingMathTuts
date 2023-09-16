using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    [SerializeField] Text textScore;
    [SerializeField] Text textQuestion;
    [SerializeField] BrainScript brainScript;
    [SerializeField] LifeControl lifeControl;

    [SerializeField] Text textAnswer1;
    [SerializeField] Text textAnswer2;
    [SerializeField] Text textAnswer3;
    [SerializeField] Text textAnswer4;

    [SerializeField] GameOverControl gameOverControl;
    [SerializeField] TimerBarControl timerBarControl;
    [SerializeField] Image imageBonusLife;

    private GameDataManager gameDataManager;


    private int correctResult = -1;
    private int score = 0;

    private int countCorrect = 0;

    void Start()
    {
        GenerateQuestion();
        gameDataManager = GameDataManager.dataManager;

        imageBonusLife.fillAmount = 0;
    }

    private void GenerateQuestion ()
    {
        brainScript.GenerateQuiz();
        textQuestion.text = brainScript.GetQuestion();

        var results = brainScript.GetResults();
        correctResult = brainScript.GetCorrectResult();

        textAnswer1.text = results[0].ToString();
        textAnswer2.text = results[1].ToString();
        textAnswer3.text = results[2].ToString();
        textAnswer4.text = results[3].ToString();
    }

    public void HandleClick (int index)
    {
        Debug.Log("You click me : " + index);
        var results = brainScript.GetResults();
        var chosenNumber = results[index];
        Debug.Log("Number : " + chosenNumber);

        if (chosenNumber == correctResult)
        {
            //increase score
            score = score + 1;
            textScore.text = score.ToString();
            GenerateQuestion();
            Debug.Log("Score : " + score);

            countCorrect++;
            if(countCorrect == 10)
            {
                lifeControl.AddLife();
                countCorrect = 0;
            }

        }
        else
        {
            countCorrect = 0;

            //use life control
            lifeControl.RemoveLife();
            if (lifeControl.StillHasLife())
            {
                GenerateQuestion();
            }
            else
            {
                ShowGameOver();
                timerBarControl.Pause();
            }
        }

        if (lifeControl.StillHasLife())
        {
            //call to reset timerbar
            timerBarControl.Reset();
        }

        imageBonusLife.fillAmount = countCorrect / 10.0f;
    }

    public void ResetBonusLife()
    {
        countCorrect = 0;
        imageBonusLife.fillAmount = countCorrect / 10.0f;
    }

    public void ShowGameOver ()
    {
        //display game over
        Debug.Log("===GAME OVER===");
        //gameOverPanel.SetActive(true);
        //gameOverPanel.GetComponent<GameOverControl>().SetScore(score);
        gameOverControl.gameObject.SetActive(true);
        gameOverControl.SetScore(score);

        if (score > gameDataManager.HighScore)
        {
            //keep new highscore
            gameDataManager.HighScore = score;
        }
    }
  
}//class
