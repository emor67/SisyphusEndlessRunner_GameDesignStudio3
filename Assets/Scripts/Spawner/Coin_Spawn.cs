using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Spawn : MonoBehaviour
{
    public GameObject coin;
    public float spawnHeight = 1f;
    public float spawnDistance = 2f;
    public float spawnTimeDistance = 1.5f;

    private float lastSpawnTime;

    private void Update()
    {
        if (Time.time > lastSpawnTime + spawnTimeDistance)
        {
            CoinSpawner();
            lastSpawnTime = Time.time;
        }
    }

    void CoinSpawner()
    {
        float spawnX = Random.Range(-spawnDistance, spawnDistance);
        Vector3 spawnPosition = new Vector3(spawnX, spawnHeight, transform.position.z);
        
        Instantiate(coin, spawnPosition, Quaternion.identity);
    }
}
