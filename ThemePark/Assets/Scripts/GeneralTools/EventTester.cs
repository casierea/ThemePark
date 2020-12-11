using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTester : MonoBehaviour
{
    #region -------------- Variables --------------

    public event EventHandler OnSpacePressed;

    #endregion

    #region -------------- Setup --------------

    private void Start()
    {
        OnSpacePressed += Testing_OnSpacePressed;
    }

    #endregion

    #region -------------- Work --------------

    private void Update()    
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke(this,EventArgs.Empty);
        }
    }

    #endregion

    #region -------------- Methods --------------

    private void Testing_OnSpacePressed(object sender, EventArgs e)
    {
        Debug.Log("blsododjhsalkfjhdsa;faeouneauhdskjblaieufoaunfdkahfoe;uha;lsdjhgaihefihseo");
    }


    #endregion

    #region -------------- Visualize --------------



    #endregion

    #region -------------- Inspector --------------



    #endregion

}
