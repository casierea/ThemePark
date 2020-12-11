using System;
using System.Collections;
using UnityEngine;

public class POI : MonoBehaviour
{

    public POISO info, popUpFiller;
    private String _name, _websiteAddress, _description, _menu;
    private SpriteRenderer _icon;
    public GameObject spritePrefab, popUpPrefab;
    private GameObject _iconLayer, _fillLayer, _borderLayer, _popUpLayer;
    public Sprite fill, border;
    private bool _popUpDisplay = false, _running = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _iconLayer = Instantiate(spritePrefab, transform);

        _iconLayer.GetComponent<SpriteRenderer>().sprite = info.icon;
        _iconLayer.GetComponent<SpriteRenderer>().sortingOrder = 3;
        

        _borderLayer = Instantiate(spritePrefab, transform);
        
        _borderLayer.GetComponent<SpriteRenderer>().sprite = border;
        _borderLayer.GetComponent<SpriteRenderer>().color = info.borderColor;
        _borderLayer.GetComponent<SpriteRenderer>().sortingOrder = 2;
        
        
        _fillLayer = Instantiate(spritePrefab, transform);
        
        _fillLayer.GetComponent<SpriteRenderer>().sprite = fill;
        _fillLayer.GetComponent<SpriteRenderer>().color = info.colorCode;
        _fillLayer.GetComponent<SpriteRenderer>().sortingOrder = 1;
    }

    public void OnMouseDown()
    {
        popUpFiller.Set(info);
    }
}