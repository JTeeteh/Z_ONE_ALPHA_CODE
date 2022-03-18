using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootSpawn;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //check if the player presses the spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("spawn bullet in this part of the code");
            Instantiate(bulletPrefab, shootSpawn.position, Quaternion.identity);
        }
    }
}
