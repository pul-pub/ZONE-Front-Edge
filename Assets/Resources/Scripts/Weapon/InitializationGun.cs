using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializationGun : MonoBehaviour
{
    private ListTransformsIK _listIK = new ListTransformsIK();
    private TypeBaseMod[] _types = new TypeBaseMod[8]
    {
        TypeBaseMod.Guard,
        TypeBaseMod.Meh,
        TypeBaseMod.Handguard,
        TypeBaseMod.Handle,
        TypeBaseMod.Support,
        TypeBaseMod.Muffler,
        TypeBaseMod.Stor,
        TypeBaseMod.Aim
    };

    public void Init(ListBaseMod _list)
    {
        BaseModWeapon _bMod;

        if ((_bMod = _list.GetMod(TypeBaseMod.Box)) != null)
        {
            Instantiate(_bMod.basePrefab, transform);

            for (int i = 0; i < _types.Length; i++)
            {
                if ((_bMod = _list.GetMod(_types[i])) != null)
                {
                    GameObject _gObj = Instantiate(_bMod.basePrefab, transform) as GameObject;

                    if (_bMod.isIKMod)
                        foreach (Transform t in _gObj.GetComponentsInChildren<Transform>())
                            if (t.name == _bMod.nameIKPoint)
                            {
                                _listIK.Add(t, _bMod.typeMod);
                                Debug.Log("f");
                            }
                                
                }  
            }  
        }
        else
        {
            Delete();
        }
    }

    public ListTransformsIK GetPointIK() => _listIK;

    public void Delete() => Destroy(this);
}
