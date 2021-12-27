using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;
	public bool isFacingRight;
	public KeyCode Spacebar;
	public KeyCode L;
	public KeyCode R;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;

	void flip()
	{
		transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
	}

	void Jump()
    {
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }
	void Start () {
		isFacingRight = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(Spacebar))
        {
            //Jump();
        }
        if (Input.GetKey(L))
        {
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(R))
        {
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
		if (isFacingRight)
        {
			flip();
			isFacingRight = false;
        }
		if (!isFacingRight)
		{
			flip();
			isFacingRight = true;
		}

	}
	
}
