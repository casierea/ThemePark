using System;
using UnityEngine;

public class POI : MonoBehaviour
{

    public POISO info;
    private String _name, _websiteAddress, _description, _menu;
    private SpriteRenderer _icon;
    public GameObject spritePrefab;
    private GameObject _fillLayer, _borderLayer;
    public Sprite fill, border;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = info.Location;
        
        _icon = gameObject.GetComponent<SpriteRenderer>();
        _icon.sprite = info.Icon;
        _icon.sortingOrder = 3;

        _borderLayer = Instantiate(spritePrefab, transform);
        
        _borderLayer.GetComponent<SpriteRenderer>().sprite = border;
        _borderLayer.GetComponent<SpriteRenderer>().color = info.BorderColor;
        _borderLayer.GetComponent<SpriteRenderer>().sortingOrder = 2;
        
        _fillLayer = Instantiate(spritePrefab, transform);
        
        _fillLayer.GetComponent<SpriteRenderer>().sprite = fill;
        _fillLayer.GetComponent<SpriteRenderer>().color = info.ColorCode;
        _fillLayer.GetComponent<SpriteRenderer>().sortingOrder = 1;
    }
}
