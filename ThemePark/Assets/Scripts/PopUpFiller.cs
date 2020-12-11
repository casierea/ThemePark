<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 70a0f9f16ad177f4b21438af99ef17e541da6143
