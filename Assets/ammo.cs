using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    public float lifeTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(this.gameObject, lifeTime);
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        hitInfo.GetComponent <Zombi>()
        Destroy(Gameobjbect);
    }
}
