using UnityEngine;
using System.Collections;

public class EnemyDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col) {
	  
		if (col.gameObject.tag == "Enemy Car") {
		
			Destroy (col.gameObject); // lahné 3mlna "Destroy (col.gameObject)" 5attr l car Enemy wa9t chtousl... 
			// lil 7it (eli hwa marbout bl fichier adheya EnemyDestroyer.cs) w tmessou...
			//eli ba3d l kayéss wa9tha besh tetkssr,mch l 7it ytkssr (fl cas hédhi l 7it ytkssr Destroy(gameObject))
		}
	}
}
