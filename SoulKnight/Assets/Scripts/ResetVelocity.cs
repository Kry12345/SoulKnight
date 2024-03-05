using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetVelocity : MonoBehaviour
{
	public wallDirection direction;
	PlayerMovement playerMovement;

	void Start()
	{
		playerMovement = gameObject.transform.parent.GetComponentInParent<PlayerMovement>();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.layer == 3)
		{
			if(direction == wallDirection.Right)
			{
				playerMovement.collisionRight(true);
			}
			else if (direction == wallDirection.Left)
			{
				playerMovement.collisionLeft(true);
			}
			else if (direction == wallDirection.Up)
			{
				playerMovement.collisionUp(true);
			}
			else
			{
				playerMovement.collisionDown(true);
			}
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if(col.gameObject.layer == 3)
		{
			if(direction == wallDirection.Right)
			{
				playerMovement.collisionRight(false);
			}
			else if (direction == wallDirection.Left)
			{
				playerMovement.collisionLeft(false);
			}
			else if (direction == wallDirection.Up)
			{
				playerMovement.collisionUp(false);
			}
			else
			{
				playerMovement.collisionDown(false);
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