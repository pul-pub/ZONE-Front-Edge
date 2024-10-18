using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AnimationPoint
{
    public Transform tr;

    public Transform targetTr;
    public Vector3 targetVec;

    public Vector3 rotation = Vector3.zero;

    public AnimationPoint(Transform tr, Vector3 targetVec, Transform targetTr = null, Vector3 rotation = default)
    {
        this.tr = tr;

        this.targetVec = targetVec;
        if (targetTr != null)
            this.targetTr = targetTr;

        this.rotation = rotation;
    }
}
