using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spown : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefabs;
    private GameObject _spowPoint;
    public float SpownTimeMin = 2f;
    public float SpownTimeMax = 2f;
    private float nextSpownTime;
    // Start is called before the first frame update
    void Start()
    {
        _spowPoint = GameObject.FindWithTag("SpownPoint");
        nextSpownTime = Time.time + Random.Range(SpownTimeMin, SpownTimeMax);

    }



    // Update is called once per frame
    void Update()
    {

        if (Time.time >= nextSpownTime)
        {
            SpownEnemy();
            nextSpownTime=Time.time+ Random.Range(SpownTimeMin, SpownTimeMax);
        }
    }

    private void SpownEnemy()
    {
        Instantiate(_enemyPrefabs, _spowPoint.transform.position, Quaternion.identity);
    }

}
