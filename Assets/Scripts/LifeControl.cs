using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeControl : MonoBehaviour
{
    [SerializeField] Toggle[] toggles;
    [SerializeField] int totalLife = 5;

    [SerializeField] Text textExtraLife;

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
        totalLife++;
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
