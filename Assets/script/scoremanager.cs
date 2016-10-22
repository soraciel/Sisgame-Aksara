using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour {

    public Text Score;
    public int countScore;
	public gameplay gameplay;
   

	// Use this for initialization
	void Start () {
        countScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(gameplay.timeon)
        Score.text = "Biji: " + countScore;
	}
}
