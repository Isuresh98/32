using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAliancePosision : MonoBehaviour
{
    public GameObject enemyPrefab; // The enemy prefab to be spawned
    public Transform spawnPoint; // The spawn point for the enemies
    public float minSpawnDelay = 1.0f; // The minimum delay before spawning a new enemy
    public float maxSpawnDelay = 5.0f; // The maximum delay before spawning a new enemy

    private float nextSpawnTime; // The time at which the next enemy will be spawned

    // Start is called before the first frame update
    void Start()
    {
        // Set the time for the first enemy spawn
        nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if it's time to spawn a new enemy
        if (Time.time >= nextSpawnTime)
        {
            // Spawn a new enemy
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

            // Set the time for the next enemy spawn
            nextSpawnTime = Time.time + Random.Range(minSpawnDelay, maxSpawnDelay);
        }
    }
    
}
