using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEsfera3 : MonoBehaviour {
float timeCounter=0;
	float width;
	float height;

	Vector3 startPos;


	// Use this for initialization
	void Start () {
			height=5;
			width=4;
		     startPos = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		timeCounter += Time.deltaTime;

		float x = startPos.x + (Mathf.Cos(timeCounter)*width);
   		float y = startPos.y+ (Mathf.Sin(timeCounter)*height);
    	float z = startPos.z;

    	transform.position = startPos + new Vector3(x, y, z);
}
}
