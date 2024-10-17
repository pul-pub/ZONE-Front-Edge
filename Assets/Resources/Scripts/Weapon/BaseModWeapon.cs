using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeBaseMod { Handguard, Handle, Support, Muffler, Stor, Aim };

public class BaseModWeapon
{
    public TypeBaseMod typeMod;

    public Object basePrefab;
}
