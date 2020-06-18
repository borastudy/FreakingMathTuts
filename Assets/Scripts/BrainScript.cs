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

        mathOperator = (MathOperator)Random.Range(0, 3);

        string sign = "";
        switch(mathOperator)
        {
            case MathOperator.PLUS:
            correctResult = operandA + operandB;
            sign = "+";
            break;

            case MathOperator.MINUS:
            correctResult = operandA - operandB;
            sign = "-";
            break;

            case MathOperator.MULTIPLY:
            correctResult = operandA * operandB;
            sign = "*";
            break;

            case MathOperator.DEVIDE:
            correctResult = operandA / operandB;
            sign = "/";
            break;
        }

        question = operandA + " " + sign + " " + operandB + " = ?";

        Debug.Log ("Question : " + question);
        Debug.Log ("Correct result : " + correctResult);

        results = new int[4];
        results[0] = correctResult;

        GenerateFakeResults ();

        Debug.Log("Answer 1: " + results[0]);
        Debug.Log("Answer 2: " + results[1]);
        Debug.Log("Answer 3: " + results[2]);
        Debug.Log("Answer 4: " + results[3]);
    }

    private void GenerateFakeResults ()
    {
        int fake1 = Random.Range (results[0]+1, 11);
        int fake2 = Random.Range (results[0]-10, results[0]);
        int fake3 = Random.Range (results[0]+11, 21);

        results[1] = fake1;
        results[2] = fake2;
        results[3] = fake3;
    }
}
