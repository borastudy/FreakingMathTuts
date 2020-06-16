using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 enum MathOperator
 {
     PLUS,
     MINUS,
     MULTIPLY,
     DEVIDE
 }

public class BrainScript : MonoBehaviour
{
    private int operandA;
    private int operandB;
    private int correctResult;
    private int[] results;
    private string question;
    private MathOperator mathOperator;

    void Start ()
    {
        Debug.Log ("In function start!");
        GenerateQuiz();
    }

    public void GenerateQuiz ()
    {
        operandA = Random.Range (10, 50);
        operandB = Random.Range (10, 50);

        mathOperator = (MathOperator)Random.Range(0, 4);

        string sign = "";
        switch(mathOperator)
        {
            case MathOperator.PLUS:
            sign = "+";
            break;

            case MathOperator.MINUS:
            sign = "-";
            break;

            case MathOperator.MULTIPLY:
            sign = "*";
            break;

            case MathOperator.DEVIDE:
            sign = "/";
            break;
        }

        question = operandA + " " + sign + " " + operandB + " = ?";

        Debug.Log ("Question : " + question);

    }
}
