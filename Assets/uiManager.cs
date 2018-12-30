using UnityEngine;
using System.Collections;
using UnityEngine.UI; // let you use the variables of types : Text

public class uiManager : MonoBehaviour {

	public Text scoreText;
	bool gameOver;
	int score;

	// Use this for initialization
	void Start () {
		gameOver = false;
		score = 0;   	
		// this function "InvokeRepeating",let you to repeat the call of another function in a number of time 
	   // (how repeadtly call a function=9adh mn marra bsh tet3awd c a d)
	   // besh t3ayt l fonction "scoreUpdate()"
		// à partir du temp=1seconde
		// et elle répète l'appelle du "scoreUpdate()" chaque 0.8 seconde
		// => début : lorsque temp=1seconde et répétetion chaque 0.8 seconde

		InvokeRepeating ("scoreUpdate", 1.0f, 0.8f);
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score;
	}

	void scoreUpdate(){
		if (gameOver == false) {
			score += 1;
		}
	}

	public void gameOverActivated(){
		gameOver = true;
	}
	public void Play()
	{
		Application.LoadLevel ("level1");
	}

	public void Pause()
	{
		if (Time.timeScale == 1) {  // Means that the game is actually runing
			Time.timeScale = 0;  // Pause The Game
		} else if (Time.timeScale == 0) { // Means that the game is actually not runing (paused)
			Time.timeScale = 1;  // Resume The Game
		}

	}
	                 
}
