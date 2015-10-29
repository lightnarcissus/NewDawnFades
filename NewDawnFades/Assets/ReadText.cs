using UnityEngine;
using System;
using System.Collections;
using System.IO;


public class ReadText : MonoBehaviour {
	StreamReader sr = new StreamReader("/Users/Ansh/Desktop/music.txt");
	public static string str;
	public static float num;
	// Use this for initialization
	void Start () {
		//str = sr.ReadLine ();
		//str = sr.();
		//sr.Close();    
	}
	
	// Update is called once per frame
	void Update()
	{
		StreamReader sr = new StreamReader("/Users/Ansh/Desktop/music.txt");
		str = sr.ReadLine();
	}
	void LateUpdate () {
		//Console.WriteLine(str);

		//Debug.Log (str);
		float.TryParse(str,out num);
		Debug.Log (num);
	}
}