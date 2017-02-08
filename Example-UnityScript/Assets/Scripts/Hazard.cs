using UnityEngine;

public class Hazard : MonoBehaviour {
	public bool killPlayer = true;

	// Option if this should be destroyed if touched
	public bool removeOnHit = true;

	void OnTriggerEnter(Collider other) {
		// Find the game controller
		GameController gc = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();

		if (killPlayer) {
			// Call the RespawnPlayer() method from the game controller
			gc.RespawnPlayer ();
		}

		// If the "removeOnHit" is true, then we destroy this game object to remove it from the world
		if (removeOnHit) {
			Destroy (this.gameObject);
		}
	}
}
