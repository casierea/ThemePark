using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelHeight : MonoBehaviour
{
    public RectTransform RT;
    public DictionarySO list;
    public float distance;
    public int count;

    public IEnumerator Start()
    {
        yield return new WaitForSeconds(.1f);
        foreach (var i in list.dict)
        {
            foreach (var j in i.Value)
            {
                count++;
            }
        }
    }

    public void Update()
    {
        RT.sizeDelta = new Vector2(500, count * distance);
    }
}
