using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class ButtonBehaviour : MonoBehaviour
{
    #region -------------- Variables --------------
    
    
    #endregion
    #region -------------- Inspector --------------
    [Header("ColorControls")]
    [SerializeField] private Color FillColor;

    [SerializeField] private Color OutlineColor;
    //[Header("ShapeControls")]
    protected static bool showGeneralSettings = true; //declare outside of function
    
    /*
    protected override void OnInspectorGUI () 
    {
        
        showGeneralSettings = EditorGUILayout.Foldout(showGeneralSettings, "General Settings");
        
    }  
    */
    #endregion 
    #region -------------- Setup --------------



    #endregion

    #region -------------- Work --------------



    #endregion

    #region -------------- Methods --------------



    #endregion

    #region -------------- Visualize --------------



    #endregion
    
}

#if UNITY_EDITOR

[CustomEditor(typeof(ButtonBehaviour))]
public class TestOnInspector : Editor
{
    protected static bool showGeneralSettings = true; //declare outside of function
    Color matColor = Color.cyan;
    public override void OnInspectorGUI()
    {
        GUILayout.Label ("This is a Label in a Custom Editor");
        showGeneralSettings = EditorGUILayout.Foldout(showGeneralSettings, "General Settings");
        matColor = EditorGUILayout.ColorField("New Color", matColor);
    }

    void OnGui()
    {
        
    }
}

#endif