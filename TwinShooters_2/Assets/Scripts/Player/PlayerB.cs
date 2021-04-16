﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerB : MonoBehaviour
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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector2(0, move * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 180f * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -180f * Time.deltaTime));
        }

        if (transform.position.y <= -6f){
            Instantiate(explosionVFX,transform.position, Quaternion.identity);
            Destroy(gameObject);}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(explosionVFX,transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player A Bullet")
        {
            Instantiate(explosionVFX,transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
