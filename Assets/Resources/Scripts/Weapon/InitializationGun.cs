using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializationGun : MonoBehaviour
{
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
                    Instantiate(_bMod.basePrefab, transform);
                }  
            }  
        }
        else
        {
            Delete();
        }
    }

    public void Delete() => Destroy(this);
}
