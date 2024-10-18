using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WeaponManager : MonoBehaviour
{
    [SerializeField] private Object initGunObj;
    [SerializeField] private Gun gun;

    private void Awake()
    {
        gun.Init();

        GameObject _gObj = Instantiate(initGunObj, Vector3.zero, new Quaternion(0,0,0,0), transform) as GameObject;

        _gObj.GetComponent<InitializationGun>().Init(gun.listBaseMod);
    }
}
