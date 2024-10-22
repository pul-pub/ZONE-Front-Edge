using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTransformsIK
{
    private Transform weapon;
    private List<Transform> transforms = new List<Transform>();
    private List<TypeBaseMod> typeMod = new List<TypeBaseMod>();

    public void Add(Transform _tr, TypeBaseMod _type)
    {
        transforms.Add(_tr);
        typeMod.Add(_type);
    }

    public Transform GetTransform(TypeBaseMod _type)
    {
        for (int i = 0; i < typeMod.Count; i++)
            if (typeMod[i] == _type)
                return transforms[i];

        return null;
    }
}
