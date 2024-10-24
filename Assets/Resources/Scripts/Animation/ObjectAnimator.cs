using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAnimator
{
    public IEnumerator MoveAnimation(AnimationPoint[] listPoints, float speedAnimation = 3f, float _accuracy = 0.0001f)
    {
        for (int i = 0; i < listPoints.Length; i++)
        {
            if (listPoints[i].targetTr != null)
            {
                while (IsOnPoint(listPoints[i].tr.position, listPoints[i].targetTr.position, true, _accuracy) && Quaternion.Angle(listPoints[i].tr.rotation, Quaternion.Euler(listPoints[i].rotation)) >= _accuracy)
                {
                    listPoints[i].tr.position = Vector3.MoveTowards(listPoints[i].tr.position, listPoints[i].targetTr.position, speedAnimation * Time.deltaTime);

                    listPoints[i].tr.rotation = Quaternion.RotateTowards(listPoints[i].tr.rotation, Quaternion.Euler(listPoints[i].rotation), speedAnimation * Time.deltaTime);
                    yield return new WaitForEndOfFrame();
                }
            }
            else
            {
                while (IsOnPoint(listPoints[i].tr.position, listPoints[i].targetVec, true, _accuracy) && Quaternion.Angle(listPoints[i].tr.rotation, Quaternion.Euler(listPoints[i].rotation)) >= _accuracy)
                {
                    listPoints[i].tr.position = Vector3.MoveTowards(listPoints[i].tr.position, listPoints[i].targetVec, speedAnimation * Time.deltaTime);

                    listPoints[i].tr.rotation = Quaternion.RotateTowards(listPoints[i].tr.rotation, Quaternion.Euler(listPoints[i].rotation), speedAnimation * Time.deltaTime);
                    yield return new WaitForEndOfFrame();
                }
            }
        }
    }

    private bool IsOnPoint(Vector3 current, Vector3 target, bool invers = false, float range = 0.1f)
    {
        Vector3 v = current - target;

        if (v.x <= range && v.x >= -range &&
            v.y <= range && v.y >= -range &&
            v.z <= range && v.z >= -range)
        {
            if (!invers)
                return true;

            return false;
        }
        Debug.Log(v.x + " -- " + v.y + " -- " + v.z);
        if (!invers)
            return false;

        return true;
    }
}
