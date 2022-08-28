using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverControl : MonoBehaviour
{
    [SerializeField] Text textScore;

    public void SetScore(int score)
    {
        textScore.text = score.ToString();
    }
}
