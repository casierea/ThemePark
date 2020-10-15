using UnityEngine;

public class AnimController : MonoBehaviour
{
    public Animator anim2; //Obj to be animated
    
    private void Start()
    {

        anim2 = GetComponent<Animator>(); 
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            anim2.Play("AnimClipMoveRight");
            
        }

        if (Input.GetMouseButtonDown(1))
        {
            anim2.Play("Idle");
        }
    }
}