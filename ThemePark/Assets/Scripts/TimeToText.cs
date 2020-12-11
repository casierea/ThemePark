using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeToText : MonoBehaviour
{
    public FloatData Hour, Minute;
    public Text text;
    private String _tempText;

    // Update is called once per frame
    void Update()
    {

        if (Hour.data > 12)
            _tempText = (Hour.data - 12).ToString();
        else
            _tempText = Hour.data.ToString();

        _tempText += ":";

        if (Minute.data < 10)
            _tempText += "0";

        _tempText += Minute.data.ToString();

        text.text = _tempText;
    }
}
