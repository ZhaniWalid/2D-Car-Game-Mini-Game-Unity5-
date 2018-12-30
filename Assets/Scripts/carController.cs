using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {

	public float carSpeed;
	public float maxPos = 2.2f;
	Vector3 position;
	public uiManager ui;

	// Use this for initialization
	void Start () {
		//ui = GetComponent<uiManager>; // let you use the "uiManager" Script that's in the game
		position = transform.position; // te5ou la position par défaut de l'objet
	}
	
	// Update is called once per frame
	void Update () {
	
		position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime; // k ktebna "position.x" w "Input.GetAxis ("Horizontal")" c a d besh nst3mlou les fleshes gauches & droite + la position incrémente k ktbna "position.x +="
		position.x  = Mathf.Clamp (position.x,-2.2f,2.0f); // "Mathf.Clamp" traj3lna l valeur de "position.x" limitée entre [-2.2,2]
		transform.position = position; // assign the "position variable" to the "original transform position of the car"
	}

	void OnCollisionEnter2D (Collision2D col) {
	
		if (col.gameObject.tag == "Enemy Car") {
		
			Destroy (gameObject); // mais lahné 3akks eli f nafs fonction mawjouda f "EnemyDestroyer.cs"..
			// l karhba eli chnl3bou béha hia eli besh tetkssr wa9t chtmss f karhbha o55ra (autre objet)...
			// pour céla 3mlna "Destroy (gameObject)" mch "Destroy (col.gameObject)" kima fl autre cas eli fasrtha
			ui.gameOverActivated();
		}
	}
}
