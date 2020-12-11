using Mapbox.Unity.Map;
using Mapbox.Unity.Utilities;
using UnityEngine;

public class PositionByLatLon : MonoBehaviour
{

    public AbstractMap map;
    public StringData LatLon;
    public GameObject obj;

    // Update is called once per frame
    void Update()
    {
        obj.transform.position = map.GeoToWorldPosition(Conversions.StringToLatLon(LatLon.data), true);
    }
}
