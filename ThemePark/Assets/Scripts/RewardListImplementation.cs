using System;
using System.Collections.Generic;
using UnityEngine;

public class RewardListImplementation : MonoBehaviour
{

    [System.Serializable]
    public struct RewardInfo
    {
        public String name, filter, websiteAddress, description, menu;
        public Sprite icon, logo, pictures;
        public float BarCode;
    }

    
    public RewardInfo[] rewards;
    public RewardsSO rewardTemplate;
    public GameObject rewardCatalogPrefab;
    public float distanceBetween;
    private GameObject _tempReward;
    public DictionarySO filterDict;
    
    // Start is called before the first frame update
    void Start()
    {
        filterDict.dict = new Dictionary<string, List<GameObject>>(); // create a new dictionary to add rewards to filter

        for (int i = 0; i < rewards.Length; i++)
        {
            var temp = Instantiate(rewardTemplate);
            temp.Set(rewards[i].name, rewards[i].filter, rewards[i].websiteAddress, rewards[i].description, 
                rewards[i].menu, rewards[i].icon, rewards[i].logo, rewards[i].pictures, rewards[i].BarCode);
            _tempReward = Instantiate(rewardCatalogPrefab, transform);
            _tempReward.GetComponent<RectTransform>().position += Vector3.down * (distanceBetween * i);
            _tempReward.GetComponent<Reward>().info = temp;
            
            if (filterDict.dict.ContainsKey(rewards[i].filter))
            {
                filterDict.dict[rewards[i].filter].Add(_tempReward);
            }
            else
            {
                filterDict.dict.Add(rewards[i].filter, new List<GameObject>());
                filterDict.dict[rewards[i].filter].Add(_tempReward);
            }
        }
    }

    public void Update()
    {
        //shift active Rewards to the top
    }
}