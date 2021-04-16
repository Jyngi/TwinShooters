using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerB : MonoBehaviour
{
    public float move = 5f;
    [SerializeField]
    private GameObject explosionVFX;
    public bool isAlive;
    public Transform spawnPoint;
    [SerializeField]
    // Start is called before the first frame update
    
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

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            isAlive = false;
            Instantiate(explosionVFX,transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Resurrect2();

            // Add line here to instantiate disabled player
        }
        if(collision.gameObject.tag == "Enemy Bullet"){
            isAlive = false;
            Instantiate(explosionVFX,transform.position,Quaternion.identity);
            Resurrect2();
        }
        if(collision.gameObject.tag == "Player A Bullet"){
            isAlive = false;
            Instantiate(explosionVFX,transform.position,Quaternion.identity);
            Resurrect2();
        }

    }
    public void Resurrect2()
    {
        if (isAlive == false)
        {
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            Debug.Log("u back :D");
            isAlive = true;
        }        
    }

}
