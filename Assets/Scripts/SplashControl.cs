using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FreakingMath
{
    public class SplashControl : MonoBehaviour
    {
        [SerializeField] float delayBeforeHome = 0.5f;

        void Start()
        {
            StartCoroutine(WaitingAndLoad());
        }


        IEnumerator WaitingAndLoad()
        {
            yield return new WaitForSeconds(delayBeforeHome);
            UnityEngine.SceneManagement.SceneManager.LoadScene("HomeScene");
        }
    }
}