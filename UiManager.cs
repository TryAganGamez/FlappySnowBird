using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

	public Button[] buttons;
	bool gameOver;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void gameOverActivated(){
		gameOver = true;
		foreach (Button button in buttons) {
			button.gameObject.SetActive(true);
		}
	}


	public void Play(){
		SceneManager.LoadScene ("one");	
	}

	public void Pause(){

		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		} 
		else if (Time.timeScale == 0) {
			Time.timeScale = 1;
		}
	}
	public void Menu(){

		SceneManager.LoadScene ("menu");
	}
	public void Exit(){
		Application.Quit ();

	}
}
