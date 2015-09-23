using UnityEngine;
using System.Collections;

public class MoveToPosition : MonoBehaviour {

	public Vector2 Velocity;
	public float Speed;
	public float MaxSpeed;

	void OnTriggerEnter2D(Collider2D other) {
		Velocity = Vector2.up * 40 * Speed * Time.fixedDeltaTime;
	}

	public void FixedUpdate() {

		var vector = -Vector2.up;

		vector *= Speed * Time.fixedDeltaTime;

		Velocity += vector;

		Velocity = new Vector2 (Mathf.Clamp (Velocity.x, -MaxSpeed, MaxSpeed), Mathf.Clamp (Velocity.y, -MaxSpeed, 30f));

		transform.Translate (Velocity);
	}
}
