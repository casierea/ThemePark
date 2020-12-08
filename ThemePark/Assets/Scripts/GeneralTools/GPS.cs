using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;

public class GPS : MonoBehaviour
{
    public Text gpsOut;
    public bool isUpdating;

    public void Update()
    {
        if (!isUpdating)
        {
            StartCoroutine(GetLocation());
            isUpdating = !isUpdating;
        }
    }

    IEnumerator GetLocation()
    {
        if (!Permission.HasUserAuthorizedPermission((Permission.FineLocation)))
        {
            Permission.RequestUserPermission(Permission.FineLocation);
            Permission.RequestUserPermission(Permission.CoarseLocation);
        }
        
        if(!Input.location.isEnabledByUser)
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
            gpsOut.text = "Timed Out";
            print("Timed Out");
            yield break;
        }

        if (Input.location.status == LocationServiceStatus.Failed)
        {
            gpsOut.text = "Unable to determine device location";
            print("Unable to determine device location");
            yield break;
        }
        else
        {
            gpsOut.text = "Lat: " + Input.location.lastData.latitude + " Lon: " + Input.location.lastData.longitude;
            print("Lat: " + Input.location.lastData.latitude + " Lon: " + Input.location.lastData.longitude);
        }
        
    }
}
