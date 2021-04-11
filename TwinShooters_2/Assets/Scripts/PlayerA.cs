using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerA : MonoBehaviour
{
    Rigidbody2D rb;
    public float move = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector2 pos = transform.position;
        if(Input.GetKeyDown(KeyCode.I))
        {
            rb.AddForce(move * transform.up);
        }
                
    }
}
