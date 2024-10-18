using System.Collections.Generic;
using UnityEngine;

public enum TypeBullet { Player, Enemy };

[CreateAssetMenu(menuName = "Gun", fileName = "Null")]
public class Gun : Weapon
{
    [Header("Modification")]
    public List<BaseModWeapon> baseMods;
    public List<Vector3> pointMods;
    [Header("Audio")]
    public AudioClip soundShoot;
    public AudioClip soundSpusk;
    [Header("Shooting")]
    public int ammo;
    public float verticalRecoil;
    public float verticalRecoilSit;

    public ListBaseMod listBaseMod;

    private int currentAmmos = 0;

    public void Init()
    {
        listBaseMod = new ListBaseMod();

        if (pointMods.Count > 0)
        {
            Debug.Log(baseMods[0].basePrefab.name);
            for (int i = 0; i < baseMods.Count; i++)
                listBaseMod.Add(baseMods[i], pointMods[i]);
        }
        else
        {
            for (int i = 0; i < baseMods.Count; i++)
                listBaseMod.Add(baseMods[i], (baseMods[i].basePrefab as GameObject).transform.position);
        }
        
    }

    public void Shoot(Object bullet, Transform parent, GameObject _pointStart, TypeBullet _type)
    {
        currentAmmos--;
    }

    public int Reload(int _ammos)
    {
        int reason = ammo - currentAmmos;
        int returnAmmos = 0;

        if (_ammos >= reason)
        {
            returnAmmos += reason;
            currentAmmos += reason;
        }
        else
        {
            currentAmmos += _ammos;
            returnAmmos = _ammos;
        }

        return returnAmmos;
    }
}
