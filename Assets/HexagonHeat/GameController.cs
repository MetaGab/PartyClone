using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	private GameObject[] floors = new GameObject[7];

	bool dropped = false;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (!dropped){
			int random = Random.Range(0,6);
		}
	
	}
}
