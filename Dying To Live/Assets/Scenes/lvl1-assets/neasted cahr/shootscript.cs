using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootscript : MonoBehaviour {
	public Transform gun;
	public GameObject bullet;
	public float bulletspeed;
	public Transform shootpoint;
	public Transform firerate;
	float readyreadyfornextshot;
	Vector2 direction;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		direction = mousepos - (Vector2)gun.position;
		FaceMouse();

		if (Input.GetMouseButtonDown(0))
		{
			shoot();
		}
	}
	void FaceMouse()
    {
		gun.transform.right = direction;
    }
	void shoot ()
    {
		 GameObject bullets = Instantiate(bullet,shootpoint.position,shootpoint.rotation);
		bullets.GetComponent<Rigidbody2D>().AddForce(bullets.transform.right * bulletspeed);		
    }
}
