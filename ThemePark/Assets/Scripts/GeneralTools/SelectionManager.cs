using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//[RequireComponent(typeof(CameraHandler))]
public class SelectionManager : MonoBehaviour
{
    #region -------------- Variables --------------
    
    // main inputs
    [SerializeField] private string selectableTag = "selectable";
    [SerializeField] private GameAction _SelectAction;
    
    
    // event testing
    public static event EventHandler selectedObj;
    public Vector3SO selectionLoc;
    
    //private CameraHandler _cameraHandler;
    
    private Transform _selection;

    [HideInInspector] public Transform selected;
    
    public UnityEvent selectObject;
    
    
    // double click & double tap vars
    private float _doubleTapTimeD;
    float touchDuration;
    Touch touch;
    
    
    #endregion

    #region -------------- Setup --------------

    private void Start()
    {
        
        //_cameraHandler = GetComponent<CameraHandler>();

    }

    #endregion

    #region -------------- Work --------------

    private void Update()
    {
        SelectObj();
        //SelectObjectTwo();
        //MouseTouchSwitcher();
    }

    #endregion

    #region -------------- Methods --------------

    
    public void SelectObj()
    {
        if (_selection != null)
        {
            _selection = null;
        }
        
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonUp(0))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                if (selection != null)
                {
                    selectedObj?.Invoke(this, EventArgs.Empty);
                    //selectObject.Invoke();
                    _SelectAction.Raise();
                    selectionLoc.Position = hit.transform.position;
                    //Debug.Log(hit.transform.position);
                }

                _selection = selection;
                selected = _selection;
                //Debug.Log("selected position " + selected.position);
            }
        }
    }

    public void DoubleTap()
    {
        if(Input.touchCount > 0){ //if there is any touch
            touchDuration += Time.deltaTime;
            touch = Input.GetTouch(0);
 
            if(touch.phase == TouchPhase.Ended && touchDuration < 0.2f) //making sure it only check the touch once && it was a short touch/tap and not a dragging.
                StartCoroutine("singleOrDouble");
        }
        else
            touchDuration = 0.0f;
    }

    IEnumerator singleOrDouble()
    {
        yield return new WaitForSeconds(0.3f);
        if (touch.tapCount == 1)
            Debug.Log("Single");
        else if (touch.tapCount == 2)
        {
            //this coroutine has been called twice. We should stop the next one here otherwise we get two double tap
            StopCoroutine("singleOrDouble");
            Debug.Log("Double");
        }
    }

    public void DoubleClick()
    {
        //float _doubleTapTimeD;
 
            bool doubleTapD = false;
 
            #region doubleTapD
 
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (Time.time < _doubleTapTimeD + .3f)
                {
                    doubleTapD = true;
                }
                _doubleTapTimeD = Time.time;
            }
 
            #endregion
 
            if (doubleTapD)
            {
                Debug.Log("DoubleTapD");
            }

    }
    
    public void MouseTouchSwitcher()
    {
        if (Input.touchSupported && Application.platform != RuntimePlatform.WebGLPlayer)
        {
            DoubleTap();
        }
        else
        {
            DoubleClick();
        }

    }

    /*
    public void SelectObjectTwo()
    {
        if (_selection != null)
        {
            _selection = null;
            selected = null;
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse is down");
         
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit) 
            {
                Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                if (hitInfo.transform.CompareTag(selectableTag))
                {
                    Debug.Log ("It's working!");
                } else {
                    Debug.Log ("nopz");
                }
            } else {
                Debug.Log("No hit");
            }
            Debug.Log("Mouse is down");
        } 
    }
    */
    
    #endregion

    #region -------------- Visualize --------------

    

    #endregion

    #region -------------- Inspector --------------

    

    #endregion

}
