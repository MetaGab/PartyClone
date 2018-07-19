using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    private bool grounded = true;
    private Rigidbody rb;
    void Start () {
        GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();

    }
	
	void Update () {
        if (Input.GetKey(KeyCode.Space) && grounded==true){
            rb.AddForce(0, 500f, 0);
            grounded = false;
        }
        
    }
}
