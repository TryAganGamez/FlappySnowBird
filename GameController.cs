using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public static GameController instance;
	public bool gameOver = false;
	public float scrollSpeed = -1.5f;
	private int score = 0;
	public Text scoreText;
	public Button[] buttons;

	// Use this for initialization
	void Awake () {

		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void Update (){

}	

	public void BirdScored(){
		if (gameOver) {
			return;
		}
		score++;
		scoreText.text = "Score: " + score.ToString ();

	}
	public void BirdDied(){
		gameOver = true;
		foreach (Button button in buttons) {
			button.gameObject.SetActive (true);

		}
}

	public void Play(){
		SceneManager.LoadScene("one");
	}
	public void Menu(){
		SceneManager.LoadScene ("menu");
	}
	public void Exit(){
		Application.Quit ();

	}

}