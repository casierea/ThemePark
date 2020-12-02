using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class InputTextField : MonoBehaviour
{
    public InputField mainInputField;

    public void Start()
    {
        mainInputField.text = "Enter Text Here...";
    }
}