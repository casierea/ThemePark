using UnityEngine;
[ExecuteInEditMode]
//[CustomEditor(typeof(PositionHandle)),CanEditMultipleObjects]
public class SnapUIBehaviour : MonoBehaviour
{
    [Header("Snapping Positions")] [SerializeField]
    //private List<Vector3> _positions = new List<Vector3>();
    private POI positionSO;

    /*
    public Vector3 targetPosition { get { return m_TargetPosition; } set { m_TargetPosition = value; } }
    [SerializeField]
    private Vector3 m_TargetPosition = new Vector3(1f, 0f, 2f);

    public virtual void Update()
    {
        transform.LookAt(m_TargetPosition);
    }
    */
    /*
    private void SnapToAnchor()
    {
        
    }
*/
}
