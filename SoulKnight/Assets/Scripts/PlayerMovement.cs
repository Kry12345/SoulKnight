using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 1.01f;
	double exponentX, exponentY;
	float speedX, speedY;
	bool isRunningX = false;
	bool isRunningY = false;
	Rigidbody2D rb;
	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		if (!isRunningX)
		{
			StartCoroutine(moveX());
		}
		if(!isRunningY)
		{
			StartCoroutine(moveY());
		}

		rb.velocity = new Vector2(speedX, speedY);
	}
	
	IEnumerator moveX()
	{
		isRunningX = true;
		if (Input.GetAxisRaw("Horizontal") < 0)
		{
			if (exponentX < 10 && exponentX > 0)
			{
				speedX = -(float)Math.Pow(speed, Math.Abs(exponentX));
				exponentX++;
			}
			else if (exponentX == 0)
			{
				speedX = 0;
				exponentX++;
			}
			else if (exponentX != 10)
			{
				speedX = (float)Math.Pow(speed, Math.Abs(exponentX));
				exponentX++;
			}
			yield return new WaitForSeconds(0.025f);
		}
		else if (Input.GetAxisRaw("Horizontal") > 0)
		{
			if (exponentX > -10 && exponentX <= 0)
			{
				speedX = (float)Math.Pow(speed, Math.Abs(exponentX));
				exponentX--;
			}
			else if (exponentX == 0)
			{
				speedX = 0;
				exponentX--;
			}
			else if (exponentX != -10)
			{
				speedX = -(float)Math.Pow(speed, Math.Abs(exponentX));
				exponentX--;
			}
			yield return new WaitForSeconds(0.025f);
		}
		else if (Input.GetAxisRaw("Horizontal") == 0)
		{
			if (exponentX < 0)
			{
				exponentX++;
				speedX = (float)Math.Pow(speed, Math.Abs(exponentX));
			}
			else if (exponentX > 0)
			{
				exponentX--;
				speedX = -(float)Math.Pow(speed, Math.Abs(exponentX));
			}
			else
			{
				speedX = 0f;
			}
			
			yield return new WaitForSeconds(0.05f);
		}
		isRunningX = false;
	}
	
	IEnumerator moveY()
	{
		isRunningY = true;
		if (Input.GetAxisRaw("Vertical") < 0)
		{
			if (exponentY < 10 && exponentY > 0)
			{
				speedY = -(float)Math.Pow(speed, Math.Abs(exponentY));
				exponentY++;
			}
			else if (exponentY == 0)
			{
				speedY = 0;
				exponentY++;
			}
			else if (exponentY != 10)
			{
				speedY = (float)Math.Pow(speed, Math.Abs(exponentY));
				exponentY++;
			}
			yield return new WaitForSeconds(0.025f);
		}
		else if (Input.GetAxisRaw("Vertical") > 0)
		{
			if (exponentY > -10 && exponentY <= 0)
			{
				speedY = (float)Math.Pow(speed, Math.Abs(exponentY));
				exponentY--;
			}
			else if (exponentY == 0)
			{
				speedY = 0;
				exponentY--;
			}
			else if (exponentY != -10)
			{
				speedY = -(float)Math.Pow(speed, Math.Abs(exponentY));
				exponentY--;
			}
			yield return new WaitForSeconds(0.025f);
		}
		else if (Input.GetAxisRaw("Vertical") == 0)
		{
			if (exponentY < 0)
			{
				exponentY++;
				speedY = (float)Math.Pow(speed, Math.Abs(exponentY));
			}
			else if (exponentY > 0)
			{
				exponentY--;
				speedY = -(float)Math.Pow(speed, Math.Abs(exponentY));
			}
			else
			{
				speedY = 0f;
			}
			
			yield return new WaitForSeconds(0.05f);
		}
		isRunningY = false;
		print(speedY);
	}
}
