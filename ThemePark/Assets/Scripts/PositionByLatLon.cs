<<<<<<< HEAD
﻿using Mapbox.Unity.Map;
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
=======
﻿using Mapbox.Unity.Map;
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
>>>>>>> 70a0f9f16ad177f4b21438af99ef17e541da6143
