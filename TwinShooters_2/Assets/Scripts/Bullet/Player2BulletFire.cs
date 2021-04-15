using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2BulletFire : MonoBehaviour
{
  	
  	public Transform firePoint;
  	public GameObject P2Bullet;
    // Update is called once per frame
    public float fireRate = 3.0f;
    public float timerVariable = 0f;
    public float timerStart = 0f;
    // Update is called once per frame
    void Update()
    {
        timerVariable += Time.deltaTime;
        Debug.Log(timerVariable);
        if(timerVariable > fireRate)
        {
            Fire();
            timerVariable = timerStart;
        }

    }

    void Fire()
    {
    	Instantiate(P2Bullet, firePoint.position, firePoint.rotation);
    }
}
