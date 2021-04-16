using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1BulletCode : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody2D rb;
    //Public float bulletLife = 0f;
    // Start is called before the first frame update
    void Start()
    {
    	rb.velocity = transform.up * speed;

    }


    void Update(){

    	Destroy(gameObject,4f);
	 
	    // void OnTriggerEnter2d (Collider2D hitInfo)
    	// {
	    // 	Debug.Log(hitInfo.name);
	    	
	    // 	//if (hitInfo.gameObject.tag == "Player B")
		   //  //{
		   //  //	Destroy (gameObject.FindWithTag("Player B"));
		   //  //}
		   //  Destroy(gameObject);

    	// }
	}


}
