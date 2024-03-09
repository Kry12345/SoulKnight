using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] float targetSpeed = 7f;
	[SerializeField] float accelRate = 2f;
	Rigidbody2D rb;
	
	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		float uTargetSpeed = targetSpeed;
		if (Input.GetAxisRaw("Horizontal") != 0 && Input.GetAxisRaw("Vertical") != 0)
		{
			uTargetSpeed /= 1.4f;
		}
		float speedDifX = uTargetSpeed * Input.GetAxisRaw("Horizontal") - rb.velocity.x;
		float movementX = speedDifX * accelRate;

		float speedDifY = uTargetSpeed * Input.GetAxisRaw("Vertical") - rb.velocity.y;
		float movementY = speedDifY * accelRate;

		rb.AddForce(new Vector2(movementX, movementY));
	}
	public void knockback(float x, float y, float multiplier)
	{
		print(x);
		print(y);
		Vector2 direction = new Vector2(x, y).normalized;
		rb.AddForce(direction * multiplier);
	}
}	

	
	
	
