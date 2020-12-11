using System;
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
