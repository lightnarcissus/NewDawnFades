using UnityEngine;
using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;

public class ReadText : MonoBehaviour {
//	StreamReader sr = new StreamReader("music.txt");
  //  StreamReader fq = new StreamReader("freq.txt");
	public static string str;
	public static float num;
	public static float freqNum;
	public GameObject renderQuad;
	public static float timer=0f;
	public GameObject text;
	public static bool close=false;
	public GameObject dirLight;
    public TextAsset music;
    public TextAsset freq;
    private string pathName = "music.txt";
    private string freqPathName = "freq.txt";
    private int musicCount = 0;
    private int freqCount = 0;
    private string[] musicString;
    private string[] freqString;
	// Use this for initialization
	void Start () {
		renderQuad.SetActive (false);
        musicString = music.text.Split("\n"[0]);
        freqString=freq.text.Split("\n"[0]);
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
     /*   sr = new StreamReader(pathName);
        fq = new StreamReader(freqPathName);
        	str = sr.ReadLine();
        freqString = fq.ReadLine ();
        */
	}
	void LateUpdate () {
        //Console.WriteLine(str);

        //Debug.Log (str);
        float.TryParse(freqString[freqCount], out freqNum);
        float.TryParse(musicString[musicCount], out num);
        freqCount++;
        musicCount++;
        //float.TryParse(str,out num);
		//float.TryParse(freqString,out freqNum);
		//Debug.Log (num);
       // Debug.Log(freqNum);
	}
}