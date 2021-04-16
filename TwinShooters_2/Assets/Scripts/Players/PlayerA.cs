using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerA : MonoBehaviour
{
    public float move = 5f;
    [SerializeField]
    private GameObject explosionVFX;
    public bool isAlive;
    public Transform spawnPoint;
    [SerializeField]
    
    // Start is called before the first frame updat

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

    Debug.Log(isAlive);
    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            isAlive = false;
            Debug.Log("ya died");

            Instantiate(explosionVFX,transform.position, Quaternion.identity);            
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            Destroy(collision.gameObject);
            Resurrect();


            // Add line here to instantiate disabled player
        }
    }
    public void Resurrect()
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
