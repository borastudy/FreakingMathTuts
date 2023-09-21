
using UnityEngine;

public class Hand : MonoBehaviour
{
    public void OnAnimationCompleted()
    {
        gameObject.SetActive(false);
    }
}
