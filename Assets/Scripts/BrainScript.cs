using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public enum MathOperator
{
    PLUS,
    MINUS,
    MULTIPLY,
    DEVIDE
}

public class BrainScript : MonoBehaviour
{
    private float operandA;
    private float operandB;
    public float correctResult;
    public float[] results;
    public string question;
    public MathOperator mathOperator;

    public void GenerateQuiz ()
    {
        operandA = Random.Range (10, 50);
        operandB = Random.Range (10, 50);

        mathOperator = (MathOperator)Random.Range (0, 4);
        
        results = new float[4];
        
        string sign = "";
        switch(mathOperator)
        {
            
            case MathOperator.PLUS:
            correctResult = operandA + operandB;
            sign = " + ";
            break;

            case MathOperator.MINUS:
            correctResult = operandA - operandB;
            sign = " - ";
            break;
            
            case MathOperator.MULTIPLY:
            correctResult = operandA * operandB;
            sign = " * ";
            break;
            
            case MathOperator.DEVIDE:
            correctResult = operandA / operandB;
            sign = " / ";
            break;
        }

        question = operandA + sign + operandB + " = ?";

        results[0] = correctResult;
        GenFakeResults();
    }

    private void GenFakeResults ()
    {
        for(int i = 1; i<4; i++)
        {
            float fakeResult = Random.Range (correctResult - 10, correctResult + 10);
            while(fakeResult == correctResult || results.Contains(fakeResult))
            {
                fakeResult = Random.Range (correctResult - 10, correctResult + 10);
            }

            results[i] = fakeResult;
        }
    }

}
