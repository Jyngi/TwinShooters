using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWall : MonoBehaviour
{
    Vector2 pos;
    public float downSpeed = 0.3f;
    WallSpawn w;

    // Start is called before the first frame update
    void Start()
    {
        w = GameObject.FindGameObjectWithTag("WallSpawn").GetComponent<WallSpawn>();
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos.y -= downSpeed * Time.deltaTime;
        transform.position = pos;

        if (transform.position.y <= -7f)
        {
            Destroy(transform.parent.gameObject);
            w.deleteWall();
        }
    }
}
