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
        directions._waypoints[directions._waypoints.Length - 1].parent = transform.parent.parent;
        directions._waypoints[directions._waypoints.Length - 1].localPosition = Vector3.zero;
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
