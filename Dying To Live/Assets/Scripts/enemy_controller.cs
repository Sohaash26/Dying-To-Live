using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller : MonoBehaviour {

	public bool isFacingRight = false;
	public float maxspeed = 3f;
	public int damage = 3;
	public void flip ()
    {
		isFacingRight = !isFacingRight;
		transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }
	void OnTriggerEnter2D(Collider2D other)
    {
		if (other.tag == "Player")
        {
			FindObjectOfType<player_status>().TakeDamage(damage);
        }
    }
}
