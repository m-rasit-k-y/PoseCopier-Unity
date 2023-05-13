using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PoseCopier))]
public class PoseCopierEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        PoseCopier poseCopier = (PoseCopier)target;
        if(GUILayout.Button("Copy Pose"))
        {
            poseCopier.CopyPose();
        }

        if(GUILayout.Button("Paste Pose"))
        {
            poseCopier.PastePose();
        }
    }
}