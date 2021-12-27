using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : EnemyController
{

    void FixedUpdate()
    {
        if (isFacingRight == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "wall")
        {
            flip();
        }
        else if (collider.tag == "Enemy")
        {
            flip();

        }
        if (collider.tag == "Player")
        {
            FindObjectOfType<PlayerStats>().Takedamage(damage);
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

