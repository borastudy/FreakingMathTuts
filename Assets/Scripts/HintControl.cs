using UnityEngine;

public class HintControl : MonoBehaviour
{
    [SerializeField] GameControl gameControl;
    [SerializeField] TimerBarControl timerControl;

    public void DoGiveAnswer()
    {
        //need help from gamecontrol
        gameControl.GiveAnswer();
    }

    public void DoPauseTimer()
    {
        //need help from timerbarcontrol
        timerControl.Pause();
    }
}
