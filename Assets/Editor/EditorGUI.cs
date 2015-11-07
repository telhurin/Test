using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CurveGUI))]
public class EditorGUI : Editor
{

    void OnSceneGUI()
    {
        var script = (CurveGUI)target;

        script.pointA = Handles.PositionHandle(script.pointA, Quaternion.identity);
        script.pointB = Handles.PositionHandle(script.pointB, Quaternion.identity);
        script.TangentA = Handles.PositionHandle(script.TangentA, Quaternion.identity);
        script.TangentB = Handles.PositionHandle(script.TangentB, Quaternion.identity);

        Handles.DrawBezier(script.pointA, script.pointB, script.TangentA, script.TangentB, Color.cyan, null, 5);

    }
 
}