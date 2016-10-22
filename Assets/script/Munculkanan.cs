using UnityEngine;
using System.Collections;

public class Munculkanan : MonoBehaviour {
	public gameplay gameplay;
	public GameObject[] GOset;
	public GameObject orang_musuh;
	public GameObject kanan;
	private GameObject orang;
	public TimeCounter timer;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (gameplay.goo==true && kanan==null) {
			kloning ();
			gameplay.goo = false;
		}
		if (gameplay.hapus) {
			Debug.Log("update kanan"+ gameplay.hapus);
			Destroy (orang);
			Destroy (kanan);
//			StartCoroutine (upd ());
			gameplay.flagg= false;
			gameplay.hapus = false;
		}

		if (timer.timesUp)
		{
			Destroy(kanan);
			Destroy (orang);
		}
	}

	void kloning()
	{
		int[] num = gameplay.angka;
		kanan=(GameObject)Instantiate (GOset[num[2]], new Vector3(1.3f,-2.1f,0f), Quaternion.identity);
//		kanan=(GameObject)Instantiate (GOset[num[2]], transform.position, Quaternion.identity);
		orang=(GameObject)Instantiate (Resources.Load ("orangdesa1"), transform.position, Quaternion.identity);

		//		kanan.name = "orang_kanan";
		Debug.Log (num [0]+" "+num[1]+" "+num[2]+" kanan "+gameplay.angka[2]+gameplay.angka[1]+gameplay.angka[0]);
	}

	void OnMouseDown(){
		
		int[] num = gameplay.angka;

		scoremanager nilai = GameObject.FindObjectOfType(typeof(scoremanager)) as scoremanager;
		//if cek jawaban load lagu = benar maka +5 else salah
		//  Debug.Log("lagu sekarang: " + answer.tampungjawaban);

		if (num[2]==gameplay.tampungjawaban) {
			nilai.countScore += 5;
            if (timer.startingTime + Time.deltaTime * 200 > timer.time_awal)
            {
                timer.startingTime = timer.time_awal;
            }
            else
            {
                timer.startingTime += Time.deltaTime * 200;
            }
            timer.increase += 0.1f;
            Debug.Log("timer sekarang "+ timer.startingTime);
            Destroy(kanan);
			Destroy (orang);
			kanan=(GameObject)Instantiate (Resources.Load("orangmusuh"), transform.position, transform.rotation);
			Debug.Log ("kanan1");
			tunggu(1);
			Destroy (kanan);
//			tunggu (3);
			gameplay.hapus=true;
		}
		else { nilai.countScore--;
			//			Destroy(kanan);
			Debug.Log ("kanan2");
			//			Instantiate (orang_musuh, transform.position, transform.rotation);
		}
	}

	IEnumerator upd()
	{
		Debug.Log ("masuk upd kanan");
		yield return new WaitForSeconds (1);
		kloning ();
	}
	IEnumerator tunggu(int i)
	{
		yield return new WaitForSeconds (i);
	}

}
