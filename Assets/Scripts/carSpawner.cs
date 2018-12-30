using UnityEngine;
using System.Collections;

public class carSpawner : MonoBehaviour {

	public GameObject[] cars;
	int carNo;
	public float maxPos = 2.2f;
	public float delayTimer = 1f; // cette variable sera utilisé pour regénérer la voiture de l'ennemie chaque 1 seconde
	float timer;


	// Use this for initialization


	void Start () { // ay 7aja t7otha fl void Start() ray "will be called just 1 time"

		timer = delayTimer;
	}

	// rq : lorsqu'on utilise le "prefab" dans l'engine Unity , et pas içi dans le code , son utilité est lorsque 
	// .. on va réutiliser un objet plusieur fois dans le jeux,alors on le met dans un "prefab"
	// l'objet "Black_viber" est dans "l'hierarchie" de l'engine Unity,aprés avoir qu'il été mis du dossier "sprites" vers "l'hierarchie"  , alors ...
	// maintenant on va deplacer l'objet "Black_viber" du "l'hierarchie" vers "prefabs" et le supprimer du "l'hierarchie" , 
	// ... car ma3sh 7achtna bih fl "hierarchie" puisk najmou n3awdou "njbdouh" ml "prefabs" 5attrou wala du type "prefab" auto ..
	// ba3d m na9lnéh ml "hierarchie" l dossier créee déja "prefab" (deja k tn9lou w ywali "prefab" l'objet esmou sera souligné en blue fl "hierarchie")
	// Update is called once per frame


	void Update () { // ay 7aja t7otha fl void Update() ray "will be called repeatly , again & again"
	
		timer -= Time.deltaTime; // pour décrémenter "timer"  in "Time" (fl wa9t) aprés chaque 1 seconde => after 1 seconde the "timer"=0
		if (timer <= 0) {
			Vector3 carPos = new Vector3 (Random.Range (-2.2f, 2.0f),transform.position.y,transform.position.z);// position varie aléatoirement sur l'axe x=[-2.2,2] et sur l'axe y et z,elle prend la position auto du l'objet "CarSpawnerPosition"
			carNo=Random.Range(0,6); // tableau de valeurs entre [0..6[ qui seront prise aléatoirement vers tableau du 6 (du: 0 -> 5) éléments "GameObject[] cars" 
			Instantiate (cars[carNo],carPos,transform.rotation); // on va instancier la position et la rotation du objet voiture
			timer = delayTimer; // c a d : lorsque "timer<=0" => une voiture sera crée et aprés sa (lorsque : timer= 0 seconde), le timer va reprendre again la valeur 1 seconde (timer=1 seconde) pour que le boucle commence again
		}

	}
}
