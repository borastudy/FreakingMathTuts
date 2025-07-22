using UnityEngine;


namespace FreakingMath
{
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
        
        public void DoExplosion()
        {
            //need help from gamecontrol
            gameControl.Explosion();
        }
    }
}
