using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{

    public float speed = 3.0f;
    private Rigidbody2D _rigidbody;
    public float lifeTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.velocity = transform.right * speed;
        Destroy(this.gameObject, lifeTime);
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        hitInfo.GetComponent<Zombi>();
        Destroy(this.gameObject, lifeTime);
    }
}
