/*
 * This script is prepared by https://github.com/m-rasit-k-y.
*/

using System.Collections.Generic;
using UnityEngine;

public class PoseCopier : MonoBehaviour
{
    [System.Serializable]
    public struct PoseData
    {
        public Vector3 position;
        public Quaternion rotation;
    }

    public void CopyPose()
    {
        List<PoseData> poseDataList = new();

        foreach (Transform child in GetComponentsInChildren<Transform>())
        {
            PoseData poseData = new()
            {
                position = child.position,
                rotation = child.rotation
            };
            poseDataList.Add(poseData);
        }

        string jsonPoseData = JsonUtility.ToJson(new Wrapper { poses = poseDataList });
        GUIUtility.systemCopyBuffer = jsonPoseData;
    }

    public void PastePose()
    {
        string jsonPoseData = GUIUtility.systemCopyBuffer;
        Wrapper wrapper = JsonUtility.FromJson<Wrapper>(jsonPoseData);

        if (wrapper.poses.Count == GetComponentsInChildren<Transform>().Length)
        {
            int i = 0;
            foreach (Transform child in GetComponentsInChildren<Transform>())
            {
                child.position = wrapper.poses[i].position;
                child.rotation = wrapper.poses[i].rotation;
                i++;
            }
        }
        else
        {
            Debug.LogError("Clipboard data is not a valid pose data!");
        }
    }

    [System.Serializable]
    private class Wrapper
    {
        public List<PoseData> poses;
    }
}