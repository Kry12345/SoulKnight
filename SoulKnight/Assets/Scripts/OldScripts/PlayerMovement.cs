using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] float targetSpeed = 7f;
	[SerializeField] float accelRate = 2f;
	Rigidbody2D rb;
	CustomInput input;
	Vector2 moveVector = Vector2.zero;
	
	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Awake()
	{
		input = new CustomInput();
	}

	private void OnEnable()
	{
		input.Enable();
		input.Player.Movement.performed += OnMovementPerformed;
		input.Player.Movement.canceled += OnMovementCanceled;
	}

	private void OnDisable()
	{
		input.Disable();
		input.Player.Movement.performed -= OnMovementPerformed;
		input.Player.Movement.canceled -= OnMovementCanceled;
	}

	private void OnMovementPerformed(InputAction.CallbackContext value)
	{
		moveVector = value.ReadValue<Vector2>();
	}

	private void OnMovementCanceled(InputAction.CallbackContext value)
	{
		moveVector = Vector2.zero;
	}


	// Update is called once per frame
	void Update()
	{
		float uTargetSpeed = targetSpeed;

		float speedDifX = uTargetSpeed * moveVector.x - rb.velocity.x;
		float movementX = speedDifX * accelRate;

		float speedDifY = uTargetSpeed * moveVector.y - rb.velocity.y;
		float movementY = speedDifY * accelRate;

		rb.AddForce(new Vector2(movementX, movementY));
	}
	public void knockback(float x, float y, float multiplier)
	{
		Vector2 direction = new Vector2(x, y).normalized;
		rb.AddForce(direction * multiplier);
	}
}	

	
	
	
