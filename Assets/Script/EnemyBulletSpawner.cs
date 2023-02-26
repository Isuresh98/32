using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _bulatprefabs;
    [SerializeField] private Transform _spownPoint;
    public float SpownTimeMin = 1f;
    public float SpownTimeMax = 3f;
    private float _nextSpownTime;
    [SerializeField] float Zaxes;

    // Start is called before the first frame update
    void Start()
    {
        // Set the time for the first bullet spawn
        _nextSpownTime = Time.time + Random.Range(SpownTimeMin, SpownTimeMax);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= _nextSpownTime)
        {
            Instantiate(_bulatprefabs, _spownPoint.position, Quaternion.Euler(0f, 0f, Zaxes));

            _nextSpownTime = Time.time + Random.Range(SpownTimeMin, SpownTimeMax);
        }
    }
}
