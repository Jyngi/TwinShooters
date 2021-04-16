using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchB : MonoBehaviour
{
    GameObject parent;
    WallSpawn w;

    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent.gameObject;
        w = GameObject.Find("Left Wall Spawn").GetComponent<WallSpawn>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player B Bullet")
        {
            w.deleteWall();
            Destroy(collision.gameObject);
            Destroy(parent);
        }
    }
}
