using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class CatalogFiller : MonoBehaviour
{

    [System.Serializable]

    public struct Rewards
    {
        public string rewardName, rewardDescription;
        public Sprite rewardIcon;
    }
    
    #region -------------- Variables --------------

        public GameObject iconGameObject, nameGameObject, descriptionGameObject, buttonGameObject, canvasGameObject;
        private GameObject _tempIconGameObject, _tempNameGameObject, _tempDescriptionGameObject;
        private GameObject _parent;
        [SerializeField]
        public Rewards[] rewards;
    #endregion

    public void Start()
    {
        for (int i = 0; i < rewards.Length; i++)
        {
            _parent = Instantiate(canvasGameObject, transform);
            _tempIconGameObject = Instantiate(iconGameObject, _parent.transform);
            _tempNameGameObject = Instantiate(nameGameObject, _parent.transform);
            _tempDescriptionGameObject = Instantiate(descriptionGameObject, _parent.transform);
            Instantiate(buttonGameObject, _parent.transform);
            
            _tempIconGameObject.GetComponent<Image>().sprite = rewards[i].rewardIcon;
            _tempNameGameObject.GetComponent<Text>().text = rewards[i].rewardName;
            _tempDescriptionGameObject.GetComponent<Text>().text = rewards[i].rewardDescription;
            
            _parent.GetComponent<RectTransform>().localPosition = new Vector3(0,i * -60, 0);
        }
    }

    public void Update()
    {
        
    }
}
