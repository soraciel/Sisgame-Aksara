using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]


public class gameplay : MonoBehaviour {


    public question[] pertanyaan;
    private static List<question> belumdijawab;
	public GameObject coba;
    private question currentpertanyaan;
    public int tampungjawaban;
	public int[] angka;
	public bool hapus = false;
	public bool flagg=false;
	public bool play=false;
	public bool timeon=false;
	public bool goo = false;
    public TimeCounter timer;
    public Image timebar;
    public Image background;
    // Use this for initialization
	void Start () {
		
	}

	void Update(){
		if (play) {
			go ();


            RectTransform rt = timebar.GetComponent(typeof(RectTransform)) as RectTransform;
            rt.sizeDelta = new Vector2(0, 29);

            RectTransform rt2 = background.GetComponent(typeof(RectTransform)) as RectTransform;
            rt2.sizeDelta = new Vector2(0, 29);

            //timer.tinggi = 29;
            play = false;
		}
		if (hapus==true && flagg==false) {
			currentpertanyaan.suara.Stop();
			go ();
			flagg = true;
			tunggu (10);
		}
	}

	void go()
	{   

			if (belumdijawab == null || belumdijawab.Count == 0) {
				belumdijawab = pertanyaan.ToList<question> ();
			}

			getRandomPertanyaan ();

			currentpertanyaan.suara.Play ();
			tampungjawaban = currentpertanyaan.jawaban;
			Debug.Log ("lagu sekarang: " + tampungjawaban);

			int posbenar = Random.Range (0, 2);
			for (int i = 0; i <= 2; i++) {
				int angkalain;
				if (i == posbenar)
					angka [i] = tampungjawaban;
				else {
					angkalain = Random.Range (0, 2);
					while (angkalain == tampungjawaban) {
						angkalain = Random.Range (0, 2);
					}
					angka [i] = angkalain;
				}
			}
		goo = true;
	}

    void getRandomPertanyaan()
    {
        int indexRandom = Random.Range(0, belumdijawab.Count);
        currentpertanyaan = belumdijawab[indexRandom];
        belumdijawab.RemoveAt(indexRandom);
    }

	IEnumerator tunggu(int i)
	{
		yield return new WaitForSeconds (i);
	}


	
	
}
