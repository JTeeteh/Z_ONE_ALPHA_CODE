using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombi_Test : MonoBehaviour
{
    [SerializeField]
    Transform Player;
    [SerializeField]
    float agrorange;
    [SerializeField]
    float speed;


    [SerializeField]
    float kolength;
    [SerializeField]
    float koforce;


    [SerializeField]
    float HP;
    bool lookother;
    bool IsAgro;
    Rigidbody2D rb2d;

    public Animator animator;
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").transform;
        rb2d = GetComponent<Rigidbody2D>();
        spawner = GameObject.Find("Spawner");

    }

    // Update is called once per frame
    void Update()
    {
        float distoplayer = Vector2.Distance(transform.position, Player.position);
        print(distoplayer);
        if (distoplayer < agrorange)
        {
            IsAgro = true;
            chase();
        }
        else
        {
            patrol();
            IsAgro = false;
            //stopchase();
        }



    }

    void chase()
    {

        if (transform.position.x < Player.position.x)
        {
            rb2d.velocity = new Vector2(speed, 0);
            transform.localScale = new Vector2(1, 1);
            lookother = false;
        }
        else if (transform.position.x > Player.position.x)
        {
            rb2d.velocity = new Vector2(-speed, 0);
            transform.localScale = new Vector2(-1, 1);
            lookother = true;
        }
    }

    void patrol()
    {
        if (lookother == false)
        {
            rb2d.velocity = new Vector2(speed / 4, 0);

        }
        else
            rb2d.velocity = new Vector2(-speed / 4, 0);

    }

    public void OnAgro()
    {
        //animator.SetBool("IsAgro", IsAgro);
    }

    /*
    private void flip()
    {
       transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
       speed *= -1;
    }
    
    */
    private void stopchase()
    {
        rb2d.velocity = new Vector2(0, 0);
    }




    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Bullet")
        {
            HP -= 1.0f;
            DestroySelf(collision.gameObject);
            rb2d.velocity = new Vector2(kolength, koforce);


        }
        if (HP <= 0)
        {
            spawner.GetComponent<Spawner>().enemyList.Remove(gameObject);
            Destroy(gameObject);
            //ScoreUI.scoreValue += 10;
        }


    }

    private void DestroySelf(GameObject collidedObject)
    {
        Destroy(collidedObject);
    }



}