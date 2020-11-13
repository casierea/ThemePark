using UnityEngine;

public class DragMovement : MonoBehaviour
{
    public Transform movingObj;
    private Vector3 _lastFramePosition, _mousePosition;
    public float moveSpeed;

    public void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if(Input.GetMouseButtonDown(0))
                _lastFramePosition = new Vector3(Input.mousePosition.x, 0, Input.mousePosition.y);
            _mousePosition = new Vector3(Input.mousePosition.x, 0, Input.mousePosition.y);
            movingObj.transform.position += ((_mousePosition - _lastFramePosition) * moveSpeed);
            _lastFramePosition = _mousePosition;
        }
    }

    /*public void OnMouseDrag()
    {
        _mousePosition = new Vector3(Event.current.mousePosition.x, 0, Event.current.mousePosition.y);

        movingObj.transform.position += (_mousePosition - _lastFramePosition);
        Debug.Log("gottem");
    }*/
}
