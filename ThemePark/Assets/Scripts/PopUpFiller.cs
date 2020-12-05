using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopUpFiller : MonoBehaviour
{

    public POISO info;
    public Image icon;
    public TextMeshProUGUI Name, description;


    void Update()
    {
        icon.sprite = info.logo;
        Name.text = info.Name;
        description.text = info.description;
    }
}
