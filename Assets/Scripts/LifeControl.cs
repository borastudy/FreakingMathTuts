using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeControl : MonoBehaviour
{
    [SerializeField] Toggle[] toggles;
    [SerializeField] int totalLife = 5;

    [SerializeField] Text textExtraLife;

    [SerializeField] Animator animator;

    private void Start()
    {
        textExtraLife.text = string.Empty;

        foreach(var toggle in toggles)
        {
            toggle.isOn = true;
        }
    }

    public void RemoveLife ()
    {
        if (totalLife > 0)
        {
            //totalLife--;
            //totalLife = totalLife - 1;
            totalLife -= 1;

            if(toggles.Length > totalLife)
            {
                toggles[totalLife].isOn = false;
            }

            RefreshExtraLife();
        }
    }

    public void AddLife()
    {
        StartCoroutine(_addLife());
    }

    IEnumerator _addLife()
    {
        totalLife++;

        if (totalLife > 5)
        {
            animator.Play("MoveToTextExtraLife");
        }
        else
        {
            //totalLife=2 => MoveToToggleLife2
            //totalLife=3 => MoveToToggleLife3
            //totalLife=4 => MoveToToggleLife4
            //totalLife=5 => MoveToToggleLife5

            /*if(totalLife == 2)
            {
                animator.Play("MoveToToggleLife2");
            } else if(totalLife == 3)
            {
                animator.Play("MoveToToggleLife3");
            }
            else if (totalLife == 4)
            {
                animator.Play("MoveToToggleLife4");
            }
            else if (totalLife == 5)
            {
                animator.Play("MoveToToggleLife5");
            }*/


            var clipName = $"MoveToToggleLife{totalLife}";
            animator.Play(clipName);

        }

        yield return new WaitForSeconds(0.5f);

        if (toggles.Length > totalLife - 1)
        {
            toggles[totalLife - 1].isOn = true;
        }



        RefreshExtraLife();
    }


    private void RefreshExtraLife()
    {
        if(totalLife > 5)
        {
            var extra = totalLife - 5;
            textExtraLife.text = $"+{extra}";
        }
        else
        {
            textExtraLife.text = string.Empty;
        }
    }

    public bool StillHasLife ()
    {
        return totalLife > 0;
    }

    public bool IsDie()
    {
        return totalLife == 0;
    }

    public void ResetLife()
    {
        totalLife = 5;
        foreach (var toggle in toggles)
        {
            toggle.isOn = true;
        }
    }
}
