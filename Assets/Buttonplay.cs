using UnityEngine;
using System.Collections;

public class Buttonplay : MonoBehaviour {
	public gameplay gameplay;
	private GameObject aksara;
	private GameObject menu2;

	// Use this for initialization
	void Start () {
		aksara = (GameObject)Instantiate (Resources.Load ("AKSARA"));
		menu2 = (GameObject)Instantiate (Resources.Load ("MENU2"));
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown(){
		Debug.Log ("play pressed");
//		gameplay.playpressed = true;
		gameplay.play = true;
		Destroy (aksara);
		Destroy (menu2);
		menu2 = (GameObject)Instantiate (Resources.Load ("background"));
		gameplay.timeon = true;
		Destroy (gameObject);
	}
}
