using UnityEngine;
using System.Collections;

public class SpriteSquish : MonoBehaviour {

	private float _counter = 0f;

	[SerializeField] private Vector2 _from,_to;
	[SerializeField] private float _time = 8f;

	public void OnTriggerEnter2D(Collider2D other) {
		InvokeRepeating ("LerpLocalScale", 0, Time.deltaTime);
	}		
		
	void LerpLocalScale() {

		if (_counter < 1) {

			_counter += Time.deltaTime * _time;

			transform.localScale = Vector2.Lerp (_from, _to, _counter);

		} else {
			_counter = 0f;
			transform.localScale = new Vector2 (1, 1);
			CancelInvoke ("LerpLocalScale");
		}

	}
}
