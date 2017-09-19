using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class SquareController : MonoBehaviour {

	[SerializeField]
	protected float moveSpeed = 10f;

	protected Rigidbody rb;

	protected void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	protected void Update () {
		KeyboardInput ();
	}

	private void KeyboardInput() {
		float h = Input.GetAxis ("Horizontal");

		rb.velocity = h * Vector3.right * moveSpeed;
	}

}
