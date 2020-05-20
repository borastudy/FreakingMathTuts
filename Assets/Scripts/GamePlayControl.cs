using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GamePlayControl : MonoBehaviour
{
    [SerializeField] BrainScript brain;
    [SerializeField] UnityEngine.UI.Text textQuestion;
    [SerializeField] UnityEngine.UI.Text[] textAnswers;
    

    void Start()
    {
        RefreshQuiz ();
    }

    void RefreshQuiz ()
    {
        brain.GenerateQuiz();
        textQuestion.text = brain.question;
        textAnswers[0].text = brain.results[0].ToString();
        textAnswers[1].text = brain.results[1].ToString();
        textAnswers[2].text = brain.results[2].ToString();
        textAnswers[3].text = brain.results[3].ToString();
        textQuestion.text = brain.question;
    }

    public void AnswerClicked (int buttonIndex)
    {
        float answerFromPlayer = brain.results[buttonIndex];

        if (answerFromPlayer == brain.correctResult)
        {
            Debug.Log("Correct !!");
        }
        else
        {
            Debug.Log("Wrong !!");
        }

        RefreshQuiz();
    }

}
