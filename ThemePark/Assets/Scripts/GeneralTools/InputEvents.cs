using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputEvents : MonoBehaviour
{
    #region -------------- Variables --------------

    public UnityEvent OnLeftClick,OnRightClick;

    #endregion

    #region -------------- Setup --------------

    

    #endregion

    #region -------------- Work --------------

    private void Update()
    {
        throw new NotImplementedException();
    }


    /*public UnityEvent OnClick1
    {
        get => OnClick;
        set => OnClick = value;
    }*/

    #endregion

    #region -------------- Methods --------------
    
    public void OnMouseButtonLeft()
    {
        if (Input.GetMouseButton(0))
        {
            OnLeftClick?.Invoke();
        }
    }

    public void OnMouseButtonRight()
    {
        if (Input.GetMouseButton(1))
        {
            OnRightClick.Invoke();
        }
    }

    private void TouchHandler()
    {
        if (Input.touchSupported && Application.platform != RuntimePlatform.WebGLPlayer)
        {
            //HandleTouch();
        }
        else
        {
            //HandleMouse();
        }
    }

    #endregion

    #region -------------- Visualize --------------



    #endregion

    #region -------------- Inspector --------------



    #endregion

}
