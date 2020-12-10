using System;
using UnityEditor;
using UnityEngine;

public class TestTool : EditorWindow
{
    private string _name;
    private int _id;
    private float _scale;

    [MenuItem("Tools/Test Tool")]
    
    public static void ShowWindow()
    {
        GetWindow(typeof(TestTool));
    }

    private void OnGUI()
    {
        GUILayout.Label("Test Tool",EditorStyles.boldLabel);

        name = EditorGUILayout.TextField("Name", name);

        if (GUILayout.Button("Button"))
        {
            DoAThing();
        }
    }

    private void DoAThing()
    {
        Debug.Log("boop");
    }
}
