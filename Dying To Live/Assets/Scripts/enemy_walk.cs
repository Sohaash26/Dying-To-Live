using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_walk : enemycontroller {

	void FixedUpdate()
    {
		if (isFacingRight == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2 (-maxspeed,GetComponent<Rigidbody2D>().velocity.y);
        }
		else
        {
			GetComponent<Rigidbody2D>().velocity = new Vector2 (maxspeed,GetComponent<Rigidbody2D>().velocity.y);
        }
    }

	void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Wall")
        {
            flip();
        }
        else if (collider.tag == "Enemy")
        {
            flip();
        }
        if (collider.tag == "Player")
        {
            FindObjectOfType<player_status>().TakeDamage(damage);
            flip();
        }
    }


	
}
