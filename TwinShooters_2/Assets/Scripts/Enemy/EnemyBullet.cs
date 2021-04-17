﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
	private Vector2 moveDirection;
	[SerializeField]
	private float moveSpeed;
    [SerializeField]
    private GameObject explosionVFX;
	private void OnEnable(){
		Invoke("Destroy", 3f);
	}
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
    public void SetMoveDirection(Vector2 dir){
    	moveDirection = dir;
    }
    private void Destroy(){
    	gameObject.SetActive(false);
    }
    private void OnDisable(){
    	CancelInvoke();
    }
    private void OnCollisionEnter2D(Collision2D collider){
        if (collider.gameObject.tag == "Player A" || collider.gameObject.tag == "Player B"){
            gameObject.SetActive(false);
        }
    }
}