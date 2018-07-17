using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	private GameObject[] floors = new GameObject[7];

	private int dropState = 0;
	private int random;
	private float speed = 2f;
	private float timeTotal = 0; 

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		timeTotal += Time.deltaTime;

		if (dropState == 0){
			random = Random.Range(0,6);
			dropState = 1;
		}
		else if(dropState == 1){
			floors[random].transform.position = new Vector3(floors[random].transform.position.x, floors[random].transform.position.y-speed*Time.deltaTime, floors[random].transform.position.z);
			if(floors[random].transform.position.y < -4){
				dropState = 2;
			}
		}
		else if(dropState == 2){
			floors[random].transform.position = new Vector3(floors[random].transform.position.x, floors[random].transform.position.y+speed*Time.deltaTime, floors[random].transform.position.z);
			if(floors[random].transform.position.y > 0){
				floors[random].transform.position = new Vector3(floors[random].transform.position.x, 0, floors[random].transform.position.z);
				dropState = 0;
				speed += .5f;
			}
		}
	}
}
