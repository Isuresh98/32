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

   public void SpownEnemy()
    {
        // Get all Enemy_Spown objects in the scene
        Enemy_Spown[] spawners = GameObject.FindObjectsOfType<Enemy_Spown>();

        // Choose a random spawner from the list
        int randomIndex = Random.Range(0, spawners.Length);
        Enemy_Spown randomSpawner = spawners[randomIndex];

        // get random point
        Vector3 randomPoint = Vector3.Lerp(_startPoint.transform.position, _endPoint.transform.position, Random.value);

        //instansiate 
        Instantiate(_enemyPrefabs, randomPoint, Quaternion.Euler(0f,0f,zaxise));
    }

    public void SpawnEnemyRandom()
    {
        // Get random point
        Vector3 randomPoint = Vector3.Lerp(_startPoint.transform.position, _endPoint.transform.position, Random.value);

        // Instantiate enemy
        Instantiate(_enemyPrefabs, randomPoint, Quaternion.Euler(0f, 0f, zaxise));
    }

}
