using System;
using UnityEngine;
using UnityEngine.UI;

public class Reward : MonoBehaviour
{

    public RewardsSO info;
    public GameObject imagePrefab, textPrefab, buttonPrefab;
    private GameObject _logo, _name, _description, _useButton;
    
    // Start is called before the first frame update
    void Start()
    {
        _logo = Instantiate(imagePrefab, transform); //creates the logo as an image in the scene

        _logo.GetComponent<Image>().sprite = info.Logo; //sets the sprite for the logo
        _logo.GetComponent<Image>().SetNativeSize(); //sets the image to it's native size
        _logo.GetComponent<RectTransform>().localPosition = new Vector3(-145, 0, 0); //sets the position of the logo

        
        _name = Instantiate(textPrefab, transform);
        
        _name.GetComponent<Text>().text = info.Name;
        _name.GetComponent<Text>().fontStyle = FontStyle.Bold;
        _name.GetComponent<Text>().fontSize = 16;
        _name.GetComponent<RectTransform>().localPosition = new Vector3(-35, 0, 0);

        
        _description = Instantiate(textPrefab, transform);
        
        _description.GetComponent<Text>().text = info.Description;
        _description.GetComponent<Text>().fontStyle = FontStyle.Normal;
        _description.GetComponent<Text>().fontSize = 12;
        _description.GetComponent<RectTransform>().localPosition = new Vector3(-35,-17,0);


        _useButton = Instantiate(buttonPrefab, transform);
        
        _useButton.GetComponent<Button>().onClick.AddListener(UseButtonClicked);
        _useButton.GetComponent<RectTransform>().localPosition = new Vector3(145,0,0);
    }

    public void UseButtonClicked()
    {
        Debug.Log("BUTTON HAS BEEN PRESSED!");
    }
}
