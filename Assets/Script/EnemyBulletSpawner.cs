using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _spawnPoint;
    public float SpawnTimeMin = 1f;
    public float SpawnTimeMax = 3f;
    private float _nextSpawnTime;
    [SerializeField] float Zaxes;

    // Start is called before the first frame update
    void Start()
    {
        // Set the time for the first bullet spawn
        _nextSpawnTime = Time.time + Random.Range(SpawnTimeMin, SpawnTimeMax);
    }

    // Update is called once per frame
    void Update()
    {
        // If it's time to spawn a bullet
        if (Time.time >= _nextSpawnTime)
        {
            // Spawn the bullet at the spawn point
            Instantiate(_bulletPrefab, _spawnPoint.position, Quaternion.Euler(0f,0f,Zaxes));

            // Set the time for the next bullet spawn
            _nextSpawnTime = Time.time + Random.Range(SpawnTimeMin, SpawnTimeMax);
        }
    }
}
