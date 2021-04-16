using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerARespawn : MonoBehaviour
{
    private PlayerA pA; 
    public GameObject PlayerA;
    public Transform spawnPoint;
   
    // Update is called once per frame
    void Start()
    {
    	pA = GameObject.Find("Player A").GetComponent <PlayerA>();
    }


    void Update()
    {
    	if (pA.isAlive == false)
    	{
    		pA.isAlive = true;
    		//Debug.Log("resurrection");
    		transform.position = spawnPoint.position;
    		transform.rotation = spawnPoint.rotation;
    		
    	}    
    }

    /*public void deathTrigger()
    {
        isAlive = false;
        
    }*/
}
