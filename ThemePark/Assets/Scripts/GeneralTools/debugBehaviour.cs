using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugBehaviour : MonoBehaviour
{
    #region -------------- Variables --------------

    [SerializeField] private string debugMessage;

    #endregion

    #region -------------- Setup --------------



    #endregion

    #region -------------- Work --------------


    #endregion

    #region -------------- Methods --------------

    public void SendDebugMessage(string message)
    {
        Debug.Log(message);
        
    }


    #endregion

    #region -------------- Visualize --------------



    #endregion

    #region -------------- Inspector --------------



    #endregion

}
