using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		// Find the game controller
		GameController gc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
	
		gc.ReachedEndPoint ();
	}
}
