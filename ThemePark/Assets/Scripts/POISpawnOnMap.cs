    using UnityEngine;
    using Mapbox.Utils;
    using Mapbox.Unity.Map;
    using Mapbox.Unity.MeshGeneration.Factories;
    using Mapbox.Unity.Utilities;
    using System.Collections.Generic;

    public class POISpawnOnMap : MonoBehaviour
    {
        [System.Serializable]
        public struct PositionAndInfo
        {
            public POISO info;
            
            [Geocode]
            public string locationStrings;
        }
        
        [SerializeField]
        public AbstractMap map;

        [SerializeField] 
        public PositionAndInfo[] positionAndInformation;
        
        private Vector2d[] _locations;
        
        private POI[] _info;

        [SerializeField]
        float spawnScale = 100f;

        [SerializeField]
        public GameObject markerPrefab;

        private List<GameObject> _spawnedObjects;

        void Start()
        {
            _locations = new Vector2d[positionAndInformation.Length];
            _info = new POI[positionAndInformation.Length];
            _spawnedObjects = new List<GameObject>();
            for (int i = 0; i < positionAndInformation.Length; i++)
            {
                positionAndInformation[i].info.location = Conversions.StringToLatLon(positionAndInformation[i].locationStrings);
                _locations[i] = Conversions.StringToLatLon(positionAndInformation[i].locationStrings);
                var instance = Instantiate(markerPrefab);
                instance.transform.localPosition = map.GeoToWorldPosition(_locations[i], true);
                instance.transform.localScale = new Vector3(spawnScale, spawnScale, spawnScale);
                instance.GetComponent<POI>().info = positionAndInformation[i].info;
                _spawnedObjects.Add(instance);
            }
        }

        private void Update()
        {
            int count = _spawnedObjects.Count;
            for (int i = 0; i < count; i++)
            {
                var spawnedObject = _spawnedObjects[i];
                var location = _locations[i];
                spawnedObject.transform.localPosition = map.GeoToWorldPosition(location, true);
                spawnedObject.transform.localScale = new Vector3(spawnScale, spawnScale, spawnScale);
            }
        }
    }