using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {

	public float startingTime;
	public GameObject image_gameOver;
	public bool timesUp;
	public gameplay gameplay;
	private bool stop=false;
    public float increase;
	public Image timebar;
    public float time_awal;
//	private bool muncul;


    // Use this for initialization
    void Start () {
        
		
		timesUp = false;
        increase = 1f;
        time_awal = startingTime;

	}

	// Update is called once per frame
	void Update () {
		//  while (!timesUp) { 
//		if (gameplay.timeon == true && muncul == false) {
//			timebar = (GameObject)Instantiate (Resources.Load ("timebar"));
//			muncul = true;
//		}

		if (timesUp == false && gameplay.timeon == true && startingTime > 0) { //startingTime--;
			startingTime -= Time.deltaTime*increase;
		}

	//	timebar = new Vector2 (rectSize.x)
        setBar(startingTime);

		if (startingTime <= 0 && stop==false)

		{
			Debug.Log("ini muncul game over");
			image_gameOver = (GameObject)Instantiate(Resources.Load("BUYAR!"));
			timesUp = true;
			stop = true;

		}
		//}
	}

 

    void setBar(float startingTime)
    {
            timebar.transform.localScale = new Vector3(startingTime / time_awal, timebar.transform.localScale.y, timebar.transform.localScale.z);
        
    }
}
