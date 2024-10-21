using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeBaseMod { Handguard, Handle, Support, Muffler, Stor, Aim, Box, Guard, Meh };

[System.Serializable]
public class BaseModWeapon
{
    public TypeBaseMod typeMod;
    public bool isIKMod = false;
    public string nameIKPoint = "IK";

    public Object basePrefab;
}
