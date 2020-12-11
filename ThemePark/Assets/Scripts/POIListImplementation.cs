using UnityEngine;

public class POIListImplementation : MonoBehaviour
{

    public POISO[] pOI;
    public GameObject pOICatalogPrefab;
    private GameObject _tempPOI;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < pOI.Length; i++)
        {
            _tempPOI = Instantiate(pOICatalogPrefab, transform);
            _tempPOI.GetComponent<POI>().info = pOI[i];
        }
    }
}