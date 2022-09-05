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
    [SerializeField] GameDataManager gameDataManager;


    private int correctResult = -1;
    private int score = 0;

    void Start()
    {
        GenerateQuestion();
    }

    private void GenerateQuestion ()
    {
        brainScript.GenerateQuiz();
        textQuestion.text = brainScript.GetQuestion();

        var results = brainScript.GetResults();
        correctResult = results[0];

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

        }
        else
        {
            //use life control
            lifeControl.RemoveLife();
            if (lifeControl.StillHasLife())
            {
                GenerateQuestion();
            }
            else
            {
                //display game over
                Debug.Log("===GAME OVER===");
                //gameOverPanel.SetActive(true);
                //gameOverPanel.GetComponent<GameOverControl>().SetScore(score);
                gameOverControl.gameObject.SetActive(true);
                gameOverControl.SetScore(score);

                gameDataManager.HighScore = score;
            }
        }

        
    }
  
}
