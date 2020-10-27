using System;
using System.Collections;
using UnityEngine;

public class POI : MonoBehaviour
{

    public POISO info;
    private String _name, _websiteAddress, _description, _menu;
    private SpriteRenderer _icon;
    public GameObject spritePrefab, popUpPrefab;
    private GameObject _fillLayer, _borderLayer, _popUpLayer;
    public Sprite fill, border;
    public bool popUpDisplay = false, running = false;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = info.location;
        
        _icon = gameObject.GetComponent<SpriteRenderer>();
        _icon.sprite = info.icon;
        _icon.sortingOrder = 3;
        

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
        if (popUpDisplay == false)
        {
            if (_popUpLayer == null)
                _popUpLayer = Instantiate(popUpPrefab, transform);

            _popUpLayer.GetComponent<PopUpFiller>().info = info;
            _popUpLayer.transform.localScale = new Vector3(0,0,0);
            _popUpLayer.transform.localPosition = new Vector3(0,-1,0);

            StartCoroutine(GrowPopUp());
            popUpDisplay = true;
        }
        else
        {
            StartCoroutine(ShrinkPopUp());
            popUpDisplay = false;
        }

    }

    public IEnumerator GrowPopUp()
    {
        if (!running)
        {
            running = true;
            _popUpLayer.SetActive(true);
            while (_popUpLayer.transform.localScale.y < .99f)
            {
                _popUpLayer.transform.localScale =
                    Vector3.Lerp(_popUpLayer.transform.localScale, Vector3.one, 7f * Time.deltaTime);
                _popUpLayer.transform.localPosition =
                    Vector3.Lerp(_popUpLayer.transform.localPosition, Vector3.down, 7f * Time.deltaTime);
                yield return null;
            }
            
            running = false;
        }

    }
    
    public IEnumerator ShrinkPopUp()
    {
        if (!running)
        {
            running = true;
            while (_popUpLayer.transform.localScale.y > .01f)
            {
                _popUpLayer.transform.localScale =
                    Vector3.Lerp(_popUpLayer.transform.localScale, Vector3.zero, 7f * Time.deltaTime);
                 _popUpLayer.transform.localPosition =
                    Vector3.Lerp(_popUpLayer.transform.localPosition, Vector3.zero, 7f * Time.deltaTime);
                yield return null;
            }

            _popUpLayer.SetActive(false);
            running = false;
        }
    }
}