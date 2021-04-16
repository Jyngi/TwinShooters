using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
	[SerializeField]
	private int bulletAmount = 4;

	[SerializeField]
	private float startAngle = 90f, endAngle = 270f;

    [SerializeField]
    private float enemyFireRate = 1.0f;

	private Vector2 bulletMoveDirection;

    // Start is called before the first frame update
    void Start()
    {
    	InvokeRepeating("FireBullets",0f,enemyFireRate);    
    }
    private void FireBullets(){
    	float angleStep = (endAngle - startAngle)/bulletAmount;
    	float angle = startAngle;

    	for (int i = 0; i < bulletAmount + 1; i++){
    		float dX = transform.position.x + Mathf.Sin((angle * Mathf.PI)/180f);
    		float dY = transform.position.y + Mathf.Cos((angle * Mathf.PI)/180f);
    		Vector3 angVelocity = new Vector3(dX,dY,0f);
    		Vector2 dirBullet = (angVelocity - transform.position).normalized;

    		GameObject bul = BulletPool.bulletPoolInstance.GetBullet();
    			bul.transform.position = transform.position;
    			bul.transform.rotation = transform.rotation;
    			bul.SetActive(true);
    			bul.GetComponent<EnemyBullet>().SetMoveDirection(dirBullet);

    		angle += angleStep;
    	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
