using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameMySay : MonoBehaviour {
	public int frames=0;
	// Use this for initialization
	void Start () {
		Debug.Log("Hello! you are:"+ frames + " frame");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Frame: " + frames);
		frames++;

    }
}
