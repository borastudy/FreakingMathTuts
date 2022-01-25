using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeControl : MonoBehaviour
{
    [SerializeField] Toggle[] toggles;
    [SerializeField] int totalLife = 5;

    private void Start()
    {
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
            toggles[totalLife].isOn = false;
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
}
