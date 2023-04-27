using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutDenerator : MonoBehaviour {
	public GameObject[] donutObj;
	public float TimeInterval;
	float minX, maxX;
	private Transform bakeTransform;
	
	void Start () {
        bakeTransform = GetComponent<Transform>();
	}
	public void BakeDonuts(bool current)
	{
		if (current) { 
			StartCoroutine(Generet()); 
		}
		else { StopAllCoroutines(); }
	}
	IEnumerator Generet()
	{
		while (true) {
			minX = bakeTransform.position.x - 15;
			maxX = bakeTransform.position.x + 15;
			var number = Random.Range(minX, maxX);
			var position = new Vector2(number, transform.position.y);
			Instantiate(donutObj[Random.Range(0, donutObj.Length)], position, Quaternion.identity, bakeTransform);
			yield return new WaitForSeconds(TimeInterval);
		
		}
	
	}

}
