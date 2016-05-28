using UnityEngine;
using System.Collections;

public class MoveBackground : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

if (gameObject.name == "darkRoad") {
			if (Input.GetKey (KeyCode.Space) && !ReadText.close) {
				gameObject.GetComponent<Renderer> ().material.mainTextureOffset += new Vector2 (0.001f, 0f);
			}
		}	 else {
			gameObject.GetComponent<Renderer> ().material.mainTextureOffset += new Vector2 (0.001f, 0f);
		}
	
	}
}
