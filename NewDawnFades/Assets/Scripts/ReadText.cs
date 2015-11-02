using UnityEngine;
using System;
using System.Collections;
using System.IO;


public class ReadText : MonoBehaviour {
	StreamReader sr = new StreamReader("Assets/Music/music.txt");
	public static string str;
	public string freqString;
	public static float num;
	public static float freqNum;
	public GameObject renderQuad;
	public static float timer=0f;
	public GameObject text;
	public static bool close=false;
	public GameObject dirLight;
    private string pathName = "Assets/Music/music.txt";
    private string freqPathName = "Assets/Music/freq.txt";
	// Use this for initialization
	void Start () {
		renderQuad.SetActive (false);
		//str = sr.ReadLine ();
		//str = sr.();
		//sr.Close();    
	}
	
	// Update is called once per frame
	void Update()
	{
		timer += Time.deltaTime;
		if (timer > 10f && !close) {
			renderQuad.SetActive(true);
			text.SetActive (false);
		}
		if (timer > 280f) {
			close=true;
			dirLight.GetComponent<Light>().color=Color.white;

			dirLight.GetComponent<Light>().intensity=1f;
		}
		if (timer > 290f) {
			Application.Quit();
		}
		StreamReader sr = new StreamReader(pathName);
        StreamReader fq = new StreamReader(freqPathName);
		str = sr.ReadLine();
		freqString = fq.ReadLine ();
	}
	void LateUpdate () {
		//Console.WriteLine(str);

		//Debug.Log (str);
		float.TryParse(str,out num);
		float.TryParse(freqString,out freqNum);
		//Debug.Log (num);
	}
}