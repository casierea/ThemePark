using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{
    public void SetTransformPosition(Transform newPosition)
    {
        transform.position = newPosition.position;
    }

    public void SetTransformParent(Transform newParent)
    {
        transform.parent = newParent;
    }
}
