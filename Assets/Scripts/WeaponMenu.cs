using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "WeaponMenu")]
public class WeaponMenu : ScriptableObject
{
    public Sprite currentWeaponSpr;
    public GameObject bulletPrefab;
    public float fireRate = 1;
    public float Damage = 5;
    public int MaxAmmo = 30;
    private int currentAmmo;

    public void Shoot(bool isCrouching)
    {
        currentAmmo--;
        if (!isCrouching)
        {
            GameObject Bullet = Instantiate(bulletPrefab, GameObject.Find("FirePoint").transform.position, Quaternion.identity);
        }
        else
        {
            GameObject Bullet = Instantiate(bulletPrefab, GameObject.Find("FirePointCrouch").transform.position, Quaternion.identity);
        }
    }
}