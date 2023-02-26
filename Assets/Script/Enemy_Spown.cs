using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spown : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefabs;
    [SerializeField] private GameObject _startPoint;
    [SerializeField] private GameObject _endPoint;
    public float SpownTimeMin = 2f;
    public float SpownTimeMax = 2f;
    private float nextSpownTime;
    [SerializeField] float zaxise;

    // Start is called before the first frame update
    void Start()
    {
        _startPoint = GameObject.FindWithTag("_startPoint");
        _endPoint = GameObject.FindWithTag("_endPoint");

        nextSpownTime = Time.time + Random.Range(SpownTimeMin, SpownTimeMax);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpownTime)
        {
            SpownEnemy();
            nextSpownTime = Time.time + Random.Range(SpownTimeMin, SpownTimeMax);
        }
    }

    private void SpownEnemy()
    {
        // Get a random point between start and end points
        Vector3 randomPoint = Vector3.Lerp(_startPoint.transform.position, _endPoint.transform.position, Random.value);
        // Instantiate enemy at the random point
        Instantiate(_enemyPrefabs, randomPoint, Quaternion.Euler(0f, 0f, zaxise));
    }
}
