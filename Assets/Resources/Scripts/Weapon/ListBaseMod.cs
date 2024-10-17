using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListBaseMod
{
    private List<BaseModWeapon> baseMods;
    private List<Vector3> pointMods;

    public void Add(BaseModWeapon _base, Vector3 _vector)
    {
        baseMods.Add(_base);
        pointMods.Add(_vector);
    }

    public BaseModWeapon GetMod(TypeBaseMod _type)
    {
        for (int i = 0; i < baseMods.Count; i++)
            if (baseMods[i].typeMod == _type)
                return baseMods[i];

        return null;
    }

    public Vector3 GetPoint(TypeBaseMod _type)
    {
        for (int i = 0; i < baseMods.Count; i++)
            if (baseMods[i].typeMod == _type)
                return pointMods[i];

        return Vector3.zero;
    }
}
