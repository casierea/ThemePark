    using System;
    using UnityEngine;
    using Mapbox.Utils;
    using Mapbox.Unity.Map;
    using Mapbox.Unity.MeshGeneration.Factories;
    using Mapbox.Unity.Utilities;
    using System.Collections.Generic;
    using System.Linq;

    public class POISpawnOnMap : MonoBehaviour
    {
        [System.Serializable]
        public struct PositionAndInfo
        {
            public String name, filter, websiteAddress, description, menu;
            public Sprite icon, logo, pictures;
            public Color colorCode, borderColor;
            [Geocode]
            public string locationStrings;
            [System.NonSerialized]
            public Vector2d location;
        }

        public DictionarySO filterDict;

        public POISO Template;
        
        [SerializeField]
        public AbstractMap map;

        [SerializeField] 
        public PositionAndInfo[] positionAndInformation;
        
        private Vector2d[] _locations;

        [SerializeField]
        float spawnScale = 100f;

        [SerializeField]
        public GameObject markerPrefab;

        private List<GameObject> _spawnedObjects;

        void Start()
        {
            filterDict.dict = new Dictionary<string, List<GameObject>>();
            _locations = new Vector2d[positionAndInformation.Length];
            _spawnedObjects = new List<GameObject>();
            for (int i = 0; i < positionAndInformation.Length; i++)
            {
                var temp = Instantiate(Template);
                positionAndInformation[i].location =
                    Conversions.StringToLatLon(positionAndInformation[i].locationStrings);
                temp.Set(positionAndInformation[i].name, positionAndInformation[i].filter,
                    positionAndInformation[i].websiteAddress, positionAndInformation[i].description,
                    positionAndInformation[i].menu, positionAndInformation[i].icon, positionAndInformation[i].logo,
                    positionAndInformation[i].pictures, positionAndInformation[i].location,
                    positionAndInformation[i].colorCode, positionAndInformation[i].borderColor);
                _locations[i] = Conversions.StringToLatLon(positionAndInformation[i].locationStrings);
                var instance = Instantiate(markerPrefab);
                instance.transform.localPosition = map.GeoToWorldPosition(_locations[i], true);
                instance.transform.localScale = new Vector3(spawnScale, spawnScale, spawnScale);
                instance.GetComponent<POI>().info = temp;
                _spawnedObjects.Add(instance);
                if (filterDict.dict.ContainsKey(positionAndInformation[i].filter))
                {
                    filterDict.dict[positionAndInformation[i].filter].Add(instance);
                }
                else
                {
                    filterDict.dict.Add(positionAndInformation[i].filter, new List<GameObject>());
                    filterDict.dict[positionAndInformation[i].filter].Add(instance);
                }
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