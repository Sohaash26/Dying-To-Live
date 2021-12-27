using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BulletController : MonoBehaviour {
	public float speed;
	
	// Use this for initialization
	void Start()
	{
		 Controller Player;
	Player = FindObjectOfType<Controller>();
		if (Player.transform.localScale.x < 0)
		{
			speed = -speed;
			transform.localScale = new Vector3(-(transform.localScale.x),transform.localScale.y,transform.localScale.z);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
			Destroy(other.gameObject);
			Destroy(this.gameObject);

		}
	}
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);

	}
}
