using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn : MonoBehaviour
{
    public GameObject WallPrefab;
    float yPos = 5f;
    float time = 0f;
    int wallCount = 0;
    Vector2 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        spawnPos = new Vector2(WallPrefab.transform.position.x, yPos);
    }

    // Update is called once per frame
    void Update()
    {
        float spawnTime = 20f + Random.Range(0, 10);
        time += 1 * Time.deltaTime;
        if(time >= spawnTime && wallCount == 0)
        {
            Instantiate(WallPrefab, spawnPos, transform.rotation);
            time = 0;
            wallCount++;
        }
    }
}
