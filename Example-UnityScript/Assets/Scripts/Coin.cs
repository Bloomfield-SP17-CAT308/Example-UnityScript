using UnityEngine;

public class Coin : MonoBehaviour {
	// How much to rotate the coin on every frame frame
	Vector3 rotate = new Vector3(10.0f, 0.0f, 0.0f);

	void Update () {
		// Rotate the coin on every frame.
		transform.Rotate( rotate );
	}
	
	void OnTriggerEnter(Collider other) {
		//  Find the game controller
		GameController gc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();

		// Issue the FoundCoin() method
		gc.FoundCoin();

		// Remove this coin from the world
		Destroy(this.gameObject);
	}
}