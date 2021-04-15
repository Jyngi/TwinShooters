using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject EnemyPrefab;
    float leftX = -8f;
    float rightX = 8f;
    float yPos = 7f;
    Vector2 leftSpawnPos, rightSpawnPos;
    float time = 0f;
    public float spawnTime = 6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += 1f * Time.deltaTime;

        leftSpawnPos = new Vector2(Random.Range(leftX, 0.0f), yPos);
        rightSpawnPos = new Vector2(Random.Range(0.0f, rightX), yPos);

        if(time >= spawnTime)
        {
            // Spawn enemy on the left
            Instantiate(EnemyPrefab, leftSpawnPos, EnemyPrefab.transform.rotation);

            // Spawn enemy on the right
            Instantiate(EnemyPrefab, rightSpawnPos, EnemyPrefab.transform.rotation);

            // Reset time
            time = 0f;
        }
    }
}
