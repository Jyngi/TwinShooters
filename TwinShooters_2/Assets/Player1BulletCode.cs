using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1BulletCode : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
    	rb.velocity = transform.up * speed;
        
    }

    void OnTriggerEnter2d (Collider2D hitInfo)
    {
    	Debug.Log(hitInfo.name);
    	Destroy(gameObject);
    }


}
