using UnityEngine;
using System;
using System.Collections;
using System.IO;


public class ReadText : MonoBehaviour {
	StreamReader sr = new StreamReader("/Users/Ansh/Documents/Github/NewDawnFades/NewDawnFades/Assets/Music/music.txt");
	public static string str;
	public string freqString;
	public static float num;
	public static float freqNum;
	// Use this for initialization
	void Start () {
		//str = sr.ReadLine ();
		//str = sr.();
		//sr.Close();    
	}
	
	// Update is called once per frame
	void Update()
	{
		StreamReader sr = new StreamReader("/Users/Ansh/Documents/Github/NewDawnFades/NewDawnFades/Assets/Music/music.txt");
		StreamReader fq = new StreamReader("/Users/Ansh/Documents/Github/NewDawnFades/NewDawnFades/Assets/Music/freq.txt");
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