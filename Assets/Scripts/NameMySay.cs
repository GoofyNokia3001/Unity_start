using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameMySay : MonoBehaviour {
	public string text;
	public GameObject inputField;
	public GameObject TextImager;
	private string[] fragment = {"Sveiks", "Jauku dienu", "Hello"};
	int index;
	// Use this for initialization
	public void saveText() { 

	index = Random.Range(0, fragment.Length);

		text = inputField.GetComponent<InputField>().text;
		TextImager.GetComponent<Text>().text = fragment[index]+" "+text.ToUpper()+"!";
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

    }
}
