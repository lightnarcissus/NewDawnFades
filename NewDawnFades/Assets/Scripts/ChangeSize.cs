using UnityEngine;
using System.Collections;

public class ChangeSize : MonoBehaviour {

    private int randTexture = 0;
    public Texture[] textList;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (ReadText.num * ReadText.freqNum > 0.5) {
            randTexture = Random.Range(0, 9);
            GetComponent<Renderer>().material.mainTexture = textList[randTexture];
			transform.localScale=new Vector2(ReadText.num*1f,ReadText.freqNum*0.85f);
		}
	
	}
}
