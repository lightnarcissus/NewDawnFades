using UnityEngine;
using System.Collections;

public class ChangeSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (ReadText.num * ReadText.freqNum > 0.5) {
			transform.localScale=new Vector2(ReadText.num*1f,ReadText.freqNum*0.85f);
		}
	
	}
}
