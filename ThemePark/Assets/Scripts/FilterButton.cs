using System;
using UnityEngine;

public class FilterButton : MonoBehaviour
{

    public DictionarySO dictSO;
    public bool active = true;

    public void FilterSection(String filter)
    {
        if (active)
        {
            for (int i = 0; i < dictSO.dict[filter].Count; i++)
            {
                dictSO.dict[filter][i].SetActive(false);
            }

            active = false;
        }
        else // SETS ALL VALUES TO TRUE
        {
            for (int i = 0; i < dictSO.dict[filter].Count; i++)
            {
                dictSO.dict[filter][i].SetActive(true);
            }

            active = true;
        }
    }
}
