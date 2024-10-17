using UnityEngine;

public enum TypeBullet { Player, Enemy };

[CreateAssetMenu(menuName = "Gun", fileName = "Null")]
public class Gun : Weapon
{
    [Header("Modification")]
    public BaseModWeapon[] baseMods;
    public Vector3[] pointMods;
    [Header("Audio")]
    public AudioClip soundShoot;
    public AudioClip soundSpusk;
    [Header("Shooting")]
    public int ammo;
    public float verticalRecoil;
    public float verticalRecoilSit;

    public ListBaseMod listBaseMod;

    private int currentAmmos = 0;

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
