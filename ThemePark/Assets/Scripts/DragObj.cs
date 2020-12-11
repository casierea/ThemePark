using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class DragObj : MonoBehaviour
{
    public bool draggy = false;
    public bool collisionOn = false;
    private Vector3 position;
    
   
    public void startDrag()
    {
        position = gameObject.transform.position;
        draggy = true;
        Debug.Log("start drag");
    }

    public void drag()
    {
        transform.position = Input.mousePosition;
        Debug.Log("drag");
    }

    public void drop()
    {
        if (!collisionOn)
        {
            gameObject.transform.position = position;
            Debug.Log("drop" +
                      "");
        }

        draggy = false;
    }
}
