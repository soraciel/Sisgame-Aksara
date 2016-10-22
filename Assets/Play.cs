using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {
	public gameplay gameplay;
	// Use this for initialization
	void Start () {
		Debug.Log ("aku blm di klik");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		
		Destroy (gameObject);
		gameplay.play = true;
		Debug.Log ("aku ter klik"+gameplay.play);
	}
}
