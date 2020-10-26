using UnityEngine;

public class POIListImplementation : MonoBehaviour
{

    public POISO[] pOI;
    public GameObject pOICatalogPrefab;
    private GameObject _tempReward;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < pOI.Length; i++)
        {
            _tempReward = Instantiate(pOICatalogPrefab, transform);
            _tempReward.transform.position += Vector3.down * (75 * i);
            _tempReward.GetComponent<POI>().info = pOI[i];
        }
    }
}