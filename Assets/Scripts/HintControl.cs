using UnityEngine;

public class HintControl : MonoBehaviour
{
    [SerializeField] GameControl gameControl;

    public void DoGiveAnswer()
    {
        //need help from gamecontrol
        gameControl.GiveAnswer();
    }
}
