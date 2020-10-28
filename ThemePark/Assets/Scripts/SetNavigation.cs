using System;
using Mapbox.Unity.MeshGeneration.Factories;
using UnityEngine;

public class SetNavigation : MonoBehaviour
{

    public POISO info;
    public DirectionsFactory directions;
    public GameObject userPosition;


    public void Start()
    {
        directions = FindObjectOfType<DirectionsFactory>();
        userPosition = GameObject.Find("User Icon Master");
    }

    public void SetWayPoint()
    {
        directions._waypoints[directions._waypoints.Length - 1].position = 
            new Vector3(info.location.x, info.location.z, info.location.y);
        directions._waypoints[directions._waypoints.Length - 1].parent = null;
    }

    public void ResetWayPoint()
    {
        directions._waypoints[directions._waypoints.Length - 1].position = userPosition.transform.position;
    }

    public void OnMouseUpAsButton()
    {
        SetWayPoint();
    }
}
