using UnityEngine;
using System.Collections;

public class FlashSprite : MonoBehaviour {

	private SpriteRenderer _spriteRenderer;

	void Start () {
		_spriteRenderer = GetComponent<SpriteRenderer> ();
		_spriteRenderer.material.SetFloat ("_FlashAmount", 1);
	}

	void Update () {

	}
}
