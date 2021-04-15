using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerA : MonoBehaviour
{
    public float move = 5f;
    
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
        if(Input.GetKeyDown(KeyCode.J))
        {
            transform.Rotate(new Vector3(0, 0, 90f));
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.Rotate(new Vector3(0, 0, -90f));
        }

    }
}
