using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;

public class GPS : MonoBehaviour
{
    public StringData postion;
    public bool isUpdating = false;
    public int parseTime;

    public void Update()
    {
        if (!isUpdating)
        {
            StartCoroutine(GetLocation());
            isUpdating = !isUpdating;
        }
    }

    public IEnumerator GetLocation()
    {
        if (!Permission.HasUserAuthorizedPermission((Permission.FineLocation)))
        {
            Permission.RequestUserPermission(Permission.FineLocation);
            Permission.RequestUserPermission(Permission.CoarseLocation);
        }
        
        if(!Input.location.isEnabledByUser) // what happens after 5 seconds if the user does nothing
            yield return new WaitForSeconds(5);
        
        Input.location.Start();

        int maxWait = 5;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        if (maxWait < 1)
        {
            print("Timed Out");
            yield break;
        }

        if (Input.location.status == LocationServiceStatus.Failed)
        {
            print("Unable to determine device location");
            yield break;
        }
        else
        {
            postion.data = Input.location.lastData.latitude + ", " + Input.location.lastData.longitude;
        }

        yield return new WaitForSeconds(parseTime);
        isUpdating = !isUpdating;
        //Input.location.Stop();
    }
}
