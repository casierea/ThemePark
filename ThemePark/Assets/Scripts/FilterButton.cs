using System;
using TMPro;
using UnityEngine;

public class FilterButton : MonoBehaviour
{

    public TextMeshProUGUI filterName;
    public DictionarySO dictSO;
    public bool active = true;

    public void FilterSection()
    {
        if (active)
        {
            for (int i = 0; i < dictSO.dict[filterName.text].Count; i++)
            {
                dictSO.dict[filterName.text][i].SetActive(false);
            }

            active = false;
        }
        else // SETS ALL VALUES TO TRUE
        {
            for (int i = 0; i < dictSO.dict[filterName.text].Count; i++)
            {
                dictSO.dict[filterName.text][i].SetActive(true);
            }

            active = true;
        }
    }
}
