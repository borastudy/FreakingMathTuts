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

    public void GenerateQuiz ()
    {
        operandA = Random.Range (10, 50);
        operandB = Random.Range (10, 50);

        mathOperator = (MathOperator)Random.Range(0, 4);

        question = operandA + mathOperator + operandB + " = ?";
    }
}
