using System.Collections;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint, firePointCrouch;
    public PlayerMovement playerMovement;
    private GameObject bulletPrefab;
    public GameObject[] bullet;
    public GameObject[] gun;

    private float nextTimeOfFire = 0;
    public float fireRate;
    private bool canFire;
    private bool timerStarted;

    // Start is called before the first frame update
    void Start()
    {
        fireRate = 10f;
        bulletPrefab = bullet[0];
        canFire = true;
        timerStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && canFire)
            StartCoroutine(Fire());
        Debug.Log(canFire);
    }


    void Shoot(bool isCrouching)
    {
        //Debug.Log(canFire);
        if (!isCrouching)
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        else
            Instantiate(bulletPrefab, firePointCrouch.position, firePointCrouch.rotation);
        //shooting logic
    }

    IEnumerator Fire()
    {
        canFire = false;
        Shoot(playerMovement.crouch);
        yield return new WaitForSeconds(fireRate * Time.deltaTime);
        canFire = true;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Weapon")
        {
            if (target.name == gun[1].name)
            {
                bulletPrefab = bullet[1];
                fireRate = 20;
            }
            else if (target.name == gun[2].name)
            {
                bulletPrefab = bullet[2];
                fireRate = 20;
            } 

            Debug.Log("gun pick up - upgrade to rifle bullet.");
            Destroy(target.gameObject);
        }
    }
}
