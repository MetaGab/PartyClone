using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCir : MonoBehaviour {
	float timeCounter=0;
	float speed;
	[SerializeField]float width;
	[SerializeField]float height;

	Vector3 startPos;


	// Use this for initialization
	void Start () {

			speed=2;
		    startPos = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		timeCounter += Time.deltaTime*speed;

		float x = startPos.x + (Mathf.Cos(timeCounter)*width);
   		float y = startPos.y+ (Mathf.Sin(timeCounter)*height);
    	float z = startPos.z;

    	transform.position = startPos + new Vector3(x, y, z);

    	speed= speed+ .002f;

		
	}
}
