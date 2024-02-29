using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetVelocity : MonoBehaviour
{
	public wallDirection direction;

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.layer == 3)
		{
			if(direction == wallDirection.Right)
			{
				PlayerMovement.collisionRight(true);
			}
			else if (direction == wallDirection.Left)
			{
				PlayerMovement.collisionLeft(true);
			}
			else if (direction == wallDirection.Up)
			{
				PlayerMovement.collisionUp(true);
			}
			else
			{
				PlayerMovement.collisionDown(true);
			}
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if(col.gameObject.layer == 3)
		{
			if(direction == wallDirection.Right)
			{
				PlayerMovement.collisionRight(false);
			}
			else if (direction == wallDirection.Left)
			{
				PlayerMovement.collisionLeft(false);
			}
			else if (direction == wallDirection.Up)
			{
				PlayerMovement.collisionUp(false);
			}
			else
			{
				PlayerMovement.collisionDown(false);
			}
		}
	}
}

public enum wallDirection
	{
		Right,
		Left,
		Up,
		Down
	}