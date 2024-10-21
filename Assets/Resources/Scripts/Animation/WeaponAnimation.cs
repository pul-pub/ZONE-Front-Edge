using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAnimation : MonoBehaviour
{
    [Header("Target")]
    [SerializeField] private Transform weaponObj;
    [Header("IK")]
    [SerializeField] private Transform handL;
    [SerializeField] private Transform handR;
    [SerializeField] private Transform weaponPoint;

    private ListTransformsIK _listIK;
    private Transform[] listTargets = new Transform[2];

    private void Update()
    {
        handL.position = listTargets[0].position;
        handR.position = listTargets[1].position;
    }

    public void SetListIK(ListTransformsIK _list)
    {
        _listIK = _list;

        listTargets[0] = _listIK.GetTransform(TypeBaseMod.Handguard);
        listTargets[1] = _listIK.GetTransform(TypeBaseMod.Handle);
    }
}
