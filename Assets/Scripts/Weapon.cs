using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint, firePointCrouch;
    public PlayerMovement playerMovement;
    public GameObject bulletPrefab;

    private float nextTimeOfFire = 0f;
    public float fireRate = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot(playerMovement.crouch);
            nextTimeOfFire = Time.time + 1;
        }
    }

    void Shoot(bool isCrouching)
    {
        if(!isCrouching)
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        else
            Instantiate(bulletPrefab, firePointCrouch.position, firePointCrouch.rotation);
        //shooting logic
    }
}
