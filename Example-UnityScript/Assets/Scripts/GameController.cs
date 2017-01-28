using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	// Actual player model and such
	public GameObject player;

	// UI Element to display score
	public Text scoreHUD;

	// Stats for player
	public int score = 0;

	// Use this for initialization
	void Start () {
		if(player==null) {
			Debug.LogError(" *** ERROR: Forgot to hook up a game for 'player'! *** ");
		}
		StartNewGame();	
	}
	
	// Update is called once per frame
	void Update () {	
	
	}

	/// <summary>
	/// Starts the new game.
	/// </summary>
	public void StartNewGame() {
		score = 0;
		RespawnPlayer();
		UpdateScoreDisplay();
	}

	/// <summary>
	/// Updates the score display.
	/// </summary>
	public void UpdateScoreDisplay() {
		// IF we hooked up a Text UI element, we display the score
		if(scoreHUD) {
			scoreHUD.text = "Score: " + score;
		// Otherwise, let set a reminder in the Console
		} else {
			Debug.Log(" *** NOTE: No UI to display score! *** ");
		}
	}

	/// <summary>
	/// Respawns the player.
	/// </summary>
	public void RespawnPlayer() {
		// Find the respawn point
		GameObject respawnPoint = GameObject.FindGameObjectWithTag("Respawn");

		// Make the player's position the same as the spawn point
		player.gameObject.transform.position = respawnPoint.gameObject.transform.position;
	}

	/// <summary>
	/// When a player finds a coin.
	/// </summary>
	public void FoundCoin() {
		score += 100;
		UpdateScoreDisplay();
	}
}
