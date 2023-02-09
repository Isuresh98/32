using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spown : MonoBehaviour
{
    [SerializeField]private GameObject _enemyPrefab;
  private GameObject _spawnPoint;
    public float spownTimeMin = 2f;
    public float spownTimeMax = 5f;
    private float nextSpownTime;
    // Start is called before the first frame update
    void Start()
    {
      
        _spawnPoint = GameObject.FindWithTag("SpownPoint");
        nextSpownTime = Time.time + Random.Range(spownTimeMin, spownTimeMax);
    }



// Update is called once per frame
void Update()
    {
        if (Time.time >= nextSpownTime)
        {
            SpownEnemy();
            nextSpownTime = Time.time + Random.Range(spownTimeMin, spownTimeMax);
        }
    }

    private void SpownEnemy()
    {
        Instantiate(_enemyPrefab, _spawnPoint.transform.position, Quaternion.identity);
    }
}
