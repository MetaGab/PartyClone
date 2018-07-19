using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {
    public float point = 0;
    public GameObject dado;
    private Move moveScript;
    private CharacterController controller;
	[SerializeField] private float speed = 10f;
	[SerializeField] private float jumpforce = 10f;
	private Vector3 velocity;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
        moveScript = dado.GetComponent<Move>();
    }
	
	// Update is called once per frame
	void Update () {
        
        Vector3 vectorMove = new Vector3(Input.GetAxis("Horizontal")*speed, 0f, Input.GetAxis("Vertical")*speed);
		velocity.y += -3.9f;
		if (controller.isGrounded){
			velocity.y = 0;
			if (Input.GetKey(KeyCode.Space)){
				velocity.y += jumpforce;
			}
		}
		controller.Move((vectorMove+velocity)*Time.deltaTime);
    }
    //la parte mas chingona del codigo
    void OnTriggerEnter(Collider wea)
    {
         print(wea.gameObject.name);
        if (wea.gameObject.name=="cara1")
        {
            point++;
            moveScript.speed++;
            print(point);
            
        }
        else
        {
            if (point==0)
            {
                print(point);   
            }
            else
            {
                point--;
                moveScript.speed--;
                print(point);
            }
            
        }
    }
}
