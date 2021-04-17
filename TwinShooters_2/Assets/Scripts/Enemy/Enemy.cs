using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos.y -= 2f * Time.deltaTime;
        transform.position = pos;

        if (transform.position.y < -7f)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player A Bullet" || collision.gameObject.tag == "Player B Bullet")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
