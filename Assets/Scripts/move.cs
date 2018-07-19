using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float speed = 3f;
	
	void Start () {
		
	}
	
	
	void Update () {

        //print("hola soy un cubo");
        transform.Rotate(new Vector3(-30f, 0f, 0f) * Time.deltaTime * speed);
	}
}
