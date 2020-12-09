using System;
using UnityEngine;
using System.Collections;
[RequireComponent(typeof(SelectionManager))]
public class CameraHandler : MonoBehaviour
{

    [SerializeField] private Vector3SO _selectionLoc;
    [SerializeField] private GameAction _clickAction;
    [SerializeField] private float _cameraHeight = 10f;

    [SerializeField] private float _cameraOffset = 5f;
    // private camera stuff
    private static readonly float PanSpeed = 20f;
    private static readonly float ZoomSpeedTouch = 0.1f;
    private static readonly float ZoomSpeedMouse = 0.5f;
    
    private static readonly float[] BoundsX = new float[]{-10f, 5f};
    private static readonly float[] BoundsZ = new float[]{-18f, -4f};
    private static readonly float[] ZoomBounds = new float[]{10f, 85f};
    
    private Camera cam;
    
    private Vector3 _resetPos = new Vector3(0f,0f,0f);
    
    private SelectionManager _selectionManager;
    //[SerializeField]private SelectionManager _selectionManager;

    //private void SubscribeToEvent(SelectionManager i) => i.SelectObj(); 
    
    private Vector3 lastPanPosition;
    private int panFingerId; // Touch mode only
    
    private bool wasZoomingLastFrame; // Touch mode only
    private Vector2[] lastZoomPositions; // Touch mode only

    private bool _isMovingToPos = false;
    void Awake() {
        cam = GetComponent<Camera>();
        //_selectionManager = GetComponent<SelectionManager>();
    }

    private void Start()
    {
        _resetPos.y = _cameraHeight;
        //_selectionManager = _selectionManager.GetComponent<SelectionManager>();
        //_selectionManager.SelectObj += MoveToPosition;
        //_selectionManager = new SelectionManager();
        //_selectionManager.SelectObj += MoveToPosition;
    }

    void Update() {
        if (!_isMovingToPos)
        {
            if (Input.touchSupported && Application.platform != RuntimePlatform.WebGLPlayer)
            {
                HandleTouch();
            }
            else
            {
                HandleMouse();
            }
        }
        else
        {
            //MoveToPosition();
        }
    }
    
    void HandleTouch() {
        switch(Input.touchCount) {
    
        case 1: // Panning
            wasZoomingLastFrame = false;
            
            // If the touch began, capture its position and its finger ID.
            // Otherwise, if the finger ID of the touch doesn't match, skip it.
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began) {
                lastPanPosition = touch.position;
                panFingerId = touch.fingerId;
            } else if (touch.fingerId == panFingerId && touch.phase == TouchPhase.Moved) {
                PanCamera(touch.position);
            }
            break;
    
        case 2: // Zooming
            Vector2[] newPositions = new Vector2[]{Input.GetTouch(0).position, Input.GetTouch(1).position};
            if (!wasZoomingLastFrame) {
                lastZoomPositions = newPositions;
                wasZoomingLastFrame = true;
            } else {
                // Zoom based on the distance between the new positions compared to the 
                // distance between the previous positions.
                float newDistance = Vector2.Distance(newPositions[0], newPositions[1]);
                float oldDistance = Vector2.Distance(lastZoomPositions[0], lastZoomPositions[1]);
                float offset = newDistance - oldDistance;
    
                ZoomCamera(offset, ZoomSpeedTouch);
    
                lastZoomPositions = newPositions;
            }
            break;
        case 3: // rotating
            break;
        default: 
            wasZoomingLastFrame = false;
            break;
        }
    }
    
    void HandleMouse() {
        // On mouse down, capture it's position.
        // Otherwise, if the mouse is still down, pan the camera.
        if (Input.GetMouseButtonDown(0)) {
            lastPanPosition = Input.mousePosition;
        } else if (Input.GetMouseButton(0)) {
            PanCamera(Input.mousePosition);
        }
    
        // Check for scrolling to zoom the camera
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        ZoomCamera(scroll, ZoomSpeedMouse);
    }
    
    void PanCamera(Vector3 newPanPosition) {
        // Determine how much to move the camera
        Vector3 offset = cam.ScreenToViewportPoint(lastPanPosition - newPanPosition);
        Vector3 move = new Vector3(offset.x * PanSpeed, 0, offset.y * PanSpeed);
        
        // Perform the movement
        transform.Translate(move, Space.World);  
        
        // Ensure the camera remains within bounds.
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, BoundsX[0], BoundsX[1]);
        pos.z = Mathf.Clamp(transform.position.z, BoundsZ[0], BoundsZ[1]);
        transform.position = pos;
    
        // Cache the position
        lastPanPosition = newPanPosition;
    }
    
    void ZoomCamera(float offset, float speed) {
        if (offset == 0) {
            return;
        }
    
        cam.fieldOfView = Mathf.Clamp(cam.fieldOfView - (offset * speed), ZoomBounds[0], ZoomBounds[1]);
    }

    void RotateCamera(float offset, float speed)
    {
        
    }

    public void MoveToPosition()
    {
        _isMovingToPos = true;
        Debug.Log("Move To Position");
        /*
        _selectionLoc.Position = _resetPos;
        _selectionLoc.Position.y = transform.position.y;
        _selectionLoc.Position = _selectionLoc.Position - new Vector3(0f, 5f, 0f);
        */
        //_selectionLoc.Position.z = transform.position.z - 2;
        Vector3 _newPos = new Vector3();
        Vector3 _offset = new Vector3(_selectionLoc.Position.x,_cameraHeight,_selectionLoc.Position.z - _cameraOffset);
        Debug.Log("select loc " + _selectionLoc.Position);
        transform.position = _offset;
        
        
        _isMovingToPos = false;
        //PanCamera();
    }
}