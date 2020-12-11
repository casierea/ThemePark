using UnityEngine;

public class UpAnimController : MonoBehaviour
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
            objAnim1.Play("AnimUp");
            
        }

        if (Input.GetMouseButtonDown(1))
        {
            objAnim1.Play("UpIdle");
        }
    }
}