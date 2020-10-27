using UnityEngine;

public class RewardListImplementation : MonoBehaviour
{

    public RewardsSO[] rewards;
    public GameObject rewardCatalogPrefab;
    public float distanceBetween;
    private GameObject _tempReward;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < rewards.Length; i++)
        {
            _tempReward = Instantiate(rewardCatalogPrefab, transform);
            _tempReward.transform.position += Vector3.down * (distanceBetween * i);
            _tempReward.GetComponent<Reward>().info = rewards[i];
        }
    }
}