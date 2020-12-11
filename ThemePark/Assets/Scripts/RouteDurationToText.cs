<<<<<<< HEAD
﻿using System;
using UnityEngine;
using UnityEngine.UI;

public class RouteDurationToText : MonoBehaviour
{
    public FloatData time;
    public Text text;
    public String preText, postText;
    private String _tempText;

    // Update is called once per frame
    void Update()
    {

        _tempText = preText;
        
        _tempText += time.data.ToString();

        _tempText += postText;

        text.text = _tempText;
    }
}
=======
﻿using System;
using UnityEngine;
using UnityEngine.UI;

public class RouteDurationToText : MonoBehaviour
{
    public FloatData time;
    public Text text;
    public String preText, postText;
    private String _tempText;

    // Update is called once per frame
    void Update()
    {

        _tempText = preText;
        
        _tempText += time.data.ToString();

        _tempText += postText;

        text.text = _tempText;
    }
}
>>>>>>> 70a0f9f16ad177f4b21438af99ef17e541da6143
