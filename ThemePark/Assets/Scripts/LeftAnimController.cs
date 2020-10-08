using UnityEngine;

public class LeftAnimController : MonoBehaviour
{
    public Animator objAnim1; //Obj to be animated
    
    private void Start()
    {

        objAnim1 = GetComponent<Animator>(); 
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            objAnim1.Play("LeftAnim");
            
        }

        if (Input.GetMouseButtonDown(1))
        {
            objAnim1.Play("LeftIdle");
        }
    }
}