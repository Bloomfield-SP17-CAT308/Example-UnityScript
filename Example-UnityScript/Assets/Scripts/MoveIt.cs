using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIt : MonoBehaviour {
	Vector3 initialPosition;

	public float amplitude = 4.5f;

	// Use this for initialization
	void Start () {
		initialPosition = this.gameObject.transform.position;
	}

	// Update is called once per frame
	void Update () {
		this.transform.position = initialPosition + new Vector3 (0.0f, Mathf.Sin (Time.time) * amplitude, 0.0f);
	}
}
