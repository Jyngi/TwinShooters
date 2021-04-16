﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerA : MonoBehaviour
{
    public float move = 5f;
    [SerializeField]
    private GameObject explosionVFX;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 pos = transform.position;
        if(Input.GetKey(KeyCode.I))
        {
            transform.Translate(new Vector2(0, move * Time.deltaTime));
        }
        if(Input.GetKey(KeyCode.J))
        {
            transform.Rotate(new Vector3(0, 0, 180f * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(new Vector3(0, 0, -180f * Time.deltaTime));
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(explosionVFX,transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(collision.gameObject);
            // Add line here to instantiate disabled player
        }
    }
}
