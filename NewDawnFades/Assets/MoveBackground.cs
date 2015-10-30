using UnityEngine;
using System.Collections;

public class MoveBackground : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey (KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
		{
		gameObject.GetComponent<Renderer>().material.mainTextureOffset+=new Vector2(0.001f,0f);
		}
	
	}
}
