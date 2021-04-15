using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1BulletFire : MonoBehaviour
{
  	
  	public Transform firePoint;
  	public GameObject P1Bullet;
    // Update is called once per frame
    void Update()
    {
    	if (Input.GetButtonDown("Fire1"))
    	{
    		Fire();
    	}

    }

    void Fire()
    {
    	Instantiate(P1Bullet, firePoint.position, firePoint.rotation);
    }
}
