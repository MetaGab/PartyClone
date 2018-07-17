using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBasic : MonoBehaviour {

	Rigidbody rb;

	[SerializeField] private float speed = 10f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 moveVector = new Vector3(Input.GetAxis("Horizontal")*speed*Time.deltaTime, 0f, Input.GetAxis("Vertical")*speed*Time.deltaTime);
		rb.AddForce(moveVector); 
	}
}
