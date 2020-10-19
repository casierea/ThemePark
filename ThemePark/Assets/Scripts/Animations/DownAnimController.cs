using UnityEngine;

public class DownAnimController : MonoBehaviour
{
    public Animator objAnim2; //Obj to be animated
    
    private void Start()
    {

        objAnim2 = GetComponent<Animator>(); 
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            objAnim2.Play("DownAnim");
            
        }

        if (Input.GetMouseButtonDown(1))
        {
            objAnim2.Play("DownIdle");
        }
    }
}