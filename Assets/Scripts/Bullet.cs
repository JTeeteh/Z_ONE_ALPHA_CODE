using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;
    public float lifeTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(this.gameObject, lifeTime);
        
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }

    
}
