using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakway : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		StartCoroutine (BreakFloor ());
	}

	IEnumerator BreakFloor() {
		yield return new WaitForSeconds (3);
		Destroy (this.gameObject);
	}
}
