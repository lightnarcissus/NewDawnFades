using UnityEngine;
using System.Collections;

public class MoveText : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = new Vector3 (transform.parent.gameObject.GetComponent<JingleObject> ().vertX, transform.parent.gameObject.GetComponent<JingleObject> ().vertY, transform.parent.gameObject.GetComponent<JingleObject> ().vertZ);
	
	}
}
