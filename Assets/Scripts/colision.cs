using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour {

	     void  OnCollisionEnter(Collision col)
    										 {
         if(col.gameObject.tag == "fuego")
         {
             Destroy(gameObject);
             print("collision detected!");
         }
     }

}
