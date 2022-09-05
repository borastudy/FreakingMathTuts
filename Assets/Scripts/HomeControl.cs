using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeControl : MonoBehaviour
{
    public void ClickToGameScene ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
