using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    [SerializeField] Text textQuestion;
    [SerializeField] BrainScript brainScript;

    void Start()
    {
        brainScript.GenerateQuiz();
        textQuestion.text = brainScript.GetQuestion();
    }

    
}
