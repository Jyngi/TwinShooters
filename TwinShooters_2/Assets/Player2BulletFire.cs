using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2BulletFire : MonoBehaviour
{
  	
  	public Transform firePoint;
  	public GameObject P2Bullet;
    // Update is called once per frame
    void Update()
    {
    	if (Input.GetButtonDown("Fire2"))
    	{
    		Fire();
    	}

    }

    void Fire()
    {
    	Instantiate(P2Bullet, firePoint.position, firePoint.rotation);
    }
}
