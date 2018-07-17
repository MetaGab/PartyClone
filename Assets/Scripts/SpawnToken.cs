using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnToken : MonoBehaviour {
    public GameObject token;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Token")
        {
            Destroy(other.gameObject);
            Vector3 spawnPosition = new Vector3(0f, 10f, 0f);
            Quaternion spawnRotation = Quaternion.identity;
            GameObject rs = Instantiate(token, spawnPosition, spawnRotation);
        }  
    }
}
