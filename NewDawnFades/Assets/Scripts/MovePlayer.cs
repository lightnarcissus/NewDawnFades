using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	private Animator playerAnim;
	public GameObject dirLight;
    private bool obj = false;
	//public GameObject forest;
	//public GameObject movequad;
	// Use this for initialization
	void Start () {

        
            playerAnim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		dirLight.GetComponent<Light> ().color = new Color (ReadText.num * 1f, ReadText.freqNum * 1f,ReadText.num * 1f);

//		if(Input.GetKey (KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
//		{
//			transform.position+=new Vector3(-0.01f,0f,0f);
//		}
		if(Input.GetKey (KeyCode.Space) && !ReadText.close)
		{
			transform.position+=new Vector3(0.0004f,0f,0f);
			//forest.GetComponent<Renderer>().material.mainTextureOffset+=new Vector2(0.001f,0f);
			//playerAnim.SetBool("WalkRight",true);
            
                GetComponent<Animator>().SetBool("Walking", true);
            
			//playerAnim.Play("WalkRight");
		}
        else
        {
           
                GetComponent<Animator>().SetBool("Walking", false);
           
        }
//		else if(Input.GetKey (KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
//		{
//			transform.position+=new Vector3(0f,0.01f,0f);
//		}
//		else if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
//			transform.position += new Vector3 (0f, -0.01f, 0f);
//		} else {
//			playerAnim.Play("Idle");
//		}
	
	
	}
}
