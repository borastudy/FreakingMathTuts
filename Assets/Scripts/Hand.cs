
using UnityEngine;


namespace FreakingMath
{
    public class Hand : MonoBehaviour
    {
        public void OnAnimationCompleted()
        {
            gameObject.SetActive(false);
        }
    }
}
