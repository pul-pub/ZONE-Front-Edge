using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] private Object initGunObj;
    [SerializeField] private Gun gun;

    private WeaponAnimation _weaponAnimation;

    private ListTransformsIK[] _list = new ListTransformsIK[2];

    private void Awake()
    {
        _weaponAnimation = GetComponent<WeaponAnimation>();

        gun.Init();

        GameObject _gObj = Instantiate(initGunObj, Vector3.zero, new Quaternion(0,0,0,0), transform) as GameObject;

        InitializationGun _initGun = _gObj.GetComponent<InitializationGun>();
        _initGun.Init(gun.listBaseMod);
        _list[0] = _initGun.GetPointIK();
        _initGun.Delete();

        _weaponAnimation.SetListIK(_list[0]);
    }

    private void Update()
    {
        
    }
}
